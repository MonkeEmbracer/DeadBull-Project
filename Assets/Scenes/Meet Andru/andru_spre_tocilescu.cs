using UnityEngine;

public class andru_spre_tocilescu : MonoBehaviour
{
    public Transform target;      // The Transform of Object A (target)
    public float speed = 800f;      // The speed at which Object B moves
    public float stoppingDistance = 1f;  // The minimum distance to stop at

    void Update()
    {
        // Calculate the distance between Object B (this) and Object A (target)
        float distance = Vector3.Distance(transform.position, target.position);

        // Check if Object B is farther than the stopping distance
        if (distance > stoppingDistance)
        {
            // Move towards Object A
            Vector3 direction = (target.position - transform.position).normalized;
            transform.position += direction * speed * Time.deltaTime;
        }
    }
}
