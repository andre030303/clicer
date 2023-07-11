using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class asartiment : MonoBehaviour
{
    [SerializeField] private GameObject Scroll;
    [SerializeField] private string[] nas;
    [SerializeField] private Sprite[] car;
    [SerializeField] private string[] nas2;
    [SerializeField] private Sprite[] car2;
    [SerializeField] private int[] zen;
    [SerializeField] private GameObject button;
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
                            GameObject pr = Instantiate(button, Scroll.transform, true);
                            //pr.transform.position = new Vector3(-7 + (3 * i), 0, 10);
                            pr.GetComponentInChildren<TMP_Text>().text = nas[i];
                            pr.GetComponent<Image>().sprite = car[i];
                            int i1 = i;
                            pr.GetComponent<Button>().onClick.AddListener(() => cost1(i1));
                        }
                }
                break;
            case 1:
                if(nas2.Length > 0)
                {   
                    for(int i = 0; i < nas2.Length; i++)
                        {
                            GameObject pr = Instantiate(button, Scroll.transform, true);
                            //pr.transform.position = new Vector3(-7 + (3 * i), 0, 10);
                            pr.GetComponentInChildren<TMP_Text>().text = nas2[i];
                            pr.GetComponent<Image>().sprite = car2[i];
                            int i1 = i;
                            pr.GetComponent<Button>().onClick.AddListener(() => cost2(i1));
                        }
                }
                break;
        }

    }

    public void cost1(int smen)
    {
        switch (smen)
        {
            case 0:
                if(zen[smen] <= int.Parse(indecator.text))
                {
                    indecator.text = (int.Parse(indecator.text) - zen[smen]).ToString();
                    GetComponentsInChildren<TMP_Text>()[0].text = "aaaaaaaaaa";
                }
                break;
            case 1:
                if(zen[smen] <= int.Parse(indecator.text))
                {
                    indecator.text = (int.Parse(indecator.text) - zen[smen]).ToString();
                    GetComponentsInChildren<TMP_Text>()[1].text = "aaaaaaaaaa";
                }
                break;
        }
    }

    public void cost2(int smen)
    {
        switch (smen)
        {
            case 0:
                if(zen[smen] <= int.Parse(indecator.text))
                {
                    indecator.text = (int.Parse(indecator.text) - zen[smen]).ToString();
                    GetComponentsInChildren<TMP_Text>()[0].text = "aaaaaaaaaa";
                }
                break;
            case 1:
                if(zen[smen] <= int.Parse(indecator.text))
                {
                    indecator.text = (int.Parse(indecator.text) - zen[smen]).ToString();
                    GetComponentsInChildren<TMP_Text>()[1].text = "aaaaaaaaaa";
                }
                break;
        }
    }
}
