using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private Rigidbody _rigidBody;
    public FixedJoystick Joystick;
    
    public float MoveSpeed;

    void FixedUpdate()
    {
        _rigidBody.velocity = new Vector3(Joystick.Horizontal * MoveSpeed, 0, Joystick.Vertical * MoveSpeed);

        if (Joystick.Horizontal != 0 || Joystick.Vertical != 0)
        {
            transform.rotation = Quaternion.LookRotation(_rigidBody.velocity);
        }
    }
}
