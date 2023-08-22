using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnedObject : MonoBehaviour
{
    private void Start()
    {
        transform.parent = null;
    }
}
