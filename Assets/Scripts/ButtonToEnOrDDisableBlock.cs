using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonToEnOrDDisableBlock : MonoBehaviour
{
    [SerializeField] private GameObject _buttonToDisappear;
    [SerializeField] private GameObject _buttonToAppear;
    [SerializeField] private GameObject _object;
    [SerializeField] private Material _newMaterial;
    [SerializeField] private Material _oldMaterial;
    [SerializeField] private AudioSource _buttonClick;

    private Renderer _renderer;
    private Collider _collider;

    private void Start()
    {
        _renderer = _object.GetComponent<Renderer>();
        _collider = _object.GetComponent<Collider>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.name == _buttonToDisappear.name)
        {
            _buttonClick.Play();
            _renderer.material = _newMaterial;
            _collider.isTrigger = true;
        }
        if (other.name == _buttonToAppear.name)
        {
            _buttonClick.Play();
            _renderer.material = _oldMaterial;
            _collider.isTrigger = false;
        }
    }
}
