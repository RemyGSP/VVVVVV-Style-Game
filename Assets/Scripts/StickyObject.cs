using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StickyObject : MonoBehaviour
{
    // Start is called before the first frame update
    private void OnCollisionEnter2D(Collision2D collision)
    {
        collision.transform.SetParent(this.transform);
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        collision.transform.parent = this.transform.parent.transform.parent;   
    }
}
