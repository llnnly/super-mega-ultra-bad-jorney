using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UI : MonoBehaviour
{
    static GameObject heart1;
    static GameObject heart2;
    static GameObject heart3;

    private void Start()
    {
        heart1 = transform.Find("heart1").gameObject;
        heart2 = transform.Find("heart2").gameObject;
        heart3 = transform.Find("heart3").gameObject;
        heart1.SetActive(false);
        heart2.SetActive(false);
    }

    public static void ChangeLives(int a)
    {
        heart1.SetActive(false);
        heart2.SetActive(false);
        heart3.SetActive(false);
        switch (a)
        {
            case 1:
                heart1.SetActive(true);
                break;
            case 2:
                heart2.SetActive(true);
                break;
            case 3:
                heart3.SetActive(true);
                break;
        }
    }
}
