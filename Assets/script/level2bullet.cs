
using UnityEngine;

public class level2bullet: MonoBehaviour
{
    public GameObject respamlife;
    public Rigidbody2D velocity;
    public GameObject effect;
   
    
    void Update()
    {
        velocity.velocity = new Vector2(0, 50f);
        Destroy(gameObject, 1f);

    }
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name == "ufo")
        {
            
            Destroy(collision.gameObject);
            Destroy(gameObject);
            FindObjectOfType<level2score>().Scoreadd();
            Instantiate(effect, collision.transform.position, collision.transform.rotation);
            
        }
        if (collision.gameObject.tag == "respamlife")
        {
            Instantiate(respamlife, collision.transform.position, collision.transform.rotation);
        }

    }
}

