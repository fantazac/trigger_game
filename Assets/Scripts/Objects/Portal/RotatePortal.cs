using UnityEngine;
using System.Collections;

public class RotatePortal : MonoBehaviour
{

    private void Update()
    {
        transform.Rotate(Vector3.back);
    }
}
