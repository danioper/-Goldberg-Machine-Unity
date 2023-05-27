using UnityEngine;
using System.Collections;

// Applies an explosion force to all nearby rigidbodies
public class explosion : MonoBehaviour
{
    public float radius = 5.0F;
    public float power = 10.0F;
    public float Power2 = 10F;
    private ParticleSystem explosionParticle;
    void Start()
    {
        explosionParticle = GetComponentInChildren<ParticleSystem>();   
    }

    void OnTriggerEnter(Collider collision)
    {
        explosionParticle.Play();
        Vector3 explosionPos = transform.position;
        Collider[] colliders = Physics.OverlapSphere(explosionPos, radius);
        foreach (Collider hit in colliders)
        {
            Rigidbody rb = hit.GetComponent<Rigidbody>();

            if (rb != null)
                rb.AddExplosionForce(power, explosionPos, radius, 3.0F);
            if (rb != null)
                rb.AddForce(transform.up * Power2);
        }
    }
}