using System.Collections.Generic;
using UnityEngine;

public class PoolObject : MonoBehaviour
{
    [SerializeField] private List<GameObject> _cubes;
    private float _TimeSinceLastSpawn;
    private void Update()
    {
        _TimeSinceLastSpawn += Time.deltaTime;
        bool value = DataControll.TimeToNextSpawn != 0 && DataControll.Velocity != 0;
        if (_TimeSinceLastSpawn > DataControll.TimeToNextSpawn && value)
        {
            Spawn();
            _TimeSinceLastSpawn = 0;
        }
    }
    private void Spawn()
    {
        for (int i = 0; i < _cubes.Count; i++)
        {
            if (!_cubes[i].activeSelf)
            {
                _cubes[i].SetActive(true);
                return;
            }
        }
    }
}
