using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

public class Respawn : MonoBehaviour
{
    [SerializeField]
    private Renderer[] spawnPoints;
    [SerializeField]
    private GameObject player;

    private void Start()
    {
       spawnPoints = GetComponentsInChildren<Renderer>();
    }
    // Update is called once per frame
    public void respawning()
    {
        player.GetComponent<PlayerController>().enabled = false;
        player.transform.position = checkSpawnPoint();
        if (player.GetComponent<Rigidbody2D>().gravityScale < 2)
        {
            player.GetComponent<Rigidbody2D>().gravityScale = 2;
            player.GetComponent<FlipAndRotate>().FlipY();

        }
        player.GetComponent<PlayerController>().enabled = true;

    }

    public Vector3 checkSpawnPoint()
    {
        Vector3 aux = new Vector3(1000,1000,1000);
        foreach (Renderer i in spawnPoints)
        {

            if (i.isVisible)
            {  
               if(Vector3.Distance(i.transform.position, player.transform.position) < Vector3.Distance(aux, player.transform.position))
                {
                    aux = i.transform.position;
                }
            }
        }
        return aux;
    }
}
