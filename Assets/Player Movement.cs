/*using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed;

    public Transform bike;
    public GameObject Prefab;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("bike World Pos: " + bike.position);
        Debug.Log("bike Local Pos: " + bike.localPosition);
        sr = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        float xMovement = Input.GetAxis("Horizontal");

        transform.Translate(speed * Time.deltaTime * xMovement, 0, 0);

        if (xMovement > 0)
        {
            sr.flipX = false;
        } else if (xMovement<0)
        {
            sr.flipX = true;
        }

        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(speed * Time.deltaTime, 0, 0);
            sr.flipX = false;
        }
        if (Input.GetKey(Keycode.A))
        {
            transform.Translate(speed * Time.deltaTime, 0, 0);
            sr.flipX = true;
        }
        if (Input.GetMouseButton(0))
        {
            Shoot();
        }
        
        if (Input.GetKeyDown)
       
        }
        }
    }

    public void Shoot()
    {
        Debug.log("Shooting");
        //code for shooting
    }

    public void UseItem()
    {
        Debug.log("Item Used")
            //code for using item
    }

    public void SpawnPiggy()
    {
        GameObject piggy = Instantiate(piggyPrefab, Vector3.zero, Quaternion.identity);
        piggy.GetComponent<PlayerMovement>().speed = 0;
        //or piggy.GetComponent<PlayerMovement>().enabled=false;
        //this is to restrict a clones movement; so that one of it can move while the other doesn't
    }

}
    {
        
    }
}
*/