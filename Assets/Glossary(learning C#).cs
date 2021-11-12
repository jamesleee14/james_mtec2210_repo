/*using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Above are the libraries

public class Glossary(learning C#) : MonoBehaviour
    //Above is the class(Glossary(learningC#)), public is the protection level like who can access it.
{

    //whenever you write a float, you need to write an f

    private float numberA= 5f;
    private float numberB = 4.5f;
    private int numberC= 3;
    private string s = "1";
    private int i = 1;
    private bool b = false;
    //How can I bring the piggy sprite renderer to this script
    public GameObject piggy;
    private Sprite piggySprite;
    private Color piggyColor;

    // Start is called before the first frame update
    void Start()
    {

        piggyColor = GameObject.Find("Piggy").GetComponent<SpriteRenderer>().color;

        gameObject
        transform


        AddNumbers();
        //this will call the function AddNumbers and will run it
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

//commands will only work if they are inside the braces

//this is a function:
/*
void Start()
{

}


public void AddNumbers()
{
    float x = numberA + (numberB / 2);
    //it will do order of operations(PEMDAS)
    //another way to do it is:
    float y = numberA + GetNumberDivided2(numberB);
    //we can use that function since we made it below and now were calling it and putting it to use
    Debug.Log("What's up");
    Debug.Log(x + " , " + y);

    Vector3 vec = new Vector3(0, 5.34f, 1.11f);
    float q = vec.z;
    Debug.log(q);
    //it will print out 1.11 since it is asking for the z coordinate
    float q = vec.z + vec.y + vec.x;
    Debug.log(q);
    //it will add all of it and give out the result which is 6.45
}

//above is a function
//void=doesn't return anything, it just runs the function

public float GetNumberDivided2(float num)
{
    float value = 0;
    if (num > 0)
    {
        value = num / 2
}
    else
    {
        value=num*2
    }
    return value;

    return num / 2;
    //takes any number and divides it by 2 since it was passed in the argument
}
}

//Variable: Data types that can change and be changed
//int: integer (0, 1, -1, etc.)
//float: floating number (0.001f, 0.5f, 6f)
//string: alphanumeric text ("Hello World", etc)
//bool: True/False
//Vector3: an array that has 3 components to it (X, Y, Z); it's basically coordinates
//Vector2: only X, Y coordinate, no Z (0, 0)
//Color: (1, 0, 0, 0.5f) (Red, Green, Blue, Opacity)
*/