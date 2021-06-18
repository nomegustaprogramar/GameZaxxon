using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera_mov : MonoBehaviour
{
    [SerializeField] Transform navePos;
    [SerializeField] float smoothSpeed = 0.3F;
    [SerializeField] Vector3 camSpeed = Vector3.zero;


    // Start is called before the first frame update
    void Start()
    {
        


    }

    // Update is called once per frame
    void Update()
    {
        Vector3 camPos = new Vector3(navePos.position.x, navePos.position.y + 1f, navePos.position.z - 4);
        transform.position = Vector3.SmoothDamp(transform.position, camPos, ref camSpeed, smoothSpeed);

    }
}
