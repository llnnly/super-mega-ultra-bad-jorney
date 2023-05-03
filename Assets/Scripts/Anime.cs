using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Anime : MonoBehaviour
{
    string[] Phrases = { "�, ������! :)",
                         "�������-�� �� ������ ���� ����!",
                         "���-��� ���!",
                         "��� �������� ��������� ����������, �� ��� ��...",
                         "��� ������ ������ �������",
                         "����� ������ \"D\" �� ���������� � ����� �� ���",
                         "������ ����� ������",
                         "����� ������� ����� ������ ��� ���������.",
                         "��� ������ ������ �����",
                         "����� ������ \"A\" �� ����������",
                         "� ����� �� ���",
                         "�� ���� ����� ������.",
                         "��� ������ ����� ������.",
                         "���� �������� ������",
                         "� �������� ����������� ������ (D) ��� ����� (A)",
                         "�� �� ������� �������� ����������� ������.",
                         "�������� �� ��� ���������",
                         "�, ��� ���?",
                         "�� ������? ",
                         "����� �� �������, �� ����� �������.",
                         "���� �� ����������� � ��� �� � ��� ����������!",
                         "� ���� ��� ������ :(",
                         "������� ���� ���� ���� ������ ������ - ���� ��� ���",
                         "��� ���� ������, ������� ����� ����������� �� ����� ����.",
                         "��� �������� ������ ������",
                         "��������!!!",
                         "��� ��������� �������� ����!!",
                         "��� ����� ���� ���������!",
                         "����� ���� ����� ���� �� ��� �������� �������.",
                         "��� ������ ������� ������ ��� ������,",
                         "�� ��� ��� ������)",
                         "���������!!!",
                         "����� �������� ��� ����!!",
                         "����� ����������� ������� ����!",
                         "�� �� ����� ����� ���� ���� ����.",
                         "���� ������� ���� ��������",
                         "�� ����",
                         "����� �������",
                         "�� 0.5 ������!",
                         "�������",
                         "�� ����������� �����",
                         "������ ��������",
                         "� ������ ����� ������",
                         "��",
                         "�",
                         "�",
                         "�",
                         "�",
                         "������ ���� ����",
                         ":)",
                         ":))",
                         ":)))",
                         "��",
                         "� ��������� ����",
                         "�� ��������� �����",
                         "�����",
                         "�����?",
                         "�����??",
                         "������!",
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
            //������� �� ����� � ��������
        }
    }


}
