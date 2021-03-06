﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EffectBox : MonoBehaviour
{
    public static List<string> box { private set; get; }

    private void Awake()
    {
        box = new List<string>();
    }

    public void AddEffect(string effect_name)
    {
        box.Add(effect_name);
    }

    public bool IsHold(string effect_name)
    {
        return box.Contains(effect_name);
    }

    public bool IsHoldAll(List<string> effect_names)
    {
        foreach (var item in effect_names)
        {
            if(!box.Contains(item))
            {
                return false;
            }
        }
        return true;
    }
}
