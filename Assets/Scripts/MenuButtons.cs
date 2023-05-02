using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuButtons : MonoBehaviour
{
    [SerializeField] private GameObject authors;
    private bool isActive = false;
    public void StartGame()
    {
        _GLOBAL.LoadScene(1);
    }

    public void ToggleAutors()
    {
        isActive = !isActive;
        authors.SetActive(isActive);
    }

    public void ExitGame()
    {
        Application.Quit();
    }
}
