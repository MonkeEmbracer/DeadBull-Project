using UnityEngine;
using TMPro; // Import TextMeshPro namespace

public class DialoguePanel : MonoBehaviour
{
    public TMP_Text dialogueText;            // Reference to the TMP_Text component on the panel
    private string[] responses;              // Array to store responses
    private int currentResponseIndex = 0;    // Track which response is being displayed
    private bool dialogueActive = false;     // Track if dialogue is active

    void Start()
    {
        // Initialize the dialogue as empty
        dialogueText.text = ""; 

        // Define three random responses
        responses = new string[]
        {
            "Help me! I don't know what to do!",
            "Are you sure this is the right path?",
            "I feel like something is watching us..."
        };
    }

    // Method to start the dialogue, called when Object A reaches Object B
    public void StartDialogue()
    {
        dialogueActive = true;    // Set dialogue as active
        currentResponseIndex = 0; // Reset dialogue to first line
        ShowResponse();           // Show the first line
    }

    void Update()
    {
        // Advance dialogue only if it's active
        if (dialogueActive && Input.GetKeyDown(KeyCode.Return))
        {
            NextResponse();
        }
    }

    void ShowResponse()
    {
        dialogueText.text = responses[currentResponseIndex];
    }

    void NextResponse()
    {
        currentResponseIndex++;

        if (currentResponseIndex < responses.Length)
        {
            ShowResponse();
        }
        else
        {
            EndDialogue(); // End dialogue if we've reached the last line
        }
    }

    void EndDialogue()
    {
        dialogueText.text = "";    // Clear the text when dialogue ends
        dialogueActive = false;    // Set dialogue as inactive
    }
}
