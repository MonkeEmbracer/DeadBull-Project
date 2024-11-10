using UnityEngine;
using TMPro;
using System.Collections;

public class DialogueManagerMuseum : MonoBehaviour
{
    public TMP_Text dialogueText;              // Reference to the TMP_Text component for dialogue
    private string[] responses;                // Array to store dialogue responses
    private Color[] responseColors;            // Array to store alternating colors
    private int currentResponseIndex = 0;      // Index of the current response
    public float typingSpeed = 0.07f;          // Speed at which characters appear

    void Start()
    {
        // Define dialogue responses
        responses = new string[]
        {
            "Here's the museum, we have to hurry!", // Andru
            "I'm scared...", // Tocilescu
            "Would you rather hang around here and wait for the feral programmers to get you?", // Andru
            "Gosh darn... You're right", // Tocilescu
            "Hurry! Let's go inside and deal with them!!!" // Andru
        };
        

        // Define colors to alternate between
        responseColors = new Color[]
        {
            Color.black,    // First color
            Color.blue     // Second color      
        };

        dialogueText.text = "";  // Start with the dialogue box empty
    }

    public void StartDialogue()
    {
        currentResponseIndex = 0;
        StartCoroutine(TypeText(responses[currentResponseIndex])); // Start typing the first response
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Return) && currentResponseIndex < responses.Length)
        {
            NextResponse();
        }
    }

    IEnumerator TypeText(string message)
    {
        dialogueText.text = "";  // Clear existing text
        dialogueText.color = responseColors[currentResponseIndex % responseColors.Length]; // Set the color

        foreach (char letter in message.ToCharArray())
        {
            dialogueText.text += letter;      // Add one letter at a time
            yield return new WaitForSeconds(typingSpeed);  // Wait for typing speed duration
        }
    }

    void NextResponse()
    {
        if (currentResponseIndex < responses.Length)
        {
            StopAllCoroutines();  // Stop any ongoing typing coroutine
            StartCoroutine(TypeText(responses[currentResponseIndex])); // Start typing the next response
        }
        else
        {
            EndDialogue();
        }
        currentResponseIndex++;
    }

    void EndDialogue()
    {
        dialogueText.text = "";  // Clear the dialogue text when finished
        gameObject.SetActive(false);  // Hide the dialogue panel
    }
}
