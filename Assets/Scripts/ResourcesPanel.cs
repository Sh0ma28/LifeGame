using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ResourcesPanel : MonoBehaviour
{
    public TMP_Text health;
    public TMP_Text money;
    public TMP_Text time;
    public Character character;

    public void Updating()
    {
        health.text = character.health.ToString();
        money.text = character.money.ToString();
        time.text = character.time.ToString();
    }

    void Start()
    {
        character = FindObjectOfType<Character>();
        Updating();
    }
}
