using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthDemo : MonoBehaviour
{
    [SerializeField] GameObject healthBar;
    Health health;
    float healthBarY;
    float healthBarZ;


    void Start()
    {
        healthBarY = healthBar.transform.localScale.y;
        healthBarZ = healthBar.transform.localScale.z;

        health = GetComponent<Health>();
        health.onHealthChange += updateBar;
    }

    private void OnMouseDown()
    {
        if (Input.GetKey(KeyCode.LeftShift))
        {
            health.doHeal(1);
            Debug.Log("heal 1");
        }
        else
        {
            health.doDamage(1);
            Debug.Log("damage 1");
        }
    }

    private void updateBar(float currentFraction, float change)
    {
        healthBar.transform.localScale = new Vector3(currentFraction, healthBarY, healthBarZ);
    }
}
