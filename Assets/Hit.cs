using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hit : MonoBehaviour
{
    public GameObject ball;
    public GameObject myhand;
    

    bool inhand = false;
    Collider ballcal;
    Rigidbody ballrb;
   // Camera cam;

    void Start()
    {
        ballcal = ball.GetComponent<CapsuleCollider>();
        ballrb = ball.GetComponent<Rigidbody>();
       // cam = GetComponent<Camera>();
    }

    public void grab()
    {
        if (!inhand)
        {
            ballcal.isTrigger = true;
            ballrb.useGravity = false;
            ball.transform.SetParent(myhand.transform);
            ball.transform.localPosition = new Vector3(0, 0.5f, 0);
            ballrb.velocity = Vector3.zero;
            inhand = true;
        }

        
        //else if (inhand)
        //{
        //    ballcal.isTrigger = false;
        //    ballrb.useGravity = true;
        //    ball.transform.SetParent(null);
        //    ballrb.velocity = cam.transform.rotation * Vector3.forward * throwforce;
        //    //this.GetComponent<gravity>().enabled = false;
        //    inhand = false;
        //}
    }

     

}
