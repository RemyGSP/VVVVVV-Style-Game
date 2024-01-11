using System.Collections;
using System.Collections.Generic;
using System.Net;
using UnityEngine;

public class MovingObjectBehaviour : MonoBehaviour
{
    private MovementBehaviour mvb;
    [SerializeField]
    bool flipsX, flipsY;
    private FlipAndRotate far;
    [SerializeField]
    GameObject endPoint;
    Vector3 startPos;
    Vector3 dir;
    Vector3 objectivePos;
    private void Start()
    {
        startPos = transform.position;
        objectivePos = endPoint.transform.position;
        dir =  endPoint.transform.position - transform.position;
        far = gameObject.AddComponent<FlipAndRotate>();
        mvb = GetComponent<MovementBehaviour>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Vector3.Distance(transform.position,objectivePos) < 0.01f)
        {
            if (objectivePos == endPoint.transform.position)
            {
                dir = startPos - transform.position;
                objectivePos = startPos;

            }
            else
            {
                dir = endPoint.transform.position - transform.position;
                objectivePos = endPoint.transform.position;
            }
            if (flipsX)
            {
                far.FlipX();
            }
            if (flipsY)
            {
                far.FlipY();
            }
        }
        mvb.Move2D(dir);
    }
}
