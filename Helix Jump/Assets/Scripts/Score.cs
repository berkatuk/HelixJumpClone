using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.PlayerLoop;

public class Score : MonoBehaviour
{
   public GameObject start;
   public GameObject end;
   public static int score = 0;
   public RaycastHit hit;

   private void Update()
   {
      Debug.Log(score);
      Debug.DrawLine(start.transform.position,end.transform.position,Color.green);
      if (Physics.Linecast(start.transform.position,end.transform.position,out hit))
      {
         if (hit.transform.CompareTag("Player"))
         {
            score++;

         }
        
      }
   }

   
}
