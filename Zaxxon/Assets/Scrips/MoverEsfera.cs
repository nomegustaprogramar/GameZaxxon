using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;

public class MoverEsfera : MonoBehaviour
{

    float speed;
    [SerializeField] Collider naveCollider;
    [SerializeField] GameObject naveMesh;
    [SerializeField] GameObject gameOver;
    [SerializeField] GameObject botonReturn;

    // Start is called before the first frame update
    void Start()
    {
        speed = 5f;
    }

    // Update is called once per frame
    void Update()
    {
       MoverNave();
    }

   void MoverNave()
    {
     
        float posX = transform.position.x;
        float desplX = Input.GetAxis("Horizontal");
        float posY = transform.position.y;
        float desplY = Input.GetAxis("Vertical");


        if (posX < 9 && posX > -9 || desplX > 0 && posX < -9  || posX  > 9 && desplX < 0)
        {
            transform.Translate(Vector3.right * Time.deltaTime * speed * desplX, Space.World);

        }


        if (posY < 5.6 && posY > 0.9 || desplY > 0 && posY < 0.9|| posY > 5.6 && desplY < 0)
        {
            transform.Translate(Vector3.up  * speed * Time.deltaTime* desplY, Space.World);

        }
        transform.rotation = Quaternion.Euler(desplY * -20, 0, desplX * -20);


    }

     void OnTriggerEnter(Collider enemigo)
    {
        if (enemigo.gameObject.tag == "Columna")
        {
            naveMesh.SetActive(false);
            gameOver.SetActive(true);
            EventSystem.current.SetSelectedGameObject(null);
            EventSystem.current.SetSelectedGameObject(botonReturn);
            Time.timeScale = 0f;
        }
    } /*
    public void Return()
    {
        if(gameOver.activeInHierarchy == true)
        {
            SceneManager.LoadScene(0);
        }
    }

    */
}
