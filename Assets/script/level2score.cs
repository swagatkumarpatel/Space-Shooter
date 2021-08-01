
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class level2score : MonoBehaviour
{
    public Text killed;
    float killednumber=0;
    public Text alive;
    float alivenumber=40;

    
    void Update()
    {
        if(killednumber==40)
        {
            SceneManager.LoadScene("youwon");
        }
    }
    public void Scoreadd()

    {
        killednumber = killednumber + 1;
        killed.text = killednumber.ToString();
        alivenumber = alivenumber - 1;
        alive.text = alivenumber.ToString();
    }
                
}

