using UnityEngine;
using System.Collections;

public class RemoveObject : MonoBehaviour
{

    private const float MIN_HEIGHT = 0.5f;
    public bool deleteObject = false;
    private const float MULTIPLICATIVE_SPEED = 1.2f;
    private const float INITIAL_SPEED = 0.1f;

    void Update()
    {
        if (deleteObject)
        {
            transform.localScale = new Vector2(transform.localScale.x, transform.localScale.y - (INITIAL_SPEED * MULTIPLICATIVE_SPEED));
            transform.Translate(new Vector2(0, -(INITIAL_SPEED / 2) * MULTIPLICATIVE_SPEED));
        }

        if (deleteObject && transform.localScale.y <= 0.5f)
            Destroy(this);
    }
}
