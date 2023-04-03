using UnityEngine;
using UnityEngine.UI;

public class ScoreController : MonoBehaviour
{
    public GameManagerController gameManager;
    public Text scoreText;

    void Update()
    {
        scoreText.text = "Score: " + gameManager.score;
    }
}
    