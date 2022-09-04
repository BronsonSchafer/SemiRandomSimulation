using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Slime : MonoBehaviour
{
    float xDir= 1, yDir = 2;
    float xSpeed = 1, ySpeed = 1;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(xDir*xSpeed, yDir*ySpeed, 0);
    }
}
