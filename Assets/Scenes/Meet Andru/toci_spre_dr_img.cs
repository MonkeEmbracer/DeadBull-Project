using UnityEngine;
using UnityEngine.UI;

public class TocilescuSpreDreaptaUI : MonoBehaviour
{
    public float speed = 200f;  // Speed of movement in UI units (pixels per second)
    private RectTransform rectTransform;
    private Vector2 targetPosition;
    private bool moving = true;

    void Start()
    {
        rectTransform = GetComponent<RectTransform>();
        
        if (rectTransform == null)
        {
            Debug.LogError("This script requires a RectTransform component.");
            return;
        }

        float screenWidthInUnits = Screen.width;
        float distanceToMove = screenWidthInUnits / 8;
        targetPosition = rectTransform.anchoredPosition + new Vector2(distanceToMove, 0);  // Use Vector2 for UI positioning
    }

    void Update()
    {
        if (moving)
        {
            // Move the UI element towards the target position
            rectTransform.anchoredPosition = Vector2.MoveTowards(rectTransform.anchoredPosition, targetPosition, speed * Time.deltaTime);

            // Check if the object has reached the target position
            if (Vector2.Distance(rectTransform.anchoredPosition, targetPosition) < 0.01f)
            {
                moving = false;  // Stop moving once we reach the target
            }
        }
    }
}
