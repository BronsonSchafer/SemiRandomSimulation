using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Slime : MonoBehaviour
{
    float xDir= 1, yDir = 1;
    float xSpeed = 0.05f, ySpeed = 0.05f;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(xDir*xSpeed, yDir*ySpeed, 0);
        // make the pixel change direction after hitting the edge
        Vector3 pos = Camera.main.WorldToViewportPoint(transform.position);
        // left 
        if(pos.x < 0.0){
            xDir = 1;
        }
        // right 
        if(1.0 < pos.x){
            xDir = -1;
        }
        // below
        if(pos.y < 0.0){
            yDir = 1;
        }
        // above 
        if(1.0 < pos.y){
            yDir = -1;
        }
    }
}
