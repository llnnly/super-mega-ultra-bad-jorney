using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Anime : MonoBehaviour
{
    string[] Phrases = { "Oh, Hi! :)",
                         "You finally passed this test!",
                         "Yay!",
                         "It's pretty banal management here, but still...",
                         "To move to the right",
                         "Find the \"D\" button on the keyboard and press it.",
                         "The button can be pressed",
                         "Then the samurai will run without stopping.",
                         "To move to the left",
                         "Find the \"A\" button on the keyboard",
                         "And press it.",
                         "It can also be clamped.",
                         "To jump, press the SPACE bar.",
                         "If you press the jump with",
                         "The move buttons to the right (D) or left (A)",
                         "Then you can choose the direction of the jump.",
                         "Jump on this platform",
                         "Oh, what is it?",
                         "Do you see?",
                         "It's better not to approach, he can attack.",
                         "If you run into him, you will lose in an instant!",
                         "You don't have a blade :(",
                         "So, the only way to get through is to dodge.",
                         "Another monster that may come your way.",
                         "It's a flying demon head",
                         "Watch out!!!",
                         "She's releasing fireballs!!",
                         "They can hurt you!",
                         "To dodge them you will have to jump.",
                         "To jump, press the SPACE BAR every time.",
                         "You already know how :)))",
                         "Caution!!!",
                         "You need to look at your feet!!",
                         "There are dangerous spikes here!",
                         "But they can be easily jumped over.",
                         "Spikes remove one health",
                         "But give",
                         "Invulnerability",
                         "For 0.5 seconds!",
                         "Thank you",
                         "for completing this",
                         "level - tutorial.",
                         "And now it's time to buy",
                         "The",
                         "F",
                         "U",
                         "L",
                         "L",
                         "version of this game",
                         ":)",
                         ":))",
                         ":)))",
                         "Oh",
                         "I'll switch you",
                         "to the next scene",
                         "Right",
                         "Right",
                         "Right",
                         "Now",
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
