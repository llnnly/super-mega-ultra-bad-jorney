using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuButtons : MonoBehaviour
{
    public void StartGame()
    {
        _GLOBAL.LoadScene(0);
    }

    public void ExitGame()
    {
        Application.Quit();
    }
}
