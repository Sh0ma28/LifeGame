using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class User : MonoBehaviour
{
    string login;
    string password;
    string username;
    string userID;
    List<string> previousGameIDs;

    string GenID()
    {
        string newID = Guid.NewGuid().ToString("N");
        return newID;
    }

    void GenUser(string login, string password, string username)
    {
        this.login = login;
        this.password = password;
        this.username = username;
        userID = GenID();
        previousGameIDs = new();
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
