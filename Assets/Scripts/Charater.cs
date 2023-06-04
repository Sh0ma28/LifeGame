using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.ComponentModel;

public class Charater : MonoBehaviour
{
    [Range(0, 100)] public int intelegent = 0;
    [Range(0, 100)] public int sociability = 0;
    [Range(0, 100)] public int leadership = 0;
    [Range(0, 100)] public int luck = 0;
    [Range(0, 100)] public int physical = 0;
    [Range(0, 100)] public int charm = 0;
    [Range(0, 100)] public int happiness = 0;
    [Range(0, 100)] public int profSkills = 0;

    public int money = 0;
    [Range(0, 100)] public int health = 0;
    public int timeDays = 365*40;

    public Role role;

    public enum Role {a,b,c}

    public enum Perc { Intelegent, Sociability, Leadership, Luck, Physical, Charm, Happiness, Professional,
                Money, Health, Time}
    public void AddPoints(Perc perc, int diff)
    {
        switch(perc)
        {
            case Perc.Money:
                money += diff;
                break;
            case Perc.Health:
                if (health + diff <= 0) health = 0;
                else if (health + diff >= 100) health = 100;
                else health += diff;
                break;
            case Perc.Time:
                if (timeDays + diff <= 0) health = 0;
                else if (health + diff >= 100) health = 100;
                else health += diff;
                break;
            case Perc.Intelegent:
                if (intelegent + diff <= 0) intelegent = 0;
                else if (intelegent + diff >= 100) intelegent = 100;
                else intelegent += diff;
                break;
            case Perc.Sociability:
                if (sociability + diff <= 0) sociability = 0;
                else if (sociability + diff >= 100) sociability = 100;
                else sociability += diff;
                break;
            case Perc.Leadership:
                if (leadership + diff <= 0) leadership = 0;
                else if (leadership + diff >= 100) leadership = 100;
                else leadership += diff;
                break;
            case Perc.Luck:
                if (luck+ diff <= 0) luck = 0;
                else if (luck + diff >= 100) luck = 100;
                else luck += diff;
                break;
            case Perc.Physical:
                if (physical + diff <= 0) physical = 0;
                else if (physical + diff >= 100) physical = 100;
                else physical += diff;
                break;
            case Perc.Charm:
                if (charm + diff <= 0) charm = 0;
                else if (charm + diff >= 100) charm = 100;
                else charm += diff;
                break;
            case Perc.Happiness:
                if (happiness + diff <= 0) happiness = 0;
                else if (happiness + diff >= 100) happiness = 100;
                else happiness += diff;
                break;
            case Perc.Professional:
                if (profSkills + diff <= 0) profSkills = 0;
                else if (profSkills + diff >= 100) profSkills = 100;
                else profSkills += diff;
                break;
        }
    }

    public void CardChoose(Action action)
    {
        AddPoints(Perc.Intelegent, action.intelegent);
        AddPoints(Perc.Sociability, action.sociability);
        AddPoints(Perc.Leadership, action.leadership);
        AddPoints(Perc.Luck, action.luck);
        AddPoints(Perc.Physical, action.physical);
        AddPoints(Perc.Charm, action.charm);
        AddPoints(Perc.Happiness, action.happiness);
        AddPoints(Perc.Professional, action.profSkills);

        AddPoints(Perc.Money, action.money);
        AddPoints(Perc.Health, action.health);
        AddPoints(Perc.Time, action.timeDays);
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
