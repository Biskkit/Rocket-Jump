using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneReloader : MonoBehaviour
{
    public void reloadScene()
    {
        SceneManager.LoadScene(0);
    }
}
