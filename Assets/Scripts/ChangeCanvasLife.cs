using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ChangeCanvasLife : MonoBehaviour
{
    public void UpdateCanvas(int currentHealth)
    {
        this.GetComponent<TextMeshProUGUI>().text = "Lifes: " + currentHealth;
    }

}
