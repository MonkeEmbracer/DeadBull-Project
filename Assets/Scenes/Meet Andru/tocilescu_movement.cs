using UnityEngine;
using UnityEngine.UI;

public class tocilescu_movement : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public Sprite front1, front2, front3;
    public Sprite back1, back2, back3;
    public Sprite right1, right2, right3;
    public Sprite left1, left2, left3;
    public float speed = 200f;        // Movement speed
    public float animationInterval = 0.2f; // Time between sprite changes

    private Image imageComponent;    // Reference to the Image component
    private RectTransform rectTransform;    
    private float animationTimer;     // Timer for animation
    private int spriteIndex = 0;             // Index to track which sprite to show in each cycle
    private bool canMove = false;  // Toggle between sprites
    private Vector2 movement;         // Movement direction
    public float topBoundaryY = 20f;
    void Start()
    {
        imageComponent = GetComponent<Image>();
        rectTransform = GetComponent<RectTransform>();
        animationTimer = 0f;
    }

    // Update is called once per frame
    void Update()
    {
        // Only allow movement if canMove is true
        if (canMove)
        {
            Vector2 movement = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical")).normalized;
            Vector2 newPosition = rectTransform.anchoredPosition + movement * speed * Time.deltaTime;

            //print(newPosition);
            if (newPosition.y <= topBoundaryY)
            {
                rectTransform.anchoredPosition = newPosition; // Apply the movement only if within bounds
            }

            if (movement != Vector2.zero)
            {
                AnimateSprite(movement);
            }
        }
    }
    void AnimateSprite(Vector2 movement)
    {
        // Update the animation timer
        animationTimer += Time.deltaTime;

        // Check if it's time to switch to the next sprite in the cycle
        if (animationTimer >= animationInterval)
        {
            animationTimer = 0f;       // Reset the timer
            spriteIndex = (spriteIndex + 1) % 3;  // Cycle through 0, 1, 2

            // Select the appropriate sprite based on the movement direction and sprite index
            if (movement.y > 0) // Moving Up
            {
                imageComponent.sprite = GetSprite(back1, back2, back3);
            }
            else if (movement.y < 0) // Moving Down
            {
                imageComponent.sprite = GetSprite(front1, front2, front3);
            }
            else if (movement.x > 0) // Moving Right
            {
                imageComponent.sprite = GetSprite(right1, right2, right3);
            }
            else if (movement.x < 0) // Moving Left
            {
                imageComponent.sprite = GetSprite(left1, left2, left3);
            }
        }
    }

    // Helper function to return the correct sprite based on the current sprite index
    Sprite GetSprite(Sprite sprite1, Sprite sprite2, Sprite sprite3)
    {
        switch (spriteIndex)
        {
            case 0: return sprite1;
            case 1: return sprite3;
            case 2: return sprite2;
            default: return sprite1; // Default to first sprite in case of error
        }
    }

    // Method to enable movement from another script
    public void EnableMovement()
    {
        canMove = true;
    }
}
