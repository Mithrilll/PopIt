using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonsHandler : MonoBehaviour
{
    public GameObject mExitMenuPanel;

    void Update()
    {
        if (Input.GetKeyUp(KeyCode.Escape))
        {
            mExitMenuPanel.SetActive(true);
        }
    }
}
