using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Action : MonoBehaviour
{
    public string headname;
    public string describition;
    public Game game;
    public int actionID;

    public int intelegent;
    public int sociability;
    public int leadership;
    public int luck;
    public int physical;
    public int charm;
    public int happiness;
    public int profSkills;

    public int money;
    public int health;
    public int timeDays;

    public void DestroyC()
    {
        game.charater.CardChoose(this);
        Debug.Log($"Name: {headname}  Describition: {describition}. Action destroyed");
        Destroy(gameObject);
    }

    // Start is called before the first frame update
    void Start()
    {
        game = FindObjectOfType<Game>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
