using UnityEngine;

public class tocilescu_spre_dreapta : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public float speed = 2f;  // Speed of movement
    private Vector3 targetPosition;
    private bool moving = true;
    void Start()
    {
        float screenWidthInUnits = Camera.main.orthographicSize * Camera.main.aspect * 2;
        float distanceToMove = screenWidthInUnits / 8;
        targetPosition = transform.position + new Vector3(distanceToMove, 0, 0);

    }

    // Update is called once per frame
    void Update()
    {
        if (moving)
        {
            // Move the object towards the target position
            transform.position = Vector3.MoveTowards(transform.position, targetPosition, speed * Time.deltaTime);

            // Check if the object has reached the target position
            if (Vector3.Distance(transform.position, targetPosition) < 0.01f)
            {
                moving = false;  // Stop moving once we reach the target
            }
        }
    }
}
