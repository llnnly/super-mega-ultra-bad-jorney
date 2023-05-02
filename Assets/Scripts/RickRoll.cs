using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Video;

public class RickRoll : MonoBehaviour
{
    public Canvas canvas;
    public Canvas menu;
    public UnityEngine.Video.VideoPlayer videoPlayer;

    void Start()
    {
        canvas.gameObject.SetActive(false);
        menu.gameObject.SetActive(true);
    }

    public void ClickOnRickRoll()
    {
        canvas.gameObject.SetActive(true);
        menu.gameObject.SetActive(false);

        videoPlayer.Play();
    }

    public void ClickOnExit()
    {
        videoPlayer.Pause();
        //и переход на главное меню
    }
}
