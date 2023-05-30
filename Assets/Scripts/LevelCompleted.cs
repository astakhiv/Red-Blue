using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelCompleted : MonoBehaviour
{
    [SerializeField] private GameObject _finishBlock;

    public int _collisionRed = 0;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag(_finishBlock.tag))
        {
            if (this.CompareTag("RedPlayer"))
            {
                _collisionRed = 1;
            }
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag(_finishBlock.tag))
        {
            if (this.CompareTag("RedPlayer"))
            {
                _collisionRed = 0;
            }
        }
    }
}
