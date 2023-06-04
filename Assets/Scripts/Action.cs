using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Action : MonoBehaviour
{
    public GameObject charater;
    string headname;
    string describition;

    [SerializeField][Range(-100, 100)] public int intelegent = 0;
    [SerializeField][Range(-100, 100)] public int sociability = 0;
    [SerializeField][Range(-100, 100)] public int leadership = 0;
    [SerializeField][Range(-100, 100)] public int luck = 0;
    [SerializeField][Range(-100, 100)] public int physical = 0;
    [SerializeField][Range(-100, 100)] public int charm = 0;
    [SerializeField][Range(-100, 100)] public int happiness = 0;
    [SerializeField][Range(-100, 100)] public int profSkills = 0;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
