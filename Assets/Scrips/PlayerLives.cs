using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class PlayerLives : MonoBehaviour
{
    public int lives = 3;

    public TextMeshProUGUI livesText;

    private int extraLifeThreshold = 100;

    private void Start()
    {
        UpdateLivesUI();
    }

    public void TakeDamage()
    {
        lives--;

        UpdateLivesUI();

        Debug.Log("Vidas restantes: " + lives);

        if (lives <= 0)
        {
            SceneManager.LoadScene("GameOver");
        }
    }

    private void Update()
    {
        if (ScoreManager.score >= extraLifeThreshold)
        {
            lives++;

            extraLifeThreshold += 100;

            UpdateLivesUI();

            Debug.Log("Vida extra ganada. Vidas: " + lives);
        }
    }

    void UpdateLivesUI()
    {
        livesText.text = "Vidas: " + lives;
    }
}