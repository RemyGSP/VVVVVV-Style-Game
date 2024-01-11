using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
 * Cambiar el onRemove en objectList
 * quitar al angle de mover los objetos
 * acabar menu
 * empezar por el menu
 */
public class Destroy : MonoBehaviour
{
    [SerializeField]
    private GameObject objectAnimation;
    // Start is called before the first frame update


    public void DestroyObject()
    {
        if (objectAnimation != null)
        {
            Instantiate(objectAnimation, transform.position, Quaternion.identity);
        }
        Destroy(gameObject);
    }
}
