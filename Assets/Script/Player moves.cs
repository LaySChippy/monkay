using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Playermoves : MonoBehaviour
{

    float xinput=0;
    float yinput=0; 
    Rigidbody2D rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent.<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void GetInput(){
        xinput = Input.GetAxis("Horizontal");
        yinput = Input.GetAxis("Vertical");
    }
}
