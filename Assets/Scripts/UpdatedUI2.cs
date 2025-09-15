using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class UpdatedUI2 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
       Container.ContainerEventAct +=UpdateConText;
    }

    void UpdateConText(object c)
    {
        GetComponent<TextMeshProUGUI>().text = "Congrats! An item was put into the container.";
    }
    
}
