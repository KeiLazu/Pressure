using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 6f;
    private Vector3 movement;
    private Rigidbody playerRigidbody;
    private GameObject playerHead;
    private Quaternion playerQuaternion;

    // Use this for initialization
    private void Start()
    {
        playerRigidbody = GetComponent<Rigidbody>();
        playerHead = gameObject.transform.GetChild(1).gameObject;
    }

    // Update is called once per frame
    private void FixedUpdate()
    {
        var h = Input.GetAxisRaw("Horizontal");
        var v = Input.GetAxisRaw("Vertical");
        var head = Input.GetAxisRaw("arrow");

        Move(v);
        Turn(v, h);
        headTurn(head);
    }

    private void Move(float v)
    {
        Vector3 movement = transform.forward * v * (speed / 2) * Time.deltaTime;

        playerRigidbody.MovePosition(playerRigidbody.position + movement);
    }

    private void Turn(float v, float h)
    {
        float turn = h * (speed * 2) * Time.deltaTime;

        Quaternion turnRotation;

        if (v < 0)
        {
            turnRotation = Quaternion.Euler(0f, -turn, 0f);
        }
        else
        {
            turnRotation = Quaternion.Euler(0f, turn, 0f);
        }

        playerRigidbody.MoveRotation(playerRigidbody.rotation * turnRotation);
    }

    private void headTurn(float head)
    {
        float turn = head * (speed * 2) * Time.deltaTime;

        Quaternion turnRotation = Quaternion.Euler(0f, turn, 0f);

        playerHead.transform.Rotate(0f, turn, 0f);
    }
}