using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using System;
public class HealthBehaviour : MonoBehaviour
{
    private int currentHealth;
    [SerializeField]
    private int maxHealth;
    public UnityEvent OnDie;
    public UnityEvent<int> OnHurt;

    private void Start()
    {
        ResetHealth();
    }
    public void Heal(int healAmount)
    {
        currentHealth += healAmount;
    }

    public void reduceHP(int damage)
    {
        if (this.isActiveAndEnabled)
        {
            currentHealth -= damage;
            OnHurt.Invoke(currentHealth);
            if (currentHealth <= 0)
            {
                currentHealth = 0;
                OnDie.Invoke();
            }
        }
    }

    public void ResetHealth()
    {
        currentHealth = maxHealth;
    }
}
