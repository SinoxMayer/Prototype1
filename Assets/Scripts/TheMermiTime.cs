using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TheMermiTime : MonoBehaviour
{
    public GameObject mermi;
    public Transform m_FireTransform;



    public float speed = 100f;

    // Update is called once per frame
    void Update()
    {


        if (Input.GetKeyDown(KeyCode.Space))
        {



            GameObject instFoam = Instantiate(mermi, transform.position, Quaternion.identity);
            Rigidbody instFoamRB = instFoam.GetComponent<Rigidbody>();

            instFoamRB.AddForce(Vector3.up * speed);
            Destroy(instFoam, 3f);


        }


    }
}
