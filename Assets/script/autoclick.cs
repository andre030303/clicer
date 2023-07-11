using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class autoclick : MonoBehaviour
{
    [SerializeField] private TMP_Text indecator;
    [SerializeField] private int auclick;
    [SerializeField] private float time;
    [SerializeField] private float lengthtime = 10f;

    void Update()
    {
        if(time <= 0f)
        {
            indecator.text = (int.Parse(indecator.text) + auclick).ToString();
            time = lengthtime;
        }

        if(time > 0f)
        {
            time -= Time.deltaTime;
        }
    }
    
    public void upautoclick(int dat)
    {
        auclick = dat;
    }

    public void uptetime(float dat)
    {
        lengthtime = dat;
    }
}
