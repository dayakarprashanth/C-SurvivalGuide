using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestructibleCrate : MonoBehaviour
{
    public GameObject fracturedCrate;
    public GameObject explosionEffect;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.Space))
        {

            Instantiate(explosionEffect, transform.position, Quaternion.identity);
            //creates the fractured crate
            GameObject fracturedCrateObj = Instantiate(fracturedCrate, transform.position, Quaternion.identity);//Rotation to be the same so we use Quaternion.identity
            Rigidbody[] allRigidBodies = fracturedCrateObj.GetComponentsInChildren<Rigidbody>();
            if (allRigidBodies.Length > 0)
            {
                foreach (var body in allRigidBodies)
                {
                    body.AddExplosionForce(500, transform.position, 1);
                }
            }
            //Destroy the game objct but before we do we need to intantiate a fractured Crate so(look at the code above)
            Destroy(this.gameObject);

        }
        
    }
}
