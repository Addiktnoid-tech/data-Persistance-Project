using UnityEngine;
public class PlayerSession : MonoBehaviour
{
    public static PlayerSession Instance;

    public string Username { get; private set; }

    private Playerdata playerData;

    private void Awake()
    {
        Debug.Log("PlayerSession Awake executado!");
        if (Instance != null)
        {
            Destroy(gameObject);
            return;
        }

        Instance = this;
        DontDestroyOnLoad(gameObject);
        Debug.Log("PlayerSession Instance inicializado!");

        // Load saved player data
        playerData  = SaveSystem.LoadPlayer();
        Username = playerData.Username;
    }

    public void SetUserName(string username)
    {
        Username = username;

        playerData.Username = Username;

        SaveSystem.SavePlayer(playerData);
    }

    public Playerdata GetPlayerData()
    {
        return playerData;
    }
}