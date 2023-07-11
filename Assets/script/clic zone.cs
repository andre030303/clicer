using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class cliczone : MonoBehaviour
{
    [SerializeField] private int zet;
    [SerializeField] private int clic = 100;
    [SerializeField] private TMP_Text indecator;
    [SerializeField] private GameObject tanodin;
    [SerializeField] private GameObject tandva;
    [SerializeField] private float time;
    [SerializeField] private string[] Tapi;
    [SerializeField] private string[] mnclic;
    [SerializeField] private perenos perenos;

    public void tap()
    {
        if (time <= 0f)
        {
            indecator.text = (int.Parse(indecator.text) + clic).ToString();
            time = 0.04f;
        }
    }

    void Awake()
    {
        perenos = (GameObject.Find("perenos")).GetComponent<perenos>();
        if (perenos.save.scen == 0)
        {
            tanodin.SetActive(true);
        } 
        else if(perenos.save.scen == 1)
        {
            tandva.SetActive(true);
        }
        if (perenos.save.csot == 1)
        {
// для костумов
        } 
        else if(perenos.save.csot == 2)
        {

        }

        indecator.text = perenos.save.den.ToString();
        /*if(PlayerPrefs.HasKey(mnclic[perenos.save.scen]))
        {
            indecator.text = PlayerPrefs.GetInt(Tapi[perenos.save.scen]).ToString();
            clic = PlayerPrefs.GetInt(mnclic[perenos.save.scen]);
        }*/
    }

    void Update()
    {
        //PlayerPrefs.SetInt(Tapi[perenos.save.scen], int.Parse(indecator.text));
        perenos.save.den = int.Parse(indecator.text);
        if(time > 0f)
        {
            time -= Time.deltaTime;
        }
    }

    public void mnogoclic(int plus)
    {
        clic = plus;
        //PlayerPrefs.SetInt(mnclic[perenos.save.scen], clic);
    }

    public void delitsev()
    {
        perenos.save.den = 0;
        perenos.Save();
        //PlayerPrefs.DeleteAll();
        //indecator.text = "0";
        //clic = 100;
    }
}
