using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cloud : MonoBehaviour
{
    Vector3 pos = new Vector3(50f, 0f, 0f);
    float speed = -2f; 
    float bound = -25f;
  

    // Update is called once per frame
    void Update()
    {
       
        if(transform.position.x < bound)
        {
           transform.Translate(pos);
        }
        else { 
          transform.Translate(speed * Time.deltaTime, 0f, 0f); 
        }

    }
}

