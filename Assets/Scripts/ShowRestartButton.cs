using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowRestartButton : MonoBehaviour
{
    [SerializeField] private GameObject _restartButton;

    private Vector3 _firstTransform;
    private Vector3 _changedTransform;

    private void Awake()
    {
        _firstTransform = GetComponent<Transform>().position;
    }

    private void Update()
    {
        _changedTransform = GetComponent<Transform>().position;

        if (_changedTransform != _firstTransform)
        {
            _restartButton.SetActive(true);
        }
    }
}
