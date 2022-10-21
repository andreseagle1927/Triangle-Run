using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstaculesMove : MonoBehaviour
{
    Rigidbody2D rb2d;
    public float moveSpeed = -6;
    // Start is called before the first frame update
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    

    private void FixedUpdate()
    {
        rb2d.velocity = new Vector2(0,moveSpeed);
    }
}
