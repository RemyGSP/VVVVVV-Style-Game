using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraTransition : MonoBehaviour
{
    private Respawn rsp;

    private void Start()
    {
        rsp = GetComponent<Respawn>();
    }
    // Update is called once per frame
    void Update()
    {
        Camera cam = Camera.main;
        float height = 2f * cam.orthographicSize;
        float width = height * cam.aspect;
        Vector3 viewPost = Camera.main.WorldToViewportPoint(transform.position);
        if (viewPost.x > 1)
        {
            cam.transform.Translate(width, 0, 0);
        }
        if (viewPost.x < 0)
        {
            cam.transform.Translate(-width, 0, 0);
        }
        if (viewPost.y > 1)
        {
            cam.transform.Translate(0, height, 0);
        }
        if (viewPost.y < 0)
        {
            cam.transform.Translate(0, -height, 0);
        }
    }

}
