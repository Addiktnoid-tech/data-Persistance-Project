using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
    [SerializeField] private InputField usernameInputField;
    public void StartGame()
    {
        string username = usernameInputField.text.Trim();
        Debug.Log("Username digitado: " + username);

        if (string.IsNullOrEmpty(username))
        {
            Debug.Log("Please enter a username!");
            return;
        }

        PlayerSession.Instance.SetUserName(username);
        Debug.Log("Username na sessão: " + PlayerSession.Instance.Username);

        SceneManager.LoadScene("main");
    }

    public void OpenHighScore()
    {
        SceneManager.LoadScene("HighScore");
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
