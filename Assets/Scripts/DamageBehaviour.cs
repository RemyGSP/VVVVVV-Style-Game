using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageBehaviour : MonoBehaviour
{
    [SerializeField]
    private int damage;
    

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.TryGetComponent(out HealthBehaviour healthBehaviour)){
            healthBehaviour.reduceHP(damage);
        }


    }
}
