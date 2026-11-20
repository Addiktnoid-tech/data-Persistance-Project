using UnityEngine;
using UnityEngine.UI;

public class UsernameDisplay : MonoBehaviour
{
    private Text usernameText;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    private void Awake()
    {
        usernameText = GetComponent<Text>();
    }

    // Update is called once per frame
    private void Start()
    {
        if(PlayerSession.Instance != null)
        {
            Debug.Log("Username recuperado na Main: " +
                  PlayerSession.Instance.Username);
            usernameText.text = "Player: " + PlayerSession.Instance.Username;
        }
    }
}
