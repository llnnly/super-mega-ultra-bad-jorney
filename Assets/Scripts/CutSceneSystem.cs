using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CutSceneSystem : MonoBehaviour
{
    public string[] lines;
    public float speedText;
    public Text sceneText;

    public Sprite sprite1;
    public Sprite sprite2;
    public Sprite sprite3;
    public Sprite sprite4;
    public Sprite sprite5;
    public Sprite sprite6;
    public Sprite sprite7;
    public Sprite textbg1;
    public Sprite textbg2;

    public Image background;
    public Image text;
    public int index;
    private int check;
    private void Start()
    {
        sceneText.text = string.Empty;
        StartScene();
    }

    void StartScene()
    {
        index = 0;
        check = 0;
        StartCoroutine(TypeLine());
    }
    IEnumerator TypeLine()
    {
        foreach(char c in lines[index].ToCharArray())
        {
            sceneText.text += c;
            yield return new WaitForSeconds(speedText);
        }
    }

    public void ScipTextClick()
    {
        if(sceneText.text == lines[index])
        {
            if (check == 0 || check == 1)
            {
                background.sprite = sprite1;
                text.sprite = textbg1;
            }
            else
            {
                if (check == 2 || check == 3)
                {
                    background.sprite = sprite2;
                    text.sprite = textbg2;
                }
                else
                {
                    if (check == 4)
                    {
                        background.sprite = sprite3;
                        text.sprite = textbg2;
                    }
                    else
                    {
                        if (check == 5)
                        {
                            background.sprite = sprite4;
                            text.sprite = textbg2;
                        }
                        else
                        {
                            if (check == 6)
                            {
                                background.sprite = sprite5;
                                text.sprite = textbg2;
                            }
                            else
                            {
                                if (check >= 7 && check <= 9)
                                {
                                    background.sprite = sprite6;
                                    text.sprite = textbg2;
                                }
                                else
                                {
                                    if (check == 10 || check == 11)
                                    {
                                        background.sprite = sprite7;
                                        text.sprite = textbg2;
                                    }
                                    else
                                    {
                                        if (check == 12 || check == 13)
                                        {
                                            background.sprite = sprite1;
                                            text.sprite = textbg1;
                                        } else
                                        {
                                            _GLOBAL.LoadScene(2);
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
            NextLines();
        }
        else
        {
            StopAllCoroutines();
            sceneText.text = lines[index];
        }
    }
    private void NextLines()
    {
        if(index < lines.Length - 1)
        {
            index++;
            check++;
            sceneText.text = string.Empty;
            StartCoroutine(TypeLine());
        }
        else
        {
            gameObject.SetActive(false);
        }
    }

    void Update()
    {
        if(Input.GetKeyDown("space"))
        {
            ScipTextClick();
        }
    }
}
