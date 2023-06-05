using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.ComponentModel;

public class Character : MonoBehaviour
{
    public const int startAge = 18;
    public const int endAge = 60;
    public const int startTime = 12 * (60 - 18);
    public const int maxStat = 10;
    public bool isPreset;


    [Range(0, maxStat)] public int intelegent = 0;
    [Range(0, maxStat)] public int sociability = 0;
    [Range(0, maxStat)] public int leadership = 0;
    [Range(0, maxStat)] public int luck = 0;
    [Range(0, maxStat)] public int physical = 0;
    [Range(0, maxStat)] public int charm = 0;
    [Range(0, maxStat)] public int happiness = 0;
    [Range(0, maxStat)] public int profSkills = 0;

    public int money = 0;
    [Range(0, maxStat)] public int health = 0;
    public int time = startTime;

    public string status;

    public enum Status { empty }

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
                else if (health + diff >= maxStat) health = maxStat;
                else health += diff;
                break;
            case Perc.Time:
                if (time + diff <= 0) time = 0;
                else time += diff;
                break;
            case Perc.Intelegent:
                if (intelegent + diff <= 0) intelegent = 0;
                else if (intelegent + diff >= maxStat) intelegent = maxStat;
                else intelegent += diff;
                break;
            case Perc.Sociability:
                if (sociability + diff <= 0) sociability = 0;
                else if (sociability + diff >= maxStat) sociability = maxStat;
                else sociability += diff;
                break;
            case Perc.Leadership:
                if (leadership + diff <= 0) leadership = 0;
                else if (leadership + diff >= maxStat) leadership = maxStat;
                else leadership += diff;
                break;
            case Perc.Luck:
                if (luck+ diff <= 0) luck = 0;
                else if (luck + diff >= maxStat) luck = maxStat;
                else luck += diff;
                break;
            case Perc.Physical:
                if (physical + diff <= 0) physical = 0;
                else if (physical + diff >= maxStat) physical = maxStat;
                else physical += diff;
                break;
            case Perc.Charm:
                if (charm + diff <= 0) charm = 0;
                else if (charm + diff >= maxStat) charm = maxStat;
                else charm += diff;
                break;
            case Perc.Happiness:
                if (happiness + diff <= 0) happiness = 0;
                else if (happiness + diff >= maxStat) happiness = maxStat;
                else happiness += diff;
                break;
            case Perc.Professional:
                if (profSkills + diff <= 0) profSkills = 0;
                else if (profSkills + diff >= maxStat) profSkills = maxStat;
                else profSkills += diff;
                break;
        }
    }

    public void LoadPreset(Character c)
    {
        intelegent = c.intelegent;
        sociability = c.sociability;
        leadership = c.leadership;
        luck = c.luck;
        physical = c.physical;
        charm = c.charm;
        happiness = c.happiness;
        profSkills = c.profSkills;
        health = c.health;
    }

    public void ChangeStatus(string s)
    {
        if (s != null) status = s;
    }

    public void PerformAction(Action action)
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
        AddPoints(Perc.Time, action.time);
        ChangeStatus(action.status);
        FindObjectOfType<StatisticsPanel>().Updating();
        FindObjectOfType<ResourcesPanel>().Updating();
    }

    // Start is called before the first frame update
    void Start()
    {
    }
}
