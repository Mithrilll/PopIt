using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ExitMenuHandler : MonoBehaviour
{
    public GameObject mExitMenuPanel;

    public void Exit()
    {
        Application.Quit();
    }
    public void ClosePanel()
    {
        mExitMenuPanel.SetActive(false);
    }
}
