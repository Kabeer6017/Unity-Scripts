using UnityEngine;


public class JoystickMovement : MonoBehaviour
{         
    public FixedJoystick Joystick;
    public float MoveSpeed = 5;

    private float hInput, vInput;

   
    void Start()
    {
        
    }

 
    void Update()
    {
        
    }
    private void FixedUpdate()
    {
        hInput = Joystick.Horizontal * MoveSpeed;
        vInput = Joystick.Vertical * MoveSpeed;

        transform.Translate(hInput, vInput, 0);
    }
}
