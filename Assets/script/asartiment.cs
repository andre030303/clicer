using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class asartiment : MonoBehaviour
{
    [SerializeField] private GameObject Scroll;
    [SerializeField] private int[] nas;
    [SerializeField] private Sprite[] car;
    [SerializeField] private Sprite[] cars;
    [SerializeField] private int[] nas2;
    [SerializeField] private Sprite[] car2;
    [SerializeField] private Sprite[] cars2;
    //[SerializeField] private int[] zen;
    [SerializeField] private GameObject button;
    [SerializeField] private GameObject[] cknopki;
    [SerializeField] private TMP_Text indecator;
    [SerializeField] private perenos perenos;

    void Awake()
    {
        perenos = (GameObject.Find("perenos")).GetComponent<perenos>();
    }

    void Start()
    {
        indecator.text = perenos.save.den.ToString();
        switch (perenos.save.scen)
        {
            case 0:
                if(nas.Length > 0)
                {
                    for(int i = 0; i < nas.Length; i++)
                    {
                        GameObject pr = Instantiate(button, Scroll.transform);
                        if(i == 0)
                        {
                            pr.GetComponentInChildren<TMP_Text>().text = "";
                        }
                        else if(!perenos.open[i])
                        {
                            pr.GetComponentInChildren<TMP_Text>().text = nas[i].ToString();
                        }
                        if(perenos.open[i])
                        {
                            pr.GetComponent<Image>().sprite = cars[i];
                        }
                        else
                        {
                            pr.GetComponent<Image>().sprite = car[i];
                        }
                        int i1 = i;
                        pr.GetComponent<Button>().onClick.AddListener(() => cost1(i1));
                        cknopki[i] = pr;
                    }
                }
                break;
            case 1:
                if(nas2.Length > 0)
                {   
                    for(int i = 0; i < nas2.Length; i++)
                    {
                        GameObject pr = Instantiate(button, Scroll.transform);
                        if(i == 0)
                        {
                            pr.GetComponentInChildren<TMP_Text>().text = "";
                        }
                        else if(!perenos.open2[i])
                        {
                            pr.GetComponentInChildren<TMP_Text>().text = nas2[i].ToString();
                        }
                        if(perenos.open2[i])
                        {
                            pr.GetComponent<Image>().sprite = cars2[i];
                        }
                        else
                        {
                            pr.GetComponent<Image>().sprite = car2[i];
                        }
                        int i1 = i;
                        pr.GetComponent<Button>().onClick.AddListener(() => cost2(i1));
                        cknopki[i] = pr;
                    }
                }
                break;
        
        }

    }

    public void cost1(int smen)
    {
        if(perenos.open[smen])
        {
            perenos.save.csot = smen;
        }
        else if(nas[smen] <= int.Parse(indecator.text))
        {
            indecator.text = (int.Parse(indecator.text) - nas[smen]).ToString();
            perenos.save.den = int.Parse(indecator.text);
            perenos.save.csot = smen;
            perenos.open[smen] = true;
            cknopki[smen].GetComponentInChildren<TMP_Text>().text = "";
            cknopki[smen].GetComponent<Image>().sprite = cars[smen];
        }
    }

    public void cost2(int smen)
    {
        if(perenos.open2[smen])
        {
            perenos.save.csot2 = smen;
        }
        else if(nas2[smen] <= int.Parse(indecator.text))
        {
            indecator.text = (int.Parse(indecator.text) - nas2[smen]).ToString();
            perenos.save.den = int.Parse(indecator.text);
            perenos.save.csot2 = smen;
            perenos.open2[smen] = true;
            cknopki[smen].GetComponentInChildren<TMP_Text>().text = "";
            cknopki[smen].GetComponent<Image>().sprite = cars2[smen];
        }
    }
}
