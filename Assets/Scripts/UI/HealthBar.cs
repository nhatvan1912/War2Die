using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class HealthBar : MonoBehaviour
{
    public Image fillBar;
    public TextMeshProUGUI healthText;
    public static HealthBar instance;
    void Start()
    {
        if(instance == null)
            instance = this;
    }

    public void UpdateBar(int currentVal, int maxVal)
    {
        fillBar.fillAmount = (float)currentVal / (float)maxVal;
        healthText.text = currentVal.ToString() + " / " + maxVal.ToString();
    }
}
