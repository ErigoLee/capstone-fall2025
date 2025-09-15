using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Cube : Observable
{
    public static event Action<Cube> cubeEventAct;
    private void OnTriggerEnter(Collider other)
    {
        Notify(this, NotificationType.box);
        if(cubeEventAct != null)
        {
            cubeEventAct(this);
        }
    }
   

}
