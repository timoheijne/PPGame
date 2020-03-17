using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Enemy : MonoBehaviour {

    protected float damageAmount = 10f;   
    public float hitPoints = 100f;        
    public float moveRate = 10f;        

    //public PlayerHealth playerHealth;
    public Animator anim;

    public void Start() {
        //playerHealth = GameObject.Find("Player").GetComponent<PlayerHealth>();
        anim = GetComponent<Animator>();
    }

    public void setdamageAmount(int a) 
    {
        damageAmount = a;
    }
}