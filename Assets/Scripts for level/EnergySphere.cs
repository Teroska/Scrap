using UnityEngine;

public class EnergySphere : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            GameManager.Instance.AddSphere();
            Destroy(gameObject);
        }
    }
}