
using UnityEngine;
using UnityEngine.SceneManagement;
public class Playermovement : MonoBehaviour
{
    public GameObject lazer;
    public Transform lazerposition;
    public GameObject life1, life2, life3;
    int life=3;
    public Transform respamposition;
    public AudioSource fire;
    void Update()
    {
        if(life>3)
        {
            life = 3;
        }
        float x = Input.GetAxis("Horizontal") *50f * Time.deltaTime;
        float y = Input.GetAxis("Vertical") * 50f * Time.deltaTime;
        transform.Translate(x, y, 0);
        
        if(Input.GetMouseButtonDown(0) || Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(lazer, lazerposition.position,Quaternion.identity);
            fire.Play();
        }

        if (life == 3)
        {

            life1.gameObject.SetActive(true);
            life2.gameObject.SetActive(true);
            life3.gameObject.SetActive(true);
        }
        if (life == 2)
        {
            life1.gameObject.SetActive(false);
            life2.gameObject.SetActive(true);
            life3.gameObject.SetActive(true);
        }
        if (life == 1)
        {
            life1.gameObject.SetActive(false);
            life2.gameObject.SetActive(false);
            life3.gameObject.SetActive(true);
        }

        if (life == 0)
        { 
            SceneManager.LoadScene("gameover");
        }
      
    }
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name == "ufo")
        {
            life = life - 1;
            transform.position = respamposition.position;
        }
    }
    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "life")
        {
            life = life + 1;
            Destroy(collision.gameObject);
        }

    }

}

