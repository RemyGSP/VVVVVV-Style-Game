using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectableBehaviour : MonoBehaviour
{
    [SerializeField]
    GameObject EndGame;
    private EndGameDetection endGameDetection;

    private void Start()
    {
        endGameDetection = EndGame.GetComponent<EndGameDetection>();
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        endGameDetection.getObjective();
    }
}
