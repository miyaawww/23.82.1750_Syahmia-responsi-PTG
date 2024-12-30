using UnityEngine;

public class ArrowDestroy : MonoBehaviour
{
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Wall")) // Pastikan tembok diberi tag "Wall"
        {
            Destroy(gameObject); // Hapus panah
        }
    }
}
