
using UnityEngine;

public class destroyeffect : MonoBehaviour
{
    void Update()
    {
        transform.localScale = new Vector2(transform.localScale.x + 0.09f, transform.localScale.y + 0.09f);
        Destroy(gameObject, 0.3f);
    }
}
