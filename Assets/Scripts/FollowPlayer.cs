using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    //gameobject olarak player yaratınca bir game object eklebilir .
    public GameObject player;
    private Vector3 vector3Cam = new Vector3(0, 6, -7);
 

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }
    
    //late update player update ten sonra calısacak 
    private void LateUpdate()
    {
        //+ new vector3 diyerek kamerayı arkasına koyaibliyoruz . new vector3 formatında ekleme yapabiliyoruz.
        transform.position = player.transform.position + vector3Cam;


    }



}
