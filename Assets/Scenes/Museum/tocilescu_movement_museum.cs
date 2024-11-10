using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using Unity.VisualScripting;

public class tocilescu_movement_museum : MonoBehaviour
{
    public Sprite front1, front2, front3;
    public Sprite back1, back2, back3;
    public Sprite right1, right2, right3;
    public Sprite left1, left2, left3;
    public float speed = 200f;
    public float animationInterval = 0.2f;
    public string sceneToLoad = "Museum"; // Scene index to load when touching a border

    private Image imageComponent;
    private RectTransform rectTransform;
    private float animationTimer;
    private int spriteIndex = 0;
    private bool canMove = false;
    private Vector2 movement;

    void Start()
    {
        imageComponent = GetComponent<Image>();
        rectTransform = GetComponent<RectTransform>();
        animationTimer = 0f;
        GameObject.DontDestroyOnLoad(this.gameObject);

    }

    void Update()
    {
        
            Vector2 movement = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical")).normalized;
            Vector2 newPosition = rectTransform.anchoredPosition + movement * speed * Time.deltaTime;

            // Update position and animate sprite if within bounds
            rectTransform.anchoredPosition = newPosition;
            if (movement != Vector2.zero) AnimateSprite(movement);

            // Check if object is out of bounds
            
        
    }

  

    void AnimateSprite(Vector2 movement)
    {
        animationTimer += Time.deltaTime;

        if (animationTimer >= animationInterval)
        {
            animationTimer = 0f;
            spriteIndex = (spriteIndex + 1) % 3;

            if (movement.y > 0)
                imageComponent.sprite = GetSprite(back1, back2, back3);
            else if (movement.y < 0)
                imageComponent.sprite = GetSprite(front1, front2, front3);
            else if (movement.x > 0)
                imageComponent.sprite = GetSprite(right1, right2, right3);
            else if (movement.x < 0)
                imageComponent.sprite = GetSprite(left1, left2, left3);
        }
    }

    Sprite GetSprite(Sprite sprite1, Sprite sprite2, Sprite sprite3)
    {
        switch (spriteIndex)
        {
            case 0: return sprite1;
            case 1: return sprite3;
            case 2: return sprite2;
            default: return sprite1;
        }
    }

    public string requested_scene = "Combat";
    private void OnTriggerEnter2D(Collider2D collision){
       
        SceneManager.LoadScene(requested_scene);
    }
}
