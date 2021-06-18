using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Counter : MonoBehaviour
{
    [SerializeField] Text MyText;

    [SerializeField] float speed;

    float seconds;
    float minutes;
    string secondsSt;
    string minutesSt;


    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine("Cronometro");

   

    }

    IEnumerator Cronometro()
    {
       
        
        for (; ; )
        {

            seconds += 1;
            if (seconds < 10)
            {
                secondsSt = "0" + seconds.ToString();
            }
            else
            {
                //Si superamos el minuto
                if (seconds > 59)
                {
                    minutes++;
                    seconds = 0;
                }
                secondsSt = seconds.ToString();
            }
            if (minutes < 10)
            {
                minutesSt = "0" + minutes.ToString();
            }
           
           
         
        //Añadimos el texto
        MyText.text = "Contador        " + minutesSt + " " + secondsSt;
            yield return new WaitForSeconds(1f);
        }

    }


}
