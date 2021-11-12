using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playermovement : MonoBehaviour
{
    //public float speed = 10f;
    public float speedMul = 1f;
    private Rigidbody2D rb;
    
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        float xPos = Input.GetAxis("Horizontal");
        float speed = Time.deltaTime * speedMul * xPos;
        //xpos will be a positive between 0-1 going to the right, 0 to -1 going to left, 0 if im not touching it
        rb.AddForce(Vector2.right * speed, ForceMode2D.Force);

        if (Input.GetKeyDown(KeyCode.Space)) ;
        {
            rb.AddForce(Vector2.up * speed, ForceMode2D.Force);
        }

        //transform.position = new Vector3(transform.position.x + speed, transform.position.y, transform.position.z);

        //transform.Translate(speed*xPos*Time.deltaTime, 0, 0);

        //Debug.Log("Time.deltaTime: " + Time.deltaTime);
        //xPos if left button is pressed=-1
        //xPos if right button is pressed=1
        //xPos if nothing is pressed=0

        //speed=5
        //xPos*speed if left button is pressed=-5
        //xPos*speed if right button is pressed=5
        //xPos*speed if nothing pressed=0
    }
}