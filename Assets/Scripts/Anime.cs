using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Anime : MonoBehaviour
{
    string[] Phrases = { "О, привет! :)",
                         "Наконец-то ты прошел этот тест!",
                         "Гип-гип ура!",
                         "Тут довольно банальное управление, но все же...",
                         "Для передв ижения направо",
                         "найди кнопку \"D\" на клавиатуре и нажми на нее",
                         "Кнопку можно зажать",
                         "Тогда самурай будет бежать без остановки.",
                         "Для передв ижения влево",
                         "Найди кнопку \"A\" на клавиатуре",
                         "И нажми на нее",
                         "Ее тоже можно зажать.",
                         "Для прыжка нажми ПРОБЕЛ.",
                         "Если нажимать прыжок",
                         "С кнопками перемещения вправо (D) или влево (A)",
                         "То ты сможешь выбирать направление прыжка.",
                         "Запрыгни на эту платформу",
                         "О, что это?",
                         "Ты видишь? ",
                         "Лучше не подходи, он может напасть.",
                         "Если ты столкнешься с ним то в миг проиграешь!",
                         "У тебя нет оружия :(",
                         "Поэтому един стве нный способ пройти - увер нут ься",
                         "Ещё одно чудище, которое может встретиться на твоем пути.",
                         "Это летающая голова демона",
                         "Берегись!!!",
                         "Она выпускает огненные шары!!",
                         "Они могут тебе навредить!",
                         "Чтобы увор ачива ться от них придется прыгать.",
                         "Для прыжка нажимай каждый раз ПРОБЕЛ,",
                         "Ты это уже умеешь)",
                         "Осторожно!!!",
                         "Нужно смотреть под ноги!!",
                         "Здесь встречаются опасные шипы!",
                         "Но их можно легко пере прыг нуть.",
                         "Шипы снимают одно здоровье",
                         "Но дают",
                         "Неуяз вимость",
                         "На 0.5 секунд!",
                         "Спасибо",
                         "за прохождение этого",
                         "уровня туторила",
                         "И сейчас время купить",
                         "По",
                         "Л",
                         "н",
                         "у",
                         "Ю",
                         "Версию этой игры",
                         ":)",
                         ":))",
                         ":)))",
                         "Ой",
                         "Я переключу тебя",
                         "на следующую сцену",
                         "прямо",
                         "прямо?",
                         "прямо??",
                         "Сейчас!",
                         ":)"};

    string[] Emotions = { "girlie_happy",
                         "girlie_calm",
                         "girlie_happy",
                         "girlie_angry",
                         "girlie_calm",
                         "girlie_calm",
                         "girlie_calm",
                         "girlie_happy",
                         "girlie_calm",
                         "girlie_calm",
                         "girlie_calm",
                         "girlie_happy",
                         "girlie_calm",
                         "girlie_calm",
                         "girlie_calm",
                         "girlie_calm",
                         "girlie_calm",
                         "girlie_angry",
                         "girlie_angry",
                         "girlie_calm",
                         "girlie_calm",
                         "girlie_angry",
                         "girlie_happy",
                         "girlie_calm",
                         "girlie_calm",
                         "girlie_angry",
                         "girlie_angry",
                         "girlie_angry",
                         "girlie_calm",
                         "girlie_calm",
                         "girlie_happy",
                         "girlie_angry",
                         "girlie_angry",
                         "girlie_calm",
                         "girlie_happy",
                         "girlie_calm",
                         "girlie_calm",
                         "girlie_calm",
                         "girlie_calm",
                         "girlie_happy",
                         "girlie_calm",
                         "girlie_calm",
                         "girlie_calm",
                         "girlie_happy",
                         "girlie_happy",
                         "girlie_happy",
                         "girlie_happy",
                         "girlie_happy",
                         "girlie_calm",
                         "girlie_happy",
                         "girlie_happy",
                         "girlie_happy",
                         "girlie_calm",
                         "girlie_calm",
                         "girlie_calm",
                         "girlie_calm",
                         "girlie_calm",
                         "girlie_calm",
                         "girlie_happy",
                         "girlie_happy"};

    public TMP_Text text;
    public Image girlie;
    public int countPhrase = 0;

    //private GameObject girlieObj;

    public Sprite girlie_happy;
    public Sprite girlie_calm;
    public Sprite girlie_angry;

    // Start is called before the first frame update
    void Start()
    {
        text.text = Phrases[countPhrase];
    }

    public void Change()
    {
        if (countPhrase < Phrases.Length-1)
        {
            countPhrase += 1;
            text.text = Phrases[countPhrase];

            if (Emotions[countPhrase]== "girlie_happy")
                girlie.sprite = girlie_happy;
            else if (Emotions[countPhrase] == "girlie_calm")
                girlie.sprite = girlie_calm;
            else
                girlie.sprite = girlie_angry;
        }
        else
        {
            //Переход на сцену с РикРолом
        }
    }


}
