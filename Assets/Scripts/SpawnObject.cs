using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnObject : MonoBehaviour
{
    [SerializeField]
    private GameObject objectToInstantiate;
    [SerializeField]
    private GameObject objectParent;
    public void spawnInstance()
    {
        GameObject b = Instantiate(objectToInstantiate);
        b.transform.position = this.transform.position;
        b.transform.parent = objectParent.transform;
    }
}
