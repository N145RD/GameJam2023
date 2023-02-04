using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class PreviewManager : MonoScript
{

    //[SerializeField]
    //private SpriteUI[] _previews;
    [SerializeField]
    private GameObject _current;
    [SerializeField]
    private int _currentIndex;
    [SerializeField]
    private bool _updated;
    
    // Start is called before the first frame update
    void Start()
    {
        _current = null;
    }

    // Update is called once per frame  
    void Update()
    {
        if (_updated) {
            Destroy(_current);
            _updated = false;
            _current = Instantiate(_previews[_currentIndex].prefab, transform.position, transform.rotation);
            _current.transform.parent = transform;
        }
    }
}