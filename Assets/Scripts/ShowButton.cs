using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowButton : MonoBehaviour
{
    [SerializeField] private GameObject _red;
    [SerializeField] private GameObject _blue;
    [SerializeField] private GameObject _buttonToShow;

    private int _collisionRed;
    private int _collisionBlue;
    private int _collision;

    private void Update()
    {
        _collisionRed = _red.GetComponent<LevelCompleted>()._collisionRed;
        _collisionBlue = _blue.GetComponent<LvlCompleted>()._collisionBlue;
        _collision = _collisionRed + _collisionBlue;

        if (_collision == 2)
        {
            _buttonToShow.SetActive(true);
        }
    }
}
