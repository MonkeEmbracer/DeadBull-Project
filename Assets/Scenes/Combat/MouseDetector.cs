using UnityEngine;

public class MouseDetector : MonoBehaviour
{
    public CharacterCombat player;
    public GameObject attackButton;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //spriteRenderer = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            //attackButton.onClick.AddListener(OnButtonPressed);
            /*Vector2 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);

            Collider2D hitCollider = Physics2D.OverlapPoint(mousePosition);

            if (hitCollider != null && hitCollider.gameObject == gameObject)
            {
                OnMouseHit();
            }*/
        }
    }

    void OnMouseHit()
    {
        //player.TakeDamage(14);
        //player.Attack();
    }
}
