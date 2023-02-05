using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UIElements;

public class EventManager : MonoBehaviour
{
    [SerializeField]
    private Canvas _dialoguePrompt;
    [SerializeField]
    private TextMeshProUGUI _title;
    [SerializeField]
    private TextMeshProUGUI _description;
    [SerializeField]
    private GameObject[] _choiceBoxes;
    public void Start()
    {
        NextEvent();
    }
    
    public void ShowEvent()
    {
        _dialoguePrompt.gameObject.SetActive(true);
        _dialoguePrompt.enabled = true;
    }
    
    public void HideEvent()
    {
        _dialoguePrompt.gameObject.SetActive(false);
        _dialoguePrompt.enabled = false;
    }
    
    public void NextEvent()
    {
        EventSO nextEvent = GameManager.Instance.eventsQueue[GameManager.Instance.currentEventIndex++];
        _title.text = nextEvent.eventName;
        _description.text = nextEvent.description;
        for (int i = 0; i < 3; i++) {
            _choiceBoxes[i].SetActive(false);
        } 
        for (int i = 0; i < nextEvent.choices.Length; i++) {
            _choiceBoxes[i].SetActive(true);
            _choiceBoxes[i].transform.Find("Text").GetComponent<TextMeshProUGUI>().text = nextEvent.choices[i].prompt;
            _choiceBoxes[i].transform.Find("Effects").GetComponent<TextMeshProUGUI>().text = nextEvent.choices[i].effects;
        } 
    }
    
    public void ApplyChoice(int index)
    {
        ChoiceSO choice = GameManager.Instance.eventsQueue[GameManager.Instance.currentEventIndex - 1].choices[index];
        GameManager.Instance.timeLeft += choice.timeDifference;
        GameManager.Instance.energyLeft += choice.energyDifference;
        GameManager.Instance.charisma += choice.charismaDifference;
        StartCoroutine(PlayAnim());
    }

    public void StartEventChain()
    {
        StartCoroutine(PlayAnim());
    }
    IEnumerator PlayAnim()
    {
        HideEvent();
        yield return new WaitForSeconds(4);
        NextEvent();
        ShowEvent();
    }
}
