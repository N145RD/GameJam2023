using System.Collections;
using System.Collections.Generic;
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
    private Image _image;
    
    public void ShowEvent()
    {
        _dialoguePrompt.gameobject.setActive(true);
        _dialoguePrompt.enabled = true;
    }
    
    public void HideEvent()
    {
        _dialoguePrompt.gameobject.setActive(false);
        _dialoguePrompt.enabled = false;
    }
    
    public void NextEvent()
    {
        EventSO nextEvent = Instance.eventsQueue[++Instance.currentEventIndex];
        _title = nextEvent.title;
        _description= nextEvent.description;
        _image = nextEvent.image;
    }
    
    
}
