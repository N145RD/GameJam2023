using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public int _currentMinerals;
    public int _maxMinerals;
    public int _energyProduction;
    public int _energyUsage;
    public int _currentBuiltAmount;
    public int _currentGlobalHealth;
    
    public static GameManager Instance;
    private void Awake()
    {
        if (Instance == null)
            Instance = this;
        else
            Destroy(gameObject);
        DontDestroyOnLoad(gameObject);
    }
}
