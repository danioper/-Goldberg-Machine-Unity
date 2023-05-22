using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MassDown : MonoBehaviour
{
    public Rigidbody Rigidbody;
    // Start is called before the first frame update
    private void OnTriggerEnter(Collider other)
    {
        Rigidbody.mass = 0.1f;
    }
}
