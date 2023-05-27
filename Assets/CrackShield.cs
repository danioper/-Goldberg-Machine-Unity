using System.Collections;
using UnityEngine;

public class CrackShield : MonoBehaviour
{
    private Material shieldMat;
    [SerializeField] private GameObject glassBrake;
    public Rigidbody obiektDoWy³¹czenia;
    public Animator obiektAnimacji;
    public Rigidbody[] KinematicObjects;
    void Start()
    {
        shieldMat = GetComponent<MeshRenderer>().sharedMaterial;
    }
    
    private void OnCollisionEnter(Collision collision)
    {
        if (!collision.transform.CompareTag("ball"))
            return;

        if (collision.relativeVelocity.magnitude < 7f)
            return;
        
        StartCoroutine(Crack());
    }

    IEnumerator Crack()
    {
        for (int i = 5; i > 0; i--)
        {
            shieldMat.SetFloat("_CrackAmount", i);
            yield return new WaitForSeconds(0.15f);
        }
        obiektAnimacji.SetTrigger("ButtonTrigger");
        obiektDoWy³¹czenia.isKinematic = false;
        glassBrake.SetActive(true);
        gameObject.GetComponent<MeshRenderer>().enabled = false;
        yield return new WaitForSeconds(2.5f);
        foreach (var item in KinematicObjects)
        {
            item.isKinematic = false;
        }
        Destroy(gameObject);
        shieldMat.SetFloat("_CrackAmount", 10);
    }
}
