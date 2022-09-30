using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootingGallery : MonoBehaviour
{
    [SerializeField] private TargetsGroup[] _targetsGroups;
    [SerializeField] private float _showDelay;
    [SerializeField] private int _minShowCount;
    [SerializeField] private int _maxShowCount;

    private float _currentTime;
    private void Update()
    {
        _currentTime += Time.deltaTime;

        if (_currentTime > _showDelay)
        {
            int spawnCount = Random.Range(_minShowCount, _maxShowCount);

            for (int i = 0; i < spawnCount; i++)
            {
                _targetsGroups[Random.Range(0, _targetsGroups.Length)].ShowRandomTarget(); 
            }

            _currentTime = 0;
        }
    }
}
