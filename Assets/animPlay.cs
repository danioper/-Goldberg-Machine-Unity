using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class animPlay : MonoBehaviour
{
    public Animator animator;
    public AudioSource audioSource;
    private void Start()
    {
        audioSource =  gameObject.GetComponent<AudioSource>();
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("ball"))
        {
            animator.SetTrigger("GoGreenTrigger");
            audioSource.Play();
        }
    }
}
