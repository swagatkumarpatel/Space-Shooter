
using UnityEngine;

public class rotate : MonoBehaviour
{
 
    void Update()
    {
        transform.Rotate(0,10, 0);
        Destroy(gameObject, 5f);
    }
}
