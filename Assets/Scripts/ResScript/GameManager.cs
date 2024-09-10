using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    public Animator animator;
    public GameObject instruction;
    public AudioSource music, sfxSource;
    public AudioClip buttonClick;
    public AudioClip[] bgrMusic;
    void Start()
    {
        if (instance == null)
            instance = this;
        int i = Random.Range(0, bgrMusic.Length);
        music.clip = bgrMusic[i];
        music.time = 5f;
        music.Play();
        // Cursor.SetCursor(newCursorTexture, Vector2.zero, CursorMode.ForceSoftware);
    }
    void OnButtonCLick()
    {
        sfxSource.clip = buttonClick;
        sfxSource.Play();
    }
    public void PlayGame()
    {
        OnButtonCLick();
        SceneManager.LoadScene("Scenes/SampleScene");
    }
    public void TurnOnInstruction()
    {
        OnButtonCLick();
        animator.Play("TurnOnInstruction");
        instruction.SetActive(true);
    }
    public void TurnOffInstruction()
    {
        OnButtonCLick();
        animator.Play("TurnOffInstruction");
        StartCoroutine(WaitAnimation());
    }
    IEnumerator WaitAnimation()
    {
        yield return new WaitForSeconds(1f);
        instruction.SetActive(false);
    }
}
