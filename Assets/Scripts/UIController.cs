using UnityEngine;
using UnityEngine.SceneManagement;

public class UIController : MonoBehaviour
{
    [SerializeField] private GameObject _startPanel;
    private bool _isGameStart = false;

    public bool IsGameStart => _isGameStart;

    public void StartGame()
    {
        _startPanel.SetActive(false);
        _isGameStart = true;
    }

    public void RestartLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
