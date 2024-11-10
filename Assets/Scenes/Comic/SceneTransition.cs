using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Collections;

public class SceneTransition : MonoBehaviour
{
    public Image blackoutScreen; // Reference to the blackout UI Image
    public float fadeDuration = 1.5f; // Duration for fade in and fade out
    public string sceneToLoad; // Name of the scene to load

    private void Start()
    {
        // Ensure the blackout screen starts fully transparent
        blackoutScreen.color = new Color(0, 0, 0, 0);
    }

    public void StartSceneTransition()
    {
        StartCoroutine(FadeOutAndLoadScene());
    }

    private IEnumerator FadeOutAndLoadScene()
    {
        // Fade to black
        yield return StartCoroutine(FadeToBlack());

        // Load the next scene
        SceneManager.LoadScene(sceneToLoad);

        // Fade back in from black
        yield return StartCoroutine(FadeFromBlack());
    }

    private IEnumerator FadeToBlack()
    {
        float timer = 0f;
        while (timer <= fadeDuration)
        {
            timer += Time.deltaTime;
            float alpha = Mathf.Lerp(0f, 1f, timer / fadeDuration);
            blackoutScreen.color = new Color(0, 0, 0, alpha);
            yield return null;
        }
    }

    private IEnumerator FadeFromBlack()
    {
        float timer = 0f;
        while (timer <= fadeDuration)
        {
            timer += Time.deltaTime;
            float alpha = Mathf.Lerp(1f, 0f, timer / fadeDuration);
            blackoutScreen.color = new Color(0, 0, 0, alpha);
            yield return null;
        }
    }
}
