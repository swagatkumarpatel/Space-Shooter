
using UnityEngine;

public class enemymovement : MonoBehaviour
{
    public float speed;
   
    void Update()
    {
        transform.Translate(0, speed*Time.deltaTime, 0);
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag=="bullet")
        {
            FindObjectOfType<audio>().call();
        }
    }
}
