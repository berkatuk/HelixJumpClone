using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rinf : MonoBehaviour
{
    // Start is called before the first frame update
    private Transform player;
    public GameObject[] childrings;
    private float force = 250f;
    private float radius = 100f;
   


    private void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;
    }

    private void Update()
    {
        if (transform.position.y > player.position.y +0.1f)
        {
           
            for (int i = 0; i < childrings.Length; i++)
            {
                childrings[i].GetComponent<Rigidbody>().isKinematic = false;
                childrings[i].GetComponent<Rigidbody>().useGravity = true;


                Collider[] colliders = Physics.OverlapSphere(transform.position, radius);
                foreach (Collider newCollider in colliders)
                {
                    Rigidbody rb = newCollider.GetComponent<Rigidbody>();
                    if (rb != null)
                    {
                        rb.AddExplosionForce(force,transform.position,radius);
                        
                    }
                }

                childrings[i].transform.parent = null;
                Destroy(childrings[i].gameObject,2f);
            }

            this.enabled = false;
        }
        
    }
}
