using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SPINNY : MonoBehaviour
{

    public float speed = 200f;

    // Update called once per frame
    void Update()
    {
        transform.Rotate(Vector3.forward, speed * Time.deltaTime);
    }


	
}
