using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float movSpeed;
    float speedX, speedY;
    Rigidbody2D rb;
    float height, width;

    Camera mainCamera;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        mainCamera = Camera.main;
        height = mainCamera.orthographicSize * 2;
        width = height * mainCamera.aspect;
    }

    void Update()
    {
        speedX = Input.GetAxisRaw("Horizontal") * movSpeed;
        speedY = Input.GetAxisRaw("Vertical") * movSpeed;
        rb.linearVelocity = new Vector2(speedX, speedY);
        
        transform.position = new Vector3(Mathf.Clamp(transform.position.x, -width / 2 + transform.localScale.x / 2,
         width / 2 - transform.localScale.x / 2),
         Mathf.Clamp(transform.position.y, -height / 2 + transform.localScale.y / 2, height / 2 - transform.localScale.y / 2),
         transform.position.z);
    }
}