using UnityEngine;

public class andru_spre_tocilescu : MonoBehaviour
{
    public Transform target;                // The Transform of Object A (target)
    public float speed = 800f;              // The speed at which Object B moves
    public float stoppingDistance = 1f;     // The minimum distance to stop at
    public GameObject dialoguePanel;        // The dialogue panel GameObject
    private bool dialogueShown = false;     // Flag to prevent dialogue from showing multiple times

    private DialogueManager dialogueManager; // Reference to DialogueManager script

    void Start()
    {
        // Get the DialogueManager component from the dialogue panel
        if (dialoguePanel != null)
        {
            dialogueManager = dialoguePanel.GetComponent<DialogueManager>();
            dialoguePanel.SetActive(true); // Keep the panel active but initially empty
            dialogueManager.dialogueText.text = ""; // Make sure the text is empty at start
        }
    }

    void Update()
    {
        float distance = Vector3.Distance(transform.position, target.position);

        if (distance > stoppingDistance)
        {
            Vector3 direction = (target.position - transform.position).normalized;
            transform.position += direction * speed * Time.deltaTime;
        }
        else if (!dialogueShown && dialogueManager != null)  // Start dialogue once after reaching target
        {
            ShowDialogue();
        }
    }

    void ShowDialogue()
    {
        dialogueManager.StartDialogue(); // Start the dialogue sequence with the first line
        dialogueShown = true;            // Prevent dialogue from starting again
    }
}
