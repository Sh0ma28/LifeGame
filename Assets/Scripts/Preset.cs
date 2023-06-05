using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class Preset : MonoBehaviour
{
    public Character character;
    const int maxStat = 10;
    public TMP_Text intelegent;
    public TMP_Text sociability;
    public TMP_Text leadership;
    public TMP_Text luck;
    public TMP_Text physical;
    public TMP_Text charm;
    public TMP_Text happiness;
    public TMP_Text profSkills;
    public bool isMain;

    public void Pick()
    {
        Preset main = FindObjectOfType<Preset>();
        main.character = character;
        Debug.Log(main.name);
    }

    public void Updating()
    {
        intelegent.text = string.Format("Интеллект: {0}/{1}", character.intelegent.ToString(), maxStat);
        sociability.text = string.Format("Общительность: {0}/{1}", character.sociability.ToString(), maxStat);
        leadership.text = string.Format("Лидерство: {0}/{1}", character.leadership.ToString(), maxStat);
        luck.text = string.Format("Удача: {0}/{1}", character.luck.ToString(), maxStat);
        physical.text = string.Format("Физ.сила: {0}/{1}", character.physical.ToString(), maxStat);
        charm.text = string.Format("Обаяние: {0}/{1}", character.charm.ToString(), maxStat);
        happiness.text = string.Format("Счастье: {0}/{1}", character.happiness.ToString(), maxStat);
        profSkills.text = string.Format("Проф.навыки: {0}/{1}", character.profSkills.ToString(), maxStat);
    }
    void Start()
    {
        if (!isMain) Updating();
    }
}
