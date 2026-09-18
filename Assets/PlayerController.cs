using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 20.0f;
    public float turnSpeed = 45.0f;

    void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        transform.Translate(
            Vector3.forward * Time.deltaTime * speed * verticalInput
        );

        transform.Rotate(
            Vector3.up,
            Time.deltaTime * turnSpeed * horizontalInput
        );
    }
}