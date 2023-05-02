using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Guide : MonoBehaviour
{
    GameObject anime;
    Player player;
    Anime animeshka;
    TriggerZone t1;
    TriggerZone t2;
    TriggerZone t3;
    TriggerZone t4;
    TriggerZone t5;
    GameObject h;

    // Start is called before the first frame update
    void Start()
    {
        anime = GameObject.Find("Anime").gameObject;
        player = GameObject.Find("Player").gameObject.GetComponent<Player>();
        t1 = GameObject.Find("GameObject1").gameObject.GetComponent<TriggerZone>();
        t2 = GameObject.Find("GameObject2").gameObject.GetComponent<TriggerZone>();
        t3 = GameObject.Find("GameObject3").gameObject.GetComponent<TriggerZone>();
        t4 = GameObject.Find("GameObject4").gameObject.GetComponent<TriggerZone>();
        t5 = GameObject.Find("GameObject5").gameObject.GetComponent<TriggerZone>();
        h = GameObject.Find("Head Enemy").gameObject;

        animeshka = anime.GetComponent<Anime>();
        Show();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("d") && animeshka.countPhrase <= 6)
            Show();
        else if (Input.GetKeyDown("a") && animeshka.countPhrase == 12)
            Show();
        else if (Input.GetKeyDown("space") && animeshka.countPhrase == 13)
            Show();
        else if (t1.isActive && animeshka.countPhrase == 8)
            Show();
        else if (t2.isActive && animeshka.countPhrase == 17)
            Show();
        else if (t3.isActive && animeshka.countPhrase == 23)
            Show();
        else if (t4.isActive && animeshka.countPhrase == 31)
        {
            h.SetActive(false);
            Show();
        }
        else if (t5.isActive && animeshka.countPhrase == 38)
            Show();
    }

    void Hide()
    {
        player.stopped = false;
        anime.SetActive(false);
    }

    void Show()
    {
        player.stopped = true;
        anime.SetActive(true);
    }

    public void ClickOn()
    {
        Debug.Log(animeshka.countPhrase);
        animeshka.Change();
        switch (animeshka.countPhrase)
        {
            case 6:
                anime.SetActive(false);
                break;
            case 8:
                Hide();
                break;
            case 12:
                anime.SetActive(false);
                break;
            case 13:
                Hide();
                break;
            case 17:
                Hide();
                break;
            case 23:
                Hide();
                break;
            case 31:
                Hide();
                break;
            case 38:
                Hide();
                break;
        }

    }

}
