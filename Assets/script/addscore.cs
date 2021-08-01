
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class addscore : MonoBehaviour
{
    public Text killed;
    float killednumber=0;
    public Text alive;
    float alivenumber=20;

    
    void Update()
    {
        if(killednumber==20)
        {
            SceneManager.LoadScene("nextlevelscene");
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

