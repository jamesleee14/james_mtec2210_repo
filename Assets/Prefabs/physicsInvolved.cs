using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class physicsInvolved : MonoBehaviour
{
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
        float speedx = Time.deltaTime * speedMul * xPos;

        rb.AddForce(Vector2.right * speedx, ForceMode2D.Force);

        float yPos = Input.GetAxis("Vertical");
        float speedy = Time.deltaTime * speedMul * yPos;
        rb.AddForce((Vector2.right * speedy)/50, ForceMode2D.Impulse);

        if (Input.GetKeyDown("space"))
        {
            transform.Translate(Vector2.up * 500 * Time.deltaTime, Space.World);
        }

        //this is short for (1, 0);
        //Impulse is usefule for jump. Impulse will do it's thing(burst of force) and then left gravity take control after

        /*if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(-speed * Time.deltaTime, 0, 0);
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(speed * Time.deltaTime, 0, 0);
        }
        */
    }
}