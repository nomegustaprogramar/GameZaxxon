using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleMov : MonoBehaviour
{
    float speed;
    float posZ;

    
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        speed = 30f;



        posZ = transform.position.z;
        
        if (posZ < -20 )
        {
            Destroy(gameObject);

        }


        transform.Translate(Vector3.back * Time.deltaTime * speed);



    }
}
