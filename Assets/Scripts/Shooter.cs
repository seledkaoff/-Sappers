using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Shooter : MonoBehaviour
{
    [SerializeField] private Hit _hit;
    [SerializeField] private float _hitLifeTime;

    private Camera _camera;
   

    private void Start()
    {
        _camera = Camera.main; 
    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Vector3 mousePosition = Input.mousePosition; 
            Ray shootingRay = _camera.ScreenPointToRay(mousePosition); 
            RaycastHit2D hitInfo = Physics2D.Raycast(shootingRay.origin, shootingRay.direction); 

            if (hitInfo.collider != null && hitInfo.collider.TryGetComponent(out Target target) && Time.timeScale != 0) 
                target.Hit(); 
            }
        }
    }


