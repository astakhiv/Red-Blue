using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LvlCompleted : MonoBehaviour
{
    [SerializeField] private GameObject _finishBlock;

    public int _collisionBlue = 0;
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag(_finishBlock.tag))
        {
            _collisionBlue++;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag(_finishBlock.tag))
        {
            _collisionBlue--;
        }
    }
}
