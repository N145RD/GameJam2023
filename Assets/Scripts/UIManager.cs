using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UIManager : MonoBehaviour
{
    [SerializeField]
    private TextMeshProUGUI _energy;
    [SerializeField]
    private TextMeshProUGUI _time;
    [SerializeField]
    private TextMeshProUGUI _charisma;
    
    // Update is called once per frame
    void Update()
    {
        _energy.text = GameManager.Instance.energyLeft.ToString() + "    <sprite index=0>";
        _time.text = GameManager.Instance.timeLeft.ToString() + "    <sprite index=1>";
        _charisma.text = GameManager.Instance.charisma.ToString() + "    <sprite index=2>";
    }
}
