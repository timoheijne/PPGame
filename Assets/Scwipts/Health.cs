using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    [SerializeField] private float maxHealth = 0;
    private float currentHealth = 0;
    private float armor = 0;
    private float shield = 0;
    public delegate void DieHandler();
    public delegate void HealthChangeHandler(float currentFraction, float change);
    public DieHandler onDie;
    public HealthChangeHandler onHealthChange;

    private void Start()
    {
        currentHealth = maxHealth;
    }

    public float getHealthFraction()
    {
        return currentHealth / maxHealth;
    }

    public bool doDamage(float damage)
    {
        float damageDone = Mathf.Min(damage, currentHealth);
        currentHealth = Mathf.Max(currentHealth - damage, 0);
        onHealthChange?.Invoke(getHealthFraction(), Mathf.Min(currentHealth, damageDone));

        if (currentHealth <= 0)
        {
            onDie?.Invoke();
            return true;
        }

        return false;
    }

    public void doHeal(float heal)
    {
        if (currentHealth != maxHealth)
        {
            float healDone = Mathf.Min(heal, maxHealth - currentHealth);
            currentHealth = Mathf.Min(currentHealth + heal, maxHealth);
            onHealthChange?.Invoke(getHealthFraction(), Mathf.Min(currentHealth, healDone));
        }
    }

    public float getHealth()
    {
        return currentHealth;
    }
}
