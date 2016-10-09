using UnityEngine;

public class InputManager : MonoBehaviour
{

    public delegate void OnMoveHandler(Vector2 horizontalDirection);
    public event OnMoveHandler OnMove;

    public delegate void OnStopHandler();
    public event OnStopHandler OnStop;

    private bool _canMove = true;

    public bool CanMove { get { return _canMove; } set { _canMove = value; } }

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
        }
        else
            OnStop();
    }
}