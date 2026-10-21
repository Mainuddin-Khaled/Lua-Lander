using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{
    private Rigidbody2D rigidBody2D;
    private void Awake()
    {
        rigidBody2D = GetComponent<Rigidbody2D>();
    }

    private void FixedUpdate()
    {
        if (Keyboard.current.upArrowKey.isPressed)
        {
            float thrustForce = 700f;
            rigidBody2D.AddForce(thrustForce * transform.up * Time.deltaTime);
        }
        if (Keyboard.current.leftArrowKey.isPressed)
        {
            float leftTurnSpeed = +100f;
            rigidBody2D.AddTorque(leftTurnSpeed * Time.deltaTime);
        }
        if (Keyboard.current.rightArrowKey.isPressed)
        {
            float rightTurnSpeed = -100f;
            rigidBody2D.AddTorque(rightTurnSpeed * Time.deltaTime);
        }
    }
}
