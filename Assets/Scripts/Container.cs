using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Container : Observable
{
    public static event Action <Container> ContainerEventAct;
    private void OnTriggerEnter(Collider other)
    {
        Notify(this, NotificationType.container_box);
        if(ContainerEventAct != null)
        {
            ContainerEventAct(this);
        }
    }
}
