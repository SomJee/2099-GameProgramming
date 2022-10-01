using UnityEngine;
using UnityEngine.SceneManagement;
using DG.Tweening;

public class GameManager : MonoBehaviour
{
    // Simple singleton script. This is the easiest way to create and understand a singleton script.
    
    private void Awake()
    {
        var numGameManager = FindObjectsOfType<GameManager>().Length;

        if (numGameManager > 1)
        {
            Destroy(gameObject);
        }
        else
        {
            DontDestroyOnLoad(gameObject);
        }
    }

    public void ProcessPlayerDeath()
    {
        SceneManager.LoadScene("Index");
    }

    public void NextScene(int levelIndex)
    {
        SceneManager.LoadScene(levelIndex);
        DOTween.KillAll();
    }

    public void LoadNextLevel()
    {
        var nextSceneIndex = GetCurrentBuildIndex() + 1;
        
        if (nextSceneIndex == SceneManager.sceneCountInBuildSettings)
        {
            nextSceneIndex = 0;
        }
        
        SceneManager.LoadScene(nextSceneIndex);
        DOTween.KillAll();
    }

    private int GetCurrentBuildIndex()
    {
        return SceneManager.GetActiveScene().buildIndex;
    }

    public void QuitMenu()
    {
        Debug.Log("Q");
        Application.Quit();
    }
}
