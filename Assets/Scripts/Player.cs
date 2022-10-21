using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;



public class Player : MonoBehaviour
{

    Rigidbody2D rb2d;
   
    public Text puntuacion ;

    public Text rec;
    float final = 1;
    public double score;

    // variable es la velocidad que va a ir escalando al pasar cada zona de velocidad
    float variable = 2;
    int record = 1 ;
    int tito;

    float timeLeft = 0;
    

    // por cada fotograma
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
        rb2d.velocity = new Vector2(0,0);
        
    }

    // Update is called once per frame
    void Update()
    {
        score += variable* Time.deltaTime;
        tito = (int)Math.Ceiling(score);
        puntuacion.text=tito.ToString();
        rec.text="RECORD = "+GameManager.roof.record.ToString();

        

        if(tito>200){
           
            variable =  2.5f;
        }

        if(tito >GameManager.roof.record){
            record = tito;
            GameManager.roof.Record(record);
        } 


        

      if(Input. GetMouseButtonDown(0))
      {
        if(final == 1){
            final=2;
            transform.rotation = Quaternion.Euler(0, 0,755);
            //Quaternion toRotation = Quaternion.LookRotation(Vector3.forward, rb2d.velocity);
            //transform.rotation = Quaternion.RotateTowards(transform.rotation,toRotation,755);
        }

        else if(final == 2){
            final=1;
            transform.rotation = Quaternion.Euler(0, 0,315);

            
           // Quaternion toRotation = Quaternion.LookRotation(Vector3.forward, rb2d.velocity);
            //put in the last position, -365
            //transform.rotation = Quaternion.RotateTowards(transform.rotation, toRotation,755);
        }
      }

        
    }
    private void FixedUpdate()
    {
        
        

        if( final == 1 )
        {
            rb2d.velocity = new Vector2(6,0);
            
        }
        else if( final == 2  )
        {
          rb2d.velocity = new Vector2(-6,0);  
          
        }

    }

   
}
