using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstantiateExample : MonoBehaviour
{
    [SerializeField] private List<Color> _objectColors;
    [SerializeField] private GameObject _spawnedObject;
    [SerializeField] private Transform _parentObject;

    private void Start()
    {
        GameObject newObject = Instantiate(_spawnedObject, new Vector3(5, 3, 5), Quaternion.identity);
        newObject.transform.parent = _parentObject;
        newObject.GetComponent<MeshRenderer>().material.color = _objectColors[Random.Range(0, _objectColors.Count)];
    }
}
