using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurnOn : MonoBehaviour
{
    public GameObject gameobject;
    public GameObject gameobject2;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("ball"))
        {
            gameobject.SetActive(true);
            StartCoroutine(WaitAndPrint());
        }
    }
    private IEnumerator WaitAndPrint()
    {
        yield return new WaitForSeconds(1);
        gameobject2.SetActive(false);
    }
}
