using UnityEngine;
using UnityEngine.InputSystem;

public class characterController : MonoBehaviour
{
    [SerializeField] private bool isPlayerOne = true;
    [SerializeField] private Rigidbody2D rigidBody;
    [SerializeField] private float paddleMoveSpeed = 20;
    public InputActionReference moveInputAction;
    private float _moveDirection = 0;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        _moveDirection = moveInputAction.action.ReadValue<float>();
    }

    private void FixedUpdate()
    {
        rigidBody.linearVelocityY = paddleMoveSpeed * _moveDirection;
        /*if (transform.position.y > 5.5f)
        {
            transform.position = new Vector2(transform.position.x,5.5f);
            rigidBody.linearVelocityY = 0;
        } 
        else if (transform.position.y < -5.5f)
        {
            transform.position = new Vector2(transform.position.x, -5.5f);
            rigidBody.linearVelocityY = 0;
        }*/

    }
}
