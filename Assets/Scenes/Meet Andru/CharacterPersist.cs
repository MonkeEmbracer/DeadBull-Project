using UnityEngine;
using UnityEngine.SceneManagement;

public class CharacterPersist : MonoBehaviour
{
    // Variable to hold the position of the character
    private static Vector3 characterPosition;

    void Start()
    {
        // If the character is already persisted, set it to the stored position
        if (SceneManager.GetActiveScene().name != "Meet Andru")
        {
            transform.position = characterPosition;
        }
    }

    public void Persist()
    {
        // Save the character's current position before switching scenes
        characterPosition = transform.position;
        DontDestroyOnLoad(gameObject);  // This will keep the character in the new scene
    }

    public void DestroyOnSceneLoad()
    {
        // Destroy the persistent character when the scene changes
        Destroy(gameObject);
    }
}
