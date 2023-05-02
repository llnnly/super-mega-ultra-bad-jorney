using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Guide : MonoBehaviour
{
    GameObject anime;

    [SerializeField] private Player player;

    // Start is called before the first frame update
    void Start()
    {
        anime = transform.gameObject;
        Debug.Log(anime);
        Show();
    }

    // Update is called once per frame
    void Update()
    {
    }

    void Hide()
    {
        anime.SetActive(false);
    }

    void Show()
    {
        anime.SetActive(true);
    }
}
