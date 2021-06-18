using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleCreator : MonoBehaviour
{


    [SerializeField] GameObject Obstacle;
    [SerializeField] Transform refPos;

    float randomX;
    float separacion;
    float distancia;

    // Start is called before the first frame update
    void Start()
    {
        InicioColumna();
      
        StartCoroutine("Bucle");


    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void CrearColumna()
    {
        randomX = Random.Range(-10f, 10f);

        Vector3 initPos = new Vector3(randomX, 0f,0 );
        Vector3 NewPos = refPos.position + initPos;

        //que no lo gire
        Instantiate(Obstacle, NewPos,Quaternion.identity);



    }

    void InicioColumna()
    {
        for (int i = 0; i < 20; i++)
        {
            randomX = Random.Range(-10f, 10f);
            Vector3 initPos = new Vector3(randomX, 0f, -7*i);
            Vector3 NewPos = refPos.position + initPos;
            Instantiate(Obstacle, NewPos, Quaternion.identity);
        }
    }
    IEnumerator Bucle()
    {
        while (true)
        {


            CrearColumna();
            yield return new WaitForSeconds(0.3f);


        }


    }

}
