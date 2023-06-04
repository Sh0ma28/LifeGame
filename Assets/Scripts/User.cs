using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class User : MonoBehaviour
{
    public string login;
    public string password;
    public string username;
    public string userID;
    public List<Game> previousGames;

    string GenID()
    {
        string newID = Guid.NewGuid().ToString("N")[..16];
        return newID;
    }

    void GenUser(string login, string password, string username)
    {
        this.login = login;
        this.password = password;
        this.username = username;
        userID = GenID();
        previousGames = new();
    }

    // Start is called before the first frame update
    void Start()
    {
        if(previousGames != null) 
        {
            GenUser(Guid.NewGuid().ToString("N")[..8], Guid.NewGuid().ToString("N")[..8], "User");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
