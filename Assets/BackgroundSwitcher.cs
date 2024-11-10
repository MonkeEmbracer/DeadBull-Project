using UnityEngine;
using UnityEngine.UI; // Required for UI Image

public class BackgroundSwitcher : MonoBehaviour
{
    public Sprite[] backgroundSprites;    // Array of sprites to cycle through
    public Image uiImage;                 // For UI image background
   // For non-UI background (2D game)

    private int currentIndex = 0;         // Track the current background index

    void Start()
    {
        // Initialize with the first background
        ShowBackground(currentIndex);
    }

    void Update()
    {
        // Check for Enter key press
        if (Input.GetKeyDown(KeyCode.Return))
        {
            NextBackground();
        }
    }

    // Move to the next background image
    void NextBackground()
    {
        currentIndex = (currentIndex + 1) % backgroundSprites.Length; // Cycle index
        ShowBackground(currentIndex);
    }

    // Show the background based on the index
    void ShowBackground(int index)
    {
        if (uiImage != null)
        {
            uiImage.sprite = backgroundSprites[index];
        }
       
        else
        {
            Debug.LogError("No UI Image or SpriteRenderer assigned for background display.");
        }
    }
}
