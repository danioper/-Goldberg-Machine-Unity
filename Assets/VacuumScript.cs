using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VacuumScript : MonoBehaviour
{
    public GameObject piłkaJeden;
    public GameObject odkurzacz;
    public Animator odkurzaczAnim;
    public GameObject wiatrak;
    // Start is called before the first frame update
    void Start()
    {
        //odkurzaczAnim = gameObject.GetComponent<Animator>();   
    }
    private void OnTriggerEnter(Collider other)
    {
        piłkaJeden.SetActive(false);
        StartCoroutine(VacuumEnu());
    }
    IEnumerator VacuumEnu()
    {
        yield return new WaitForSeconds(5);
        odkurzaczAnim.SetTrigger("VacuumTrigger");
        yield return new WaitForSeconds(1);
        wiatrak.SetActive(true);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
