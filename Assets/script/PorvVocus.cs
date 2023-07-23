using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PorvVocus : MonoBehaviour
{
    void OnApplicationFocus(bool hasFocus)
    {
        if(GetComponent<menu>().PorvVocus)
        {
            pause(!hasFocus);
        }
    }

    void OnApplicationPause(bool pauseStatus)
    {
        if(GetComponent<menu>().PorvVocus)
        {
            pause(pauseStatus);
        }
    }

    void pause(bool silence)
    {
        AudioListener.pause = silence;
    }
}
