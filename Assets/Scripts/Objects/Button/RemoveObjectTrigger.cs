using UnityEngine;
using System.Collections;

public class RemoveObjectTrigger : MonoBehaviour
{

    [SerializeField]
    private GameObject _object;

    private void OnTriggerEnter2D()
    {
        if (_object != null)
        {
            _object.GetComponent<RemoveObject>().deleteObject = true;
            _object = null;
        }
    }
}
