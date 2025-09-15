using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AchivementSystem : MonoBehaviour, Observer
{
    // OnNotify is called when Achievement System receives a notification from an object
    public void OnNotify(object obj, NotificationType notificationType)
    {
        if (notificationType == NotificationType.GreenCubeCollected)
        {
            Debug.Log("Congrats! Achievement unlocked! (Observer Pattern version)");
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

