using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Runtime.InteropServices;
using TMPro;

public class yandex : MonoBehaviour
{
    [DllImport("__Internal")]
    private static extern void rec();

    [SerializeField] private TMP_Text indecator;
    [SerializeField] private perenos  perenos;

    private void Awake()
    {
        perenos = (GameObject.Find("perenos")).GetComponent<perenos>();
    }

    public void Stas()
    {
        rec();
        AudioListener.pause = true;
    }

    public void addsmanu()
    {
        indecator.text = (int.Parse(indecator.text) + 2500).ToString();
        perenos.save.den = int.Parse(indecator.text);
        AudioListener.pause = false;

    }
}
