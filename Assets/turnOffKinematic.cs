using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class turnOffKinematic : MonoBehaviour
{
    public Rigidbody rigidbody;
    public Rigidbody kinematic2;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("ball"))
            if (rigidbody.isKinematic == true)
            {
                kinematic2.isKinematic = false;
                StartCoroutine(WaitAndPrint());
            }
            else
                rigidbody.isKinematic = true;
    }
    private IEnumerator WaitAndPrint()
    {
        yield return new WaitForSeconds(0.7f);
        rigidbody.isKinematic = false;
    }
}
