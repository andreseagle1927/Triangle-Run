using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Colisionador : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    private void OnTriggerEnter2D(Collider2D other)
    {
        Destroy(gameObject);
        GameManager.roof.Contador(1);
        Debug.Log(GameManager.roof.contador.ToString());
    }
   
}
