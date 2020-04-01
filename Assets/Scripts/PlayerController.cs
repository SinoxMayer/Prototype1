using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    //float kullanırken f kullanmak gerekiyor sonunda .
    public float speed = 15.5f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        /*
         * thats lovely to code here in unity don't u think like that 
         * so lets drive the car why not .
         */
        //transform.Translate(0, 0, 1);   // zde ilerletir

        //transform.Translate(Vector3.forward * Time.deltaTime); // bu deltatime sayesinde  her frame olacağına her saniye olur 
        transform.Translate(Vector3.forward * Time.deltaTime * speed); // bu deltatime sayesinde  her frame olacağına her saniye olur 
        //forward * her saniye * speed kadar 

    }
}
