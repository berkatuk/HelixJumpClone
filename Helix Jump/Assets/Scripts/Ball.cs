using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class Ball : MonoBehaviour
{
   private Rigidbody rb;
   public float bounceForce=400f;
   public GameObject splitPrefab;
   private void Start()
   {
      rb = GetComponent<Rigidbody>();
   }

   private void OnCollisionEnter(Collision other)
   {
      rb.velocity = new Vector3(rb.velocity.x, bounceForce * Time.deltaTime, rb.velocity.z);
      GameObject newSplit = Instantiate(splitPrefab, new Vector3(transform.position.x, other.transform.position.y+0.19f,
         transform.position.z), transform.rotation);

      newSplit.transform.localScale = Vector3.one * Random.Range(0.7f, 1.3f);
      newSplit.transform.parent = other.transform;

     
   }
}
