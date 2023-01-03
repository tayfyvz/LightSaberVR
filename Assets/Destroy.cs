using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroy : MonoBehaviour

{
    public GameObject patlama;

    void OnTriggerEnter(Collider other)
    {
        if(other.tag!= "duvar")
        {
            Destroy(other.gameObject);
            Instantiate(patlama, other.transform.position, other.transform.rotation);
            
        }
    }
}
