using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class ResetGame : MonoBehaviour
{
    [SerializeField]
    private GameObject player;
    [SerializeField]
    private GameObject start;
    [SerializeField]
    private GameObject HUD;
    [SerializeField]
    private GameObject canvas;
    public void Restart()
    {
        player.transform.position = start.transform.position;
        player.GetComponent<HealthBehaviour>().ResetHealth();
        player.GetComponent<Rigidbody2D>().gravityScale = 2.0f;
        Transform[] hudItems = HUD.GetComponentsInChildren<Transform>();
        foreach (Transform i in hudItems)
        {
            i.gameObject.SetActive(false);
        }

        GetComponent<EndGameDetection>().objectiveCounter = 0;
        canvas.GetComponent<TextMeshProUGUI>().text = "Lifes: 10";

    }
}
