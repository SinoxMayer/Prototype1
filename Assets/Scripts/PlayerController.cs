using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PlayerController : MonoBehaviour
{
    //float kullanırken f kullanmak gerekiyor sonunda .
    //private float speed = 15.5f;
    private float turnSpeed = 40.0f ;
   // private float horizantalInput;
    private float horizantalNamluInput;
   // private float forwardInput;

    //public Transform wheelFl;
   // public Transform wheelFr;
    public Transform namlu;


    // Start is called before the first frame update
    void Start()
    {
        
    }


    

    // Update is called once per frame
    void Update()
    {

        //burda getaxis içinde bir string arıyor bunuda edit / project setings altında   input altında olan bır girdi ismini girmem gerekiyor    
        // horizantalInput = Input.GetAxis("Horizontal");
        horizantalNamluInput = Input.GetAxis("Namlu");

        //forwardInput = Input.GetAxis("Vertical");
      


        /*
         * thats lovely to code here in unity don't u think like that 
         * so lets drive the car why not .
         */
        //transform.Translate(0, 0, 1);   // zde ilerletir

        //transform.Translate(Vector3.forward * Time.deltaTime); // bu deltatime sayesinde  her frame olacağına her saniye olur 




        /*   // ilk orjinal kod bu idi
         * transform.Translate(Vector3.forward * Time.deltaTime * speed * forwardInput); // bu deltatime sayesinde  her frame olacağına her saniye olur 
         */

       

        //forward * her saniye * speed kadar 

        // araç sağ sol oynatma.
        //transform.Translate(Vector3.right * Time.deltaTime * turnSpeed * horizantalInput);
        //per frame yerine per second hareket etmek için  Time.deltaTime)

        /*
        transform.Rotate(Vector3.up, turnSpeed * horizantalInput * Time.deltaTime);


        wheelFl.Rotate(Vector3.up, turnSpeed * Time.deltaTime * horizantalInput);
        wheelFr.Rotate(Vector3.up, turnSpeed * Time.deltaTime * horizantalInput);

        */

        namlu.Rotate(Vector3.up, turnSpeed * Time.deltaTime * horizantalNamluInput);






    }
}
