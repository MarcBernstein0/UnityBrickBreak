using UnityEngine;
using UnityEngine.SceneManagement;

public class StartMenu : MonoBehaviour
{
    public void NextScene()
    {
        SceneManager.LoadScene("GameScene");
    }
}