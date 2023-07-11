using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class menu : MonoBehaviour
{
    [SerializeField] private perenos perenos;

    public void Play()
    {
        SceneManager.LoadScene(1);
        perenos.save.scen = 0;
    }

    public void Play2()
    {
        SceneManager.LoadScene(1);
        perenos.save.scen = 1;
    }

    public void Quit()
    {
        Application.Quit();
    }

    public void shop()
    {
        SceneManager.LoadScene(2);
    }

    public void back()
    {
        SceneManager.LoadScene(0);
    }
}
