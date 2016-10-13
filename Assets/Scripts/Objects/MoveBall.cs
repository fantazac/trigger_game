using UnityEngine;
using System.Collections;

public class MoveBall : MonoBehaviour
{

    private int directionX = 1;
    private int directionY = 1;

    private void OnTriggerEnter2D(Collider2D collider)
    {
        //if(collider.gameObject.tag == "Top" || collider.gameObject.tag == "Bottom")
        //{
        //    directionY *= -1;

        //}

        //if (collider.gameObject.tag == "Right" || collider.gameObject.tag == "Left")
        //{
        //    directionX *= -1;

        //}
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(transform.position.x + (400 * directionX * Time.deltaTime), transform.position.y + (400 * directionY * Time.deltaTime), transform.position.z);

        if (transform.position.y >= 8.5f)
        {
            transform.position = new Vector3(transform.position.x, 8.5f, transform.position.z);
            directionY *= -1;
        }
        else if (transform.position.y <= -7.5f)
        {
            transform.position = new Vector3(transform.position.x, -7.5f, transform.position.z);
            directionY *= -1;
        }

        if (transform.position.x >= 15.5f)
        {
            transform.position = new Vector3(15.5f, transform.position.y, transform.position.z);
            directionX *= -1;
        }
        else if (transform.position.x <= -16f)
        {
            transform.position = new Vector3(-16, transform.position.y, transform.position.z);
            directionX *= -1;
        }
    }

}
