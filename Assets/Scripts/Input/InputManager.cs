using UnityEngine;

public class InputManager : MonoBehaviour
{

    public delegate void OnMoveHandler(Vector2 horizontalDirection);
    public event OnMoveHandler OnMove;

    public delegate void OnStopHandler();
    public event OnStopHandler OnStop;

    public delegate void OnJumpHandler();
    public event OnStopHandler OnJump;

    private bool _canMove = true;

    private bool _canJump = true;

    public bool CanMove { get { return _canMove; } set { _canMove = value; } }

    public bool CanJump { get { return _canJump; } set { _canJump = value; } }

    private void FixedUpdate()
    {
        if (_canMove)
        {
            if (Input.GetKey(KeyCode.LeftArrow) && !Input.GetKey(KeyCode.RightArrow))
                OnMove(Vector2.left);
            else if (Input.GetKey(KeyCode.RightArrow) && !Input.GetKey(KeyCode.LeftArrow))
                OnMove(Vector2.right);
            else 
                OnStop();

            if (CanJump && Input.GetKeyDown(KeyCode.Space))
                OnJump();
        }
        else
            OnStop();
    }
}