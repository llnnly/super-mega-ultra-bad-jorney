using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using TMPro;
using System;

public class Test : MonoBehaviour
{
    //Мне короче, было лень с файлами разбираться, поэтому все сразу тут описала
    string[] qstArray = {  "Как зовут главного героя?",
                           "Кто украл клинок самуря?",
                           "Кому раньше принадлежал клинок?",
                           "Сколько океанов самурай пересечет, если верить катсцене?",
                           "Что хочет совершить наш самурай?"
                        };

    string[] answArray1 = { "影",
                            "雨",
                            "光",
                            "嘘"
                          };

    string[] answArray2 = { 
                            "Собака",
                            "Лиса",
                            "Хомяк",
                            "Белка"
                          };

    string[] answArray3 = { 
                            "пра-пра-пра-пра-пра-пра-пра-прадедушке",
                            "пра-пра-пра-пра-пра-пра-пра-пра-прадедушке",
                            "пра-пра-пра-пра-пра-пра-пра-пра-пра-прадедушке",
                            "пра-пра-пра-пра-пра-пра-пра-пра-пра-пра-пра-прадедушке"
                          };

    string[] answArray4 = { "1",
                            "2",
                            "3",
                            "4"
                          };

    string[] answArray5 = { "腹切り",
                            "切腹",
                            "自殺",
                            "自滅"
                          };

    string[,] answArray = new string[5, 4]; // <- Это короче массив с массивами
    string[] rightanswArray = { "1", "4", "3", "2", "1"};//номера с правильными ответами
    

    //Вы спросите меня, Аня, НАХУЯ TMP? Я отвечу... я не увидела что есть обычный текст в легаси...
    public TMP_Text qstText;
    public TMP_Text answText1;
    public TMP_Text answText2;
    public TMP_Text answText3;
    public TMP_Text answText4;

    public TMP_Text nmbQstText;

    public int numberQuestion = 0;
    int countRightAnsw = 0;

    public Canvas testCanvas;
    public Canvas windowCanvas;

    public TMP_Text congratsText;
    public TMP_Text correctAnsw;
    public TMP_Text againText;

    public bool IsWin;


    void Start()
    {
        IsWin = false;

        testCanvas.gameObject.SetActive(true);
        windowCanvas.gameObject.SetActive(false);

        for (int i = 0; i < 4; i++)
        {
            answArray[0, i] = answArray1[i];
            answArray[1, i] = answArray2[i];
            answArray[2, i] = answArray3[i];
            answArray[3, i] = answArray4[i];
            answArray[4, i] = answArray5[i];
        }

        qstText.text = qstArray[0];
        answText1.text = answArray[0, 0];
        answText2.text = answArray[0, 1];
        answText3.text = answArray[0, 2];
        answText4.text = answArray[0, 3];
        nmbQstText.text = "1/5";
    }


    void Update()
    {
        qstText.text = qstArray[numberQuestion];
        answText1.text = answArray[numberQuestion, 0];
        answText2.text = answArray[numberQuestion, 1];
        answText3.text = answArray[numberQuestion, 2];
        answText4.text = answArray[numberQuestion, 3];
        nmbQstText.text = numberQuestion+1 + "/5";

    }
    

    public void NextQuestion()
    {
        string numBtn = EventSystem.current.currentSelectedGameObject.name + "";

        //Debug.Log(rightanswArray[numberQuestion] + " " + numBtn);

        if (rightanswArray[numberQuestion] == numBtn)
            countRightAnsw += 1;

        if (numberQuestion < 4)
        {
            numberQuestion += 1;

            //Debug.Log(countRightAnsw);
        }
        else
            Check();
    }

    public void Check()
    {
        testCanvas.gameObject.SetActive(false);
        windowCanvas.gameObject.SetActive(true);

        if (countRightAnsw == 5)
        {

            //Debug.Log("Молодец");
            congratsText.text = "WOW! congratulations!";
            correctAnsw.text = countRightAnsw + "/5";
            againText.text = "Continue";
            IsWin = true;
        }

        else
        {
            //Debug.Log("Ха, лох");
            congratsText.text = "Ha! You don't understand lore of this game!";
            correctAnsw.text = countRightAnsw + "/5";
            againText.text = "Again";
        }
    }

    public void NextScene()
    {
        if (IsWin)
        {
            //переход на игру
            _GLOBAL.LoadScene(3);
        }
        else
        {
            //переход на катсцену
            _GLOBAL.LoadScene(1);
        }

    }

}
