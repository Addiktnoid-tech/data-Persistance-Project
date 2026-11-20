using System.Collections.Generic;

[System.Serializable]
public class ScoreEntry
{
    public string Username;
    public int Score;
}


[System.Serializable]
public class Playerdata
{
    public string Username;

    public int HighScore;

    public string HighScoreUsername;

    public List<ScoreEntry> HighScores = new List<ScoreEntry>();

}
