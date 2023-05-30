using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeBlueAndRed : MonoBehaviour
{
    [SerializeField] private GameObject _bluePlayer;
    [SerializeField] private GameObject _redPlayer;

    private Vector3 _bluePosition;
    private Vector3 _redPosition;

    private void Update()
    {
        _bluePosition = _bluePlayer.GetComponent<Transform>().position;
        _redPosition = _redPlayer.GetComponent<Transform>().position;
    }

    public void _changePlayer()
    {
        _bluePlayer.GetComponent<Transform>().position = _redPosition;
        _redPlayer.GetComponent<Transform>().position = _bluePosition;
    }
}
