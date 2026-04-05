using UnityEngine;

public class ExitDoor : MonoBehaviour
{
    private SpriteRenderer spriteRenderer;
    private bool isUnlocked = false;

    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        spriteRenderer.color = Color.red;
    }

    void Update()
    {
        if (!isUnlocked && GameManager.Instance != null && GameManager.Instance.AreAllSpheresCollected())
        {
            isUnlocked = true;
            spriteRenderer.color = Color.green;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player") && isUnlocked)
        {
            Debug.Log("Рівень пройдено!");
        }
    }
}