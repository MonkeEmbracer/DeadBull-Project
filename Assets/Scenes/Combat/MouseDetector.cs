using UnityEngine;

public class MouseDetector : MonoBehaviour
{
    public CharacterCombat player;

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
            Vector2 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);

            Collider2D hitCollider = Physics2D.OverlapPoint(mousePosition);

            if (hitCollider != null && hitCollider.gameObject == gameObject)
            {
                OnMouseHit();
            }
        }
    }

    private void OnMouseHit()
    {
        //player.TakeDamage(14);
        player.Attack();
    }
}
