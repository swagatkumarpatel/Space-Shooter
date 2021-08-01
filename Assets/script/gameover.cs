
using UnityEngine;
using UnityEngine.SceneManagement;

public class gameover : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name == "ufo")
        {
            SceneManager.LoadScene("gameover");
        }
    }
   
}
