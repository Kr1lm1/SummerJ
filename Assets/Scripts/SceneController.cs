using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneController : MonoBehaviour
{
    [SerializeField] string Scene;

    public void ChangeScene()
    {
        SceneManager.LoadScene(Scene);
        Time.timeScale = 1.0f;
    }
}
