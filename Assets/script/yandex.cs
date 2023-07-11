using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Runtime.InteropServices;
using TMPro;

public class yandex : MonoBehaviour
{
    [SerializeField] private TMP_Text indecator;
    [DllImport("__Internal")]
    private static extern void Hello();

    public void Stas()
    {
        Hello();
    }

    public void nemenes(string name)
    {
        indecator.text = name;
    }
}
