using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Data", menuName = "ScriptableObjects/ModulesScriptableObject", order = 1)]
public class ModulesScriptableObject : ScriptableObject
{
    public Sprite image;
    
    public string name;
}