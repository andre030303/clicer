using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class upgrate : MonoBehaviour
{
    [SerializeField] private cliczone cliczone;
    [SerializeField] private autoclick autoclick;
    private int kalkul;
    [SerializeField] private TMP_Text indecator;
    [SerializeField] private TMP_Text butext1;
    [SerializeField] private TMP_Text butext2;
    [SerializeField] private TMP_Text butext3;
    [SerializeField] private int[] zen;
    [SerializeField] private float[] upg;

    public void upgrateclick()
    {        
        int te = 0;
        if (int.Parse(indecator.text) >= zen[te])
        {
            indecator.text = (int.Parse(indecator.text) - zen[te]).ToString();
            upg[te] = upg[te] + 50;
            cliczone.mnogoclic((int)upg[te]);
            zen[te] = zen[te] * 3;
            butext1.text = zen[te].ToString();  
        }

    }

    public void upgrateautoclick()
    {        
        int te = 1;
        if (int.Parse(indecator.text) >= zen[te])
        {
            indecator.text = (int.Parse(indecator.text) - zen[te]).ToString();
            upg[te] = upg[te] + 10;
            autoclick.upautoclick((int)upg[te]);
            zen[te] = zen[te] * 2;
            butext2.text = zen[te].ToString();
        }
    }

    public void upgratetime()
    {        
        int te = 2;
        if (int.Parse(indecator.text) >= zen[te])
        {
            indecator.text = (int.Parse(indecator.text) - zen[te]).ToString();
            upg[te] = upg[te] - 0.03f;
            autoclick.uptetime(upg[te]);
            zen[te] = zen[te] * 3;
            butext3.text = zen[te].ToString();
        }
    } 
}
