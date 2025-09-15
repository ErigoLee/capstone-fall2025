using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class UpdatedUI : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
       Cube.cubeEventAct+=UpdateBoxText;
       NumberCube.numCubEventAct+=UpdateNumBoxText;
       Container.ContainerEventAct +=UpdateConText;
    }

    // this method will be called when cube notifies us that it was collected
    void UpdateNumBoxText(object c)
    {
        GetComponent<TextMeshProUGUI>().text = "Congrats on grabbing the numberbox!";
    }

    void UpdateBoxText(object c)
    {
        GetComponent<TextMeshProUGUI>().text = "Congrats on grabbing the box!";
    }

    void UpdateConText(object c)
    {
        GetComponent<TextMeshProUGUI>().text = "Congrats! An item was put into the container.";
    }
    
}
