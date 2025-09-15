using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AchivementSystem : MonoBehaviour, Observer
{
    // OnNotify is called when Achievement System receives a notification from an object
    public void OnNotify(object obj, NotificationType notificationType)
    {
        if (notificationType == NotificationType.numberBox)
        {
            Debug.Log("Congrats on grabbing the numberbox!");
        }

        if(notificationType == NotificationType.box)
        {
            Debug.Log("Congrats on grabbing the box!");
        }

        if (notificationType == NotificationType.container_box)
        {
            Debug.Log("Congrats! An item was put into the container.");
        }
    }

    void Start()
    {
        // add Achievement System object as observer to all observable objects
        foreach (Observable subject in FindObjectsOfType<Observable>())
        {
            subject.AddObserver(this);
        }
    }

}

