using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Action : MonoBehaviour
{
    public string text;
    public int intelegent = 0;
    public int sociability = 0;
    public int leadership = 0;
    public int luck = 0;
    public int physical = 0;
    public int charm = 0;
    public int happiness = 0;
    public int profSkills = 0;

    public int money = 0;
    public int health = 0;
    public int time = 0;

    public string status = null;

    public TMP_Text tmpText;

    public void UpdateTMPText()
    {
        tmpText.text = text;
    }
    public void Copy(Action action)
    {
        text = action.text;
        intelegent = action.intelegent;
        sociability = action.sociability;
        leadership = action.leadership;
        luck = action.luck;
        physical = action.physical;
        charm = action.charm;
        happiness = action.happiness;
        profSkills = action.profSkills;
        money = action.money;
        health = action.health;
        time = action.time;
        status = action.status;
        UpdateTMPText();
    }

    public void OnClick()
    {
        FindObjectOfType<Character>().PerformAction(this);
        Destroy(transform.parent.parent.parent.gameObject);
    }
}
