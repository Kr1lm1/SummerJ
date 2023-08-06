using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneManager : MonoBehaviour
{
    [SerializeField] string Scene;

    public void ChangeScene()
    {
        SceneManager.LoadScene(Scene);
    }
}
