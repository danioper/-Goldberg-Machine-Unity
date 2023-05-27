using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewtonDrop : MonoBehaviour
{
    public FixedJoint[] tablicaJoint;
    // Start is called before the first frame update
    private void OnTriggerEnter(Collider other)
    {
        StartCoroutine(wykonaj());
    }

    IEnumerator wykonaj()
    {
        foreach (var item in tablicaJoint)
        {
            item.breakForce = 0;
            yield return new WaitForSeconds(0.2F);
        }
    }
}
