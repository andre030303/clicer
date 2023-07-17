using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Runtime.InteropServices;
using TMPro;

public class langvege : MonoBehaviour
{
    [SerializeField] private string[] lan;
    [SerializeField] private GameObject perenos;
    [SerializeField] private TMP_Text texte;

    private void Awake()
    {
        perenos = GameObject.Find("perenos");
        texte = GetComponent<TMP_Text>();
        if(perenos.GetComponent<perenos>().lang == "ru")
        {
            texte.text = lan[0];
        }
        else if(perenos.GetComponent<perenos>().lang == "tr")
        {
            texte.text = lan[1];
        }
        else
        {
            texte.text = lan[2];
        }
    }
}
