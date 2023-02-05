using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

[CreateAssetMenu(fileName = "Data", menuName = "ScriptableObjects/EventSO", order = 1)]
public class EventSO : ScriptableObject
{
    public string eventName;
    public string description;
    public Sprite image;
    public string[] tags;
}
