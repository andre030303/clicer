using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class cliczone : MonoBehaviour
{
    [SerializeField] private int zet;
    [SerializeField] private int clic;
    [SerializeField] private TMP_Text indecator;
    [SerializeField] private Sprite[] tanodin;
    [SerializeField] private Sprite[] tandva;
    [SerializeField] private float time;
    [SerializeField] private perenos perenos;
    [SerializeField] private GameObject plusss;
    private Transform spawningpos;

    public void tap()
    {
        if (time <= 0f)
        {
            indecator.text = (int.Parse(indecator.text) + clic).ToString();
            time = 0.001f;
        }
        GameObject pr = Instantiate(plusss,new Vector3(Camera.main.ScreenToWorldPoint(Input.mousePosition).x,Camera.main.ScreenToWorldPoint(Input.mousePosition).y,Camera.main.ScreenToWorldPoint(Input.mousePosition).z + 10) , Quaternion.identity);
        if(perenos.GetComponent<perenos>().save.upg >= 1000)
        {
            pr.GetComponentInChildren<TMP_Text>().text = Mathf.Floor(perenos.GetComponent<perenos>().save.upg / 1000).ToString() + "K";
        }
        else
        {
            pr.GetComponentInChildren<TMP_Text>().text = perenos.GetComponent<perenos>().save.upg.ToString();
        }
        
    }   

    void Awake()
    {
        perenos = (GameObject.Find("perenos")).GetComponent<perenos>();
        switch (perenos.save.scen)
        {
            case 0:
                GetComponent<Image>().sprite = tanodin[perenos.save.csot];
                break;
                    
            case 1:
                GetComponent<Image>().sprite = tandva[perenos.save.csot2];
                break;
        }

        indecator.text = perenos.save.den.ToString();
    }

    void Update()
    {
        perenos.save.den = int.Parse(indecator.text);
        if(time > 0f)
        {
            time -= Time.deltaTime;
        }
    }
    

    public void mnogoclic(int plus)
    {
        clic = plus;

    }
}
