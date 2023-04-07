using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankSpawner : MonoBehaviour
{
    [SerializeField] GameObject tankPrefab;

    // Start is called before the first frame update
    void Start()
    {
        Instantiate(tankPrefab, Vector3.zero, Quaternion.identity);
    }
}
