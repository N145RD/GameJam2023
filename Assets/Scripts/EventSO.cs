using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Data", menuName = "ScriptableObjects/EventSO", order = 1)]
public class EventSO : ScriptableObject
{
    public string name;
    public string description;
    public Sprite image;
    public string[] tags;
}
