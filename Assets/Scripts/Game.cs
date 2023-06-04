using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Game : MonoBehaviour
{
    Charater charater;
    User user;
    string gameID;
    DateTime start;
    DateTime end;

    string GenID()
    {
        string newID = Guid.NewGuid().ToString("N").Substring(0, 16);
        return newID;
    }

    // Start is called before the first frame update
    void Start()
    {
        start = new(DateTime.Now.Ticks);
        gameID = GenID();

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
