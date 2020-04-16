﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class EffectGenerator : MonoBehaviour
{
    [SerializeField, TextArea(1,3)]
    string effect_name;
    [SerializeField]
    GameObject effect_base;
    [SerializeField]
    bool StartSpawn = true;

    // Start is called before the first frame update
    void Start()
    {
        if(effect_base== null)
        {
            effect_base = (GameObject)Resources.Load("effect_base");
        }
        if(StartSpawn)
        {
            Spawn();
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public GameObject Spawn()
    {
        GameObject instance = Instantiate(effect_base,transform);
        instance.GetComponent<TextMeshPro>().text = effect_name;
        return instance;
    }
}