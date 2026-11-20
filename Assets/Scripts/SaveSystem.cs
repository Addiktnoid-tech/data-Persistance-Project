using System.IO; 
using UnityEngine;
using System.Collections.Generic;

public class SaveSystem : MonoBehaviour
{
    private static string SavePath =>  Path.Combine(Application.persistentDataPath, "playerData.json");
    
    public static void SavePlayer(Playerdata data)
    {
        string json = JsonUtility.ToJson(data, true);

        File.WriteAllText(SavePath, json);

        Debug.Log("Player data saved!");
    }


    public static Playerdata LoadPlayer()
    {
        if (File.Exists(SavePath))
        {
            string json = File.ReadAllText(SavePath);

            Playerdata data = JsonUtility.FromJson<Playerdata>(json);

            if (data.HighScores == null)
            {
                data.HighScores = new List<ScoreEntry>();
            }

            if (data.HighScore > 0 &&
                !data.HighScores.Exists(entry =>
                    entry.Score == data.HighScore &&
                    entry.Username == data.HighScoreUsername))
            {
                AddHighScore(
                    data,
                    data.HighScoreUsername,
                    data.HighScore
                );
            }

            return data;
        }

        Debug.Log("No save file found.");

        return new Playerdata();
    }


    public static void AddHighScore(Playerdata data, string username, int score)
    {
        ScoreEntry newEntry = new ScoreEntry();

        newEntry.Username = username;
        newEntry.Score = score;

        data.HighScores.Add(newEntry);

        data.HighScores.Sort((a, b) => b.Score.CompareTo(a.Score));

        if (data.HighScores.Count > 5)
        {
            data.HighScores.RemoveAt(data.HighScores.Count - 1);
        }

        SavePlayer(data);
    }

}


