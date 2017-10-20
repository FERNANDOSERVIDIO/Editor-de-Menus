using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;


public class ChangeScene : MonoBehaviour {

    // Use this for initialization
    public Button yourButton;

    void Start()
    {
        yourButton = this.GetComponent<Button>();
        yourButton.onClick.AddListener(TaskOnClick);
    }

    void TaskOnClick()
    {
        Debug.Log("You have clicked the button!");
    }
}
