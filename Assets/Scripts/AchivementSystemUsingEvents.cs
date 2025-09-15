using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AchivementSystemUsingEvents : MonoBehaviour
{

    void Start()
    {
        CubeCollectionNotifier.OnCubeColleted += UnlockCubeCollectedAchievement;
        
    }

    private void UnlockCubeCollectedAchievement(CubeCollectionNotifier c)
    {
        Debug.Log("Congrats! Achievement unlocked (Event-based Observer)");
    }

    private void UnlockSphereCollectedAchievement(string c)
    {
        Debug.Log(c);
    }

}
