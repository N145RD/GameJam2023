using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public float timeLeft = 10;
    public float energyLeft = 10;
    public float charisma = 2;
    public EventSO[] eventsQueue;
    public static GameManager Instance;
    public int currentEventIndex = 0;
    private void Awake()
    {
        if (Instance == null)
            Instance = this;
        else
            Destroy(gameObject);
        DontDestroyOnLoad(gameObject);
    }
}
