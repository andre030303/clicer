using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Runtime.InteropServices;

[System.Serializable]

public class save
{
    public int scen;
    public int csot;
    public int den;
}
public class perenos : MonoBehaviour
{
    public save save;
    [SerializeField] private float time;

    [DllImport("__Internal")]
    private static extern void saveExtern(string date);
    [DllImport("__Internal")]
    private static extern void loadExtern();

    private void Awake()
    {
        DontDestroyOnLoad(this.gameObject);
        loadExtern();
    }

    public void Save()
    {
        string jsonString = JsonUtility.ToJson(save);
        saveExtern(jsonString);
    }

    public void Load(string value)
    {
        save =JsonUtility.FromJson<save>(value);

    }  

    void Update()
    {
        if (time <= 0f)
        {
            Save();
            time = 10f;
        }

        if(time > 0f)
        {
            time -= Time.deltaTime;
        }
    } 
}
