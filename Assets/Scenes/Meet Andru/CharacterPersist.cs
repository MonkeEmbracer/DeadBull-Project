using UnityEngine;
using UnityEngine.SceneManagement;

public class CharacterPersist : MonoBehaviour
{
    private static bool shouldPersist = false;
    public string nextSceneName;  // Scene to load upon collision

    void Awake()
    {
        // Ensure only this object persists upon transitioning
        if (shouldPersist)
        {
            DontDestroyOnLoad(gameObject);
            shouldPersist = false; // Reset the flag after the transition
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        // Start persistence and load the next scene upon collision
        shouldPersist = true;
        SceneManager.LoadScene(nextSceneName);
    }
}
