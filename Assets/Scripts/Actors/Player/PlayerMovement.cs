using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour
{

    private InputManager _inputManager;
    private Rigidbody2D _rigidbody;

    private float _speed = 7;

    public float Speed { get { return _speed; } }

    void Start()
    {
        _rigidbody = GetComponent<Rigidbody2D>();
        _inputManager = GetComponent<InputManager>();
        _inputManager.OnMove += OnMove;
        _inputManager.OnStop += OnStop;
    }

    void Update()
    {

    }

    private void OnMove(Vector2 horizontalDirection)
    {
        _rigidbody.velocity = new Vector2(horizontalDirection.x * _speed, _rigidbody.velocity.y);
    }

    private void OnStop()
    {
        if (_rigidbody.velocity.x < 1 && _rigidbody.velocity.x > -1)
            _rigidbody.velocity = new Vector2(0, _rigidbody.velocity.y);
        else
        {
            _rigidbody.velocity = new Vector2(_rigidbody.velocity.x * 0.94f, _rigidbody.velocity.y);
            if (_rigidbody.velocity.x > 1)
                _rigidbody.AddForce(new Vector2(-30f, 0));
            else if(_rigidbody.velocity.x < -1)
                _rigidbody.AddForce(new Vector2(30f, 0));
        }
    }
}
