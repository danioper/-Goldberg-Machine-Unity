using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MassDown : MonoBehaviour
{
    public Rigidbody Rigidbody;
    public float mass;
    // Start is called before the first frame update
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("ball"))
        Rigidbody.mass = mass;
    }
}
