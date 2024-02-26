using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOver : MonoBehaviour
{
    public static int score;
    public GameObject gameOver;

    public GameObject player;
    // Start is called before the first frame update


   

    private void OnCollisionEnter(Collision other)
    {
        if (other.transform.CompareTag("Unsafe"))
        {
            gameOver.SetActive(true);
            Time.timeScale = 0;
            
        }

       
    }

   /* private void ScoreCount()
    {
        if ()
        {
            
        }
    }*/
   
}
