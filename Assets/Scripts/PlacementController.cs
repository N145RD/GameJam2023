using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlacementController : MonoBehaviour
{
    [SerializeField]
    private Transform _previewer;
    [SerializeField]
    private bool _active = false;

    // Update is called once per frame
    void Update()
    {
        if (_active) {
            Vector3 screenPoint = Input.mousePosition;
            screenPoint.z = 10.0f; //distance of the plane from the camera
            _previewer.position = Camera.main.ScreenToWorldPoint(screenPoint);
        }
    }
}
