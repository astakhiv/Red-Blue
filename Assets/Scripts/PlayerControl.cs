using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    [SerializeField] private float _speedX;
    [SerializeField] private float _speedZ;
    [SerializeField] private float _normalSpeed;

    private Rigidbody _rb;

    public void OnUpButtonDown()
    {
        if (_speedZ <= 0f)
        {
            _speedZ = _normalSpeed;
        }
    }

    public void OnDownButtonDown()
    {
        if (_speedZ >= 0f)
        {
            _speedZ = -_normalSpeed;
        }
    }

    public void OnLeftButtonDown()
    {
        if (_speedX >= 0f)
        {
            _speedX = -_normalSpeed;
        }
    }

    public void OnRightButtonDown()
    {
        if (_speedX <= 0f)
        {
            _speedX = _normalSpeed;
        }
    }

    public void OnButtonUp()
    {
        _speedX = 0f;
        _speedZ = 0f;
    }

    private void Start()
    {
        _rb = GetComponent<Rigidbody>();
    }

    private void FixedUpdate()
    {
        _move();
    }

    private void _move()
    {
        _rb.velocity = new Vector3(_speedX, _rb.velocity.y, _speedZ);
    }
}
