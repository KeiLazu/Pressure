using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 6f;
    Vector3 movement;
    Rigidbody playerRigidbody;
    Quaternion playerQuaternion;

    // Use this for initialization
    private void Start()
    {
        playerRigidbody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    private void FixedUpdate()
    {
        var h = Input.GetAxisRaw("Horizontal");
        var v = Input.GetAxisRaw("Vertical");

        Move(v);
        Turn(h);

    }

    void Move(float v)
    {
        Vector3 movement = transform.forward * v * (speed/2) * Time.deltaTime;
        
        playerRigidbody.MovePosition(playerRigidbody.position + movement);
    }

    void Turn(float h)
    {
        float turn = h * (speed*2) * Time.deltaTime;
        
        Quaternion turnRotation = Quaternion.Euler(0f, turn, 0f);
        
        playerRigidbody.MoveRotation(playerRigidbody.rotation * turnRotation);

    }

}