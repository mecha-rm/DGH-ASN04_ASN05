using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// script for the 3D model.
public class Model : MonoBehaviour
{
    // beocmes 'true', when colliding with something.
    public bool colliding = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // entered a collision.
    private void OnCollisionStay(Collision collision)
    {
        colliding = true;
    }

    // left a collision.
    private void OnCollisionExit(Collision collision)
    {
        colliding = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
