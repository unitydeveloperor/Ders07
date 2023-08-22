using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class InstantiateExample2 : MonoBehaviour
{
    [SerializeField] private GameObject _spawnedObject;
    [SerializeField] private int _spawnCount = 3;
    [SerializeField] private float _xValue = -7;
    [SerializeField] private List<GameObject> _createdObjects;

    private void Start()
    {
        CreateObject();
        PrintObjectNames();
    }

    private void CreateObject()
    {
        GameObject newObject;

        for (int i = 0; i < _spawnCount; i++)
        {
            newObject = Instantiate(_spawnedObject, new Vector3(_xValue, 1, 0), Quaternion.Euler(0, 0, 0), transform);
            newObject.name = "Object : " + i;

            ScaleTween(newObject, Vector3.zero, new Vector3(3, 3, 3));

            _createdObjects.Add(newObject);
            _xValue += 1.5f;
        }
    }

    private void PrintObjectNames()
    {
        for (int i = 0; i < _createdObjects.Count; i++)
        {
            Debug.Log(_createdObjects[i].name);
        }
    }

    private void ScaleTween(GameObject obj, Vector3 from, Vector3 to)
    {
        obj.transform.localScale = from;
        obj.transform.DOScale(to, 0.25f).SetEase(Ease.Linear);
    }
}
