using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Footman : Enemy 
{
    private int _power = 10;
  
        void Start() {
        base.Start();
        setdamageAmount(power);
        // other unique start stuff here...
    }

    void Update() {
        //do things an enemy child would
    }
}