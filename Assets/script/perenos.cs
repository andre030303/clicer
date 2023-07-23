using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Runtime.InteropServices;
using UnityEngine.SceneManagement;

[System.Serializable]

public class save
{
    public int scen;
    public int csot;
    public int csot2;
    public bool open12;
    public bool open13;
    public bool open14;
    public bool open15;
    public bool open22;
    public bool open23;
    public int den;
    public int zen;
    public int zen2;
    public int zen3;
    public float upg;
    public float upg2;
    public float upg3;
    
}
public class perenos : MonoBehaviour
{
    public save save;

    public bool[] open;
    public bool[] open2;
    [SerializeField] private float time;
    public string lang;
    public float time2;

    [DllImport("__Internal")]
    private static extern void saveExtern(string date);
    [DllImport("__Internal")]
    private static extern void loadExtern();
    [DllImport("__Internal")]
    private static extern string getlang();
    [DllImport("__Internal")]
    private static extern void tabl(int clic);

    private void Awake()
    {
        DontDestroyOnLoad(this.gameObject);
        loadExtern();
        lang = getlang();
    }

    public void Save()
    {
        convert();
        string jsonString = JsonUtility.ToJson(save);
        saveExtern(jsonString);
        tabl(save.den);
    }

    public void Load(string value)
    {
        save =JsonUtility.FromJson<save>(value);
        canvert();
    }  

    public void convert()
    {
        save.open12 = open[1];
        save.open13 = open[2];
        save.open14 = open[3];
        save.open15 = open[4];

        save.open22 = open2[1];
        save.open23 = open2[2];
    }

    public void canvert()
    {
        open[1] = save.open12;
        open[2] = save.open13;
        open[3] = save.open14;
        open[4] = save.open15;

        open2[1] = save.open22;
        open2[2] = save.open23;
    }

    void Update()
    {
        if (time <= 0f && SceneManager.GetActiveScene().buildIndex != 0)
        {
            Save();
            time = 10f;
        }

        if(time > 0f)
        {
            time -= Time.deltaTime;
        }

        if(time2 > 0f)
        {
            time2 -= Time.deltaTime;
        }
    } 
}
