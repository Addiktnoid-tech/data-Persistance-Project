
using UnityEngine;
using UnityEngine.UI;
using System.Text;

public class HighScoreManager : MonoBehaviour
{
    [SerializeField] private Text highScoreText;

    private void Start()
    {
        Playerdata playerData = SaveSystem.LoadPlayer();

        StringBuilder scoreBoard = new StringBuilder();


        for (int i = 0; i < playerData.HighScores.Count; i++)
        {
            ScoreEntry entry = playerData.HighScores[i];

            scoreBoard.AppendLine(
                (i + 1) + ". " +
                entry.Username + " - " +
                entry.Score
            );
        }

        if (playerData.HighScores.Count == 0)
        {
            scoreBoard.AppendLine("No scores yet!");
        }

        highScoreText.text = scoreBoard.ToString();
    }

    public void BackToMenu()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("Menu");
    }
}
