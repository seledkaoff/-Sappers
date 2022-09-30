using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Crosshair : MonoBehaviour
{
    private Camera _camera;

    private void Start()
    {
        _camera = Camera.main; 
        Cursor.visible = true; 
    }

    private void Update()
    {
        Vector3 crosshairPosition = _camera.ScreenToWorldPoint(Input.mousePosition); 
        transform.position = new Vector3(crosshairPosition.x, crosshairPosition.y, transform.position.z); 
    }
}
