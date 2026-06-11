using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour
{
    public int totalCoins;
    private int collectedCoins;

    public void CoinCollected()
    {
        collectedCoins++;

        if (collectedCoins >= totalCoins)
        {
            NextLevel();
        }
    }

    void NextLevel()
    {
        int currentScene = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(currentScene + 1);
    }
}