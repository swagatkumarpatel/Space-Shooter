
using UnityEngine;
using UnityEngine.SceneManagement;

public class scene:MonoBehaviour
{
    public void menuscene()
    {
        SceneManager.LoadScene("menu");
    }
    public void restartscene()
    {
        SceneManager.LoadScene("spaceshoot");
    }
}

