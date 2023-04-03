using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManagerController : MonoBehaviour
{
    public GameObject player;
    public GameObject spawner;
    public GameObject gameOverScreen;
    public int score = 0;
    public void Start()
    {
        Time.timeScale = 1f;
        score = 0;
        gameOverScreen.SetActive(false);
    }

    public void AddScore()
    {
        score++;
    }

    public void GameOver()
    {
        Time.timeScale = 0f;
        gameOverScreen.SetActive(true);
    }

    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    void Update()
    {
        if (player == null)
        {
            GameOver();
        }
    }
}