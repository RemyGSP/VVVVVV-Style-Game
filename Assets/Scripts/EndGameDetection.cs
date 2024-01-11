using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class EndGameDetection : MonoBehaviour
{
    [SerializeField]
    public int objectiveCounter;
    [SerializeField]
    private GameObject tombContainer;

    public void getObjective()
    {
        objectiveCounter++;
    }

    public void loseObjective()
    {
        objectiveCounter--;
    }

    public void DestroyTombs()
    {
        Transform[] tombs = tombContainer.GetComponentsInChildren<Transform>();
        
        for (int i = 1; i < tombs.Length;i++)
        {
            Destroy(tombs[i].gameObject);
        }
    }
    public void ExitGame()
    {
        Application.Quit();
    }
}
