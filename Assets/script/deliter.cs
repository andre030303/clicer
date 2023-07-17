using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class deliter : MonoBehaviour
{
    [SerializeField] private float time;

    void Update()
    {
        if(time <= 0f)
        {
            Destroy(gameObject);
        }

        if(time > 0f)
        {
            time -= Time.deltaTime;
        }
    }
}
