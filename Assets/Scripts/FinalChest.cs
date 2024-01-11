using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class FinalChest : MonoBehaviour
{
    [SerializeField]
    private GameObject end;
    [SerializeField]
    private GameObject Game;
    [SerializeField]
    private GameObject winCanvas;
    public UnityEvent onWin;

    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (end.GetComponent<EndGameDetection>().objectiveCounter >= 4)
        {
            onWin.Invoke();
        }
    }
}
