using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UIElements;

public class EventManager : MonoBehaviour
{
    [SerializeField]
    private Canvas _dialoguePrompt;
    /*
    [SerializeField]
    private TextMeshProGUI _title;
    [SerializeField]
    private TextMeshProGUI _description;
    */

    private string _title;
    private string _description;
    private Sprite _image;
    
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
        EventSO nextEvent = Instance.eventsQueue[++Instance.currentEventIndex];
        _title = nextEvent.eventName;
        _description= nextEvent.description;
        _image = nextEvent.image;
    }
    
    
}
