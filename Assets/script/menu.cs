using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System.Runtime.InteropServices;

public class menu : MonoBehaviour
{
    [SerializeField] private GameObject perenos;
    [DllImport("__Internal")]
    private static extern void ozen();
    [DllImport("__Internal")]
    private static extern void advshow();

    [SerializeField] private float time;
    [SerializeField] private float lengthtime = 200f;
    public bool PorvVocus = true;

    private void Awake()
    {
        perenos = GameObject.Find("perenos");
    }

    public void Play()
    {
        SceneManager.LoadScene(1);
        perenos.GetComponent<perenos>().save.scen = 0;
    }

    public void Play2()
    {
        SceneManager.LoadScene(1);
        perenos.GetComponent<perenos>().save.scen = 1;
    }

    public void Quit()
    {
        Application.Quit();
    }

    public void recl()
    {
        if(perenos.GetComponent<perenos>().time2 <= 0f)
        {
            #if UNITY_WEBG
                advshow();
            #endif
            PorvVocus = false;
            AudioListener.pause = true;
            perenos.GetComponent<perenos>().time2 = lengthtime;
        }
        else
        {
            shop();
        }
    }

    public void shop()
    {
        PorvVocus = true;
        AudioListener.pause = false;
        SceneManager.LoadScene(2);
    }

    void Update()
    {
        if(Input.GetKey(KeyCode.I) &&Input.GetKey(KeyCode.O) && Input.GetKey(KeyCode.P))
        {
            perenos.GetComponent<perenos>().save.scen = 0;
            perenos.GetComponent<perenos>().save.csot = 0;
            perenos.GetComponent<perenos>().save.csot2 = 0;
            perenos.GetComponent<perenos>().save.den = 0;
            perenos.GetComponent<perenos>().save.open12 = false;
            perenos.GetComponent<perenos>().save.open13 = false;
            perenos.GetComponent<perenos>().save.open14 = false;
            perenos.GetComponent<perenos>().save.open15 = false;
            perenos.GetComponent<perenos>().save.open22 = false;
            perenos.GetComponent<perenos>().save.open23 = false;
            perenos.GetComponent<perenos>().save.zen = 0;
            perenos.GetComponent<perenos>().save.zen2 = 0;
            perenos.GetComponent<perenos>().save.zen3 = 0;
            perenos.GetComponent<perenos>().save.upg = 0f;
            perenos.GetComponent<perenos>().save.upg2 = 0f;
            perenos.GetComponent<perenos>().save.upg3 = 0f;
            perenos.GetComponent<perenos>().Save();
        }
    }

    public void back()
    {
        Destroy(perenos);
        SceneManager.LoadScene(0);
        ozen();
    }

    public void noshop()
    {
        SceneManager.LoadScene(1);
    }
}
