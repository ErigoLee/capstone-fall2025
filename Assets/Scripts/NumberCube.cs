using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
public class NumberCube : Observable
{
    public static event Action<NumberCube> numCubEventAct;

     private void OnTriggerEnter(Collider other)
    {
        Notify(this, NotificationType.numberBox);
        if(numCubEventAct != null)
        {
            numCubEventAct(this);
        }
    }
}
