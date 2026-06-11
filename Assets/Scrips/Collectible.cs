using UnityEngine;

public class Collectible : MonoBehaviour
{
    public int points = 10;

    private bool collected = false;

    private AudioSource audioSource;

    private void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player") && !collected)
        {
            collected = true;

            FindObjectOfType<ScoreManager>().AddPoints(points);

            FindObjectOfType<LevelManager>().CoinCollected();

            if(audioSource != null)
            {
                audioSource.Play();
            }

            GetComponent<SpriteRenderer>().enabled = false;
            GetComponent<Collider2D>().enabled = false;

            Destroy(gameObject, 0.3f);
        }
    }
}