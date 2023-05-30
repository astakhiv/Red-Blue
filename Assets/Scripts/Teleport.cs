using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleport : MonoBehaviour
{
    [SerializeField] private GameObject _startPortal;
    [SerializeField] private GameObject _endPortal;
    [SerializeField] private GameObject _cameraToMove;
    [SerializeField] private bool _changeCameraPosition;
    [SerializeField] private Vector3 _cameraNewPosition;
    [SerializeField] private AudioSource _portalSound;

    private Transform _endPortalTransform;

    private void Start()
    {
        _endPortalTransform = _endPortal.GetComponent<Transform>();
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag(_startPortal.tag))
        {
            _portalSound.Play();
            this.GetComponent<Transform>().position = _endPortalTransform.position;

            if (_changeCameraPosition)
            {
                _cameraToMove.GetComponent<Transform>().position = _cameraNewPosition;
            }
        }
    }
}
