using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Game : MonoBehaviour
{
    public Charater charater;
    public User user;
    public string gameID;
    public DateTime start;
    public DateTime end;

    string GenID()
    {
        string newID = Guid.NewGuid().ToString("N")[..16];
        return newID;
    }

    public void TakeAction(GameObject action)
    {
        GameObject canvas = GameObject.Find("Canvas"); // находим Canvas в сцене
        Game game = action.GetComponent<Game>();
        game = this;
        Instantiate(action, canvas.transform); // создаем новый объект из префаба и добавляем его на Canvas
    }

    // Start is called before the first frame update
    void Start()
    {
        start = new(DateTime.Now.Ticks);
        gameID = GenID();
        charater = FindObjectOfType<Charater>();
        user = FindObjectOfType<User>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
