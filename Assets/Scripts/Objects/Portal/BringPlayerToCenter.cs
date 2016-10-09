using UnityEngine;
using System.Collections;

public class BringPlayerToCenter : MonoBehaviour {

	private void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.tag == "Player")
        {
            collider.GetComponent<InputManager>().CanMove = false;
            //GetComponent<BoxCollider2D>().enabled = false;
            collider.GetComponent<Rigidbody2D>().freezeRotation = false;

        }   
    }
}
