using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackGroundSound : MonoBehaviour

{
    public static BackGroundSound backgroundSound;

    void Awake()
    {
        if (backgroundSound== null)
        {
            backgroundSound = this;
            DontDestroyOnLoad( gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

}
