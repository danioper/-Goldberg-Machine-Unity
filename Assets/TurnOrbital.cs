using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurnOrbital : MonoBehaviour
{
    public GameObject dowlaczenia;
    public GameObject dowylaczenia;
    private void OnTriggerEnter(Collider other)
    {
        dowlaczenia.SetActive(true);
        dowylaczenia.SetActive(false);
    }
}
