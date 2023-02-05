using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

[CreateAssetMenu(fileName = "Data", menuName = "ScriptableObjects/ChoiceSO", order = 1)]
public class ChoiceSO : ScriptableObject
{
    public string prompt;
    public string effects;
    public int energyDifference;
    public int timeDifference;
    public int charismaDifference;
}
