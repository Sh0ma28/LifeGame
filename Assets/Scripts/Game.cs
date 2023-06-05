using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class Game : MonoBehaviour
{
    public Character character;
    public StatisticsPanel statistics;
    public ResourcesPanel resources;

    // Start is called before the first frame update
    void Start()
    {
        character = FindObjectOfType<Character>();
    }

}
