using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    public Animator animator;
    public GameObject instruction;
    public Texture2D newCursorTexture;

    void Start()
    {
        if (instance == null)
            instance = this;
        // Cursor.SetCursor(newCursorTexture, Vector2.zero, CursorMode.ForceSoftware);
    }
    public void PlayGame()
    {
        SceneManager.LoadScene("Scenes/SampleScene");
        Cursor.SetCursor(newCursorTexture, Vector2.zero, CursorMode.ForceSoftware);
    }
    public void TurnOnInstruction()
    {
        animator.Play("TurnOnInstruction");
        instruction.SetActive(true);
    }
    public void TurnOffInstruction()
    {
        animator.Play("TurnOffInstruction");
        StartCoroutine(WaitAnimation());
    }
    IEnumerator WaitAnimation()
    {
        yield return new WaitForSeconds(1f);
        instruction.SetActive(false);
    }
}
