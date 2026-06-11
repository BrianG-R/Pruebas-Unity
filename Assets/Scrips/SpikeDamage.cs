using UnityEngine;

public class SpikeDamage : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            Debug.Log("Murió por pinchos");

            PlayerLives lives =
                other.GetComponent<PlayerLives>();

            if (lives != null)
            {
                lives.TakeDamage();
            }

            HeroKnight hero =
                other.GetComponent<HeroKnight>();

            if (hero != null)
            {
                hero.Die();
            }
        }
    }
}