using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using TMPro;
using System.IO;
using System;
using UnityEngine.UI;
using UnityEngine.Events;

public class Activity : MonoBehaviour
{
    Dictionary<string, string> activityNames = new()
    {
        { "University", "Университет" },
        { "Army", "Армия" },
        { "Job", "Работа" },
        { "Fun", "Развлечения" },
        { "Home", "Дом" },
    };

    public string title;
    public List<Action> actions;

    public Component content;
    public GameObject menu;

    public void OpenActions()
    {
        menu = (GameObject)Instantiate(Resources.Load("Prefabs/ActivityMenu", typeof(GameObject)), GameObject.Find("Canvas").transform);
        List<Component> children = new(menu.GetComponentsInChildren<Component>());
        foreach (Component c in children)
        {
            if (c.name == "ActivityList") content = c;
            if (c.name == "ActivityNameText") c.GetComponent<TMP_Text>().text = title;
            if (c.name == "ActivityExitButton")
            {
                Button b = c.GetComponent<Button>();
                b.onClick.AddListener(CloseActions);
            }
        }
        foreach (Action a in actions)
        {
            Instantiate(Resources.Load("Prefabs/Button", typeof(GameObject)), content.transform);
        }
        List<Action> actionsUI = new(menu.GetComponentsInChildren<Action>());
        for (int i = 0; i < actions.Count; i++)
        {
            actionsUI[i].Copy(actions[i]);
        }
    }

    

    public void CloseActions()
    {
        Destroy(menu);
    }

    void Start()
    {
        title = activityNames[this.name];

        StreamReader streamReader = new(Application.dataPath + string.Format("/Actions/{0}.txt", this.name));
        string[] strings = (streamReader.ReadToEnd()).Split('\n');
        foreach (string s in strings)
        {
            if (s.Length < 1) continue;
            Action action = new();
            string[] split = s.Split('#');
            action.text = split[0];
            string[] effects = split[1].Split(';');
            foreach (string e in effects)
            {
                string stat = e.Split('_')[0];
                string res = e.Split('_')[1].Trim('=');
                switch (stat)
                {
                    case "status":
                        action.status = res;
                        break;
                    case "health":
                        if (!"+-".Contains(res[0])) action.health = Convert.ToInt32(res);
                        else action.health += Convert.ToInt32(res);
                        break;
                    case "money":
                        if (!"+-".Contains(res[0])) action.money = Convert.ToInt32(res);
                        else action.money += Convert.ToInt32(res);
                        break;
                    case "time":
                        if (!"+-".Contains(res[0])) action.time = Convert.ToInt32(res);
                        else action.time += Convert.ToInt32(res);
                        break;
                    case "int":
                        if (!"+-".Contains(res[0])) action.intelegent = Convert.ToInt32(res);
                        else action.intelegent += Convert.ToInt32(res);
                        break;
                    case "soc":
                        if (!"+-".Contains(res[0])) action.sociability = Convert.ToInt32(res);
                        else action.sociability += Convert.ToInt32(res);
                        break;
                    case "lead":
                        if (!"+-".Contains(res[0])) action.leadership = Convert.ToInt32(res);
                        else action.leadership += Convert.ToInt32(res);
                        break;
                    case "luck":
                        if (!"+-".Contains(res[0])) action.luck = Convert.ToInt32(res);
                        else action.luck += Convert.ToInt32(res);
                        break;
                    case "phys":
                        if (!"+-".Contains(res[0])) action.physical = Convert.ToInt32(res);
                        else action.physical += Convert.ToInt32(res);
                        break;
                    case "charm":
                        if (!"+-".Contains(res[0])) action.charm = Convert.ToInt32(res);
                        else action.charm += Convert.ToInt32(res);
                        break;
                    case "hap":
                        if (!"+-".Contains(res[0])) action.happiness = Convert.ToInt32(res);
                        else action.happiness += Convert.ToInt32(res);
                        break;
                    case "prof":
                        if (!"+-".Contains(res[0])) action.profSkills = Convert.ToInt32(res);
                        else action.profSkills += Convert.ToInt32(res);
                        break;
                    default:
                        break;
                }
            }
            actions.Add(action);
        }
    }

}
