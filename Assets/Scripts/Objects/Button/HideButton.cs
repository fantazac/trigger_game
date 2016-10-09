using UnityEngine;
using System.Collections;

public class HideButton : MonoBehaviour
{

    private void OnTriggerEnter2D()
    {
        GetComponentInChildren<SpriteRenderer>().enabled = false;
    }

    private void OnTriggerExit2D()
    {
        GetComponentInChildren<SpriteRenderer>().enabled = true;
    }
}
