using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    public int score = 1;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player") // om objektet nuddar något med tagen player 
        {
            //Skapa en temporär variabel "controller" och sätt den till
            //resultatet av sökningen efter objektet med taggen "GameController".
            GameObject controller = GameObject.FindWithTag("GameController"); // letar efter en temporär component om
            if (controller != null)
            {
                //Skapa en temporär variabel "tracker" och sätt den till
                //resultatet av sökningen efter komponenten "ScoreTracker".
                ScoreTracker tracker = controller.GetComponent<ScoreTracker>(); // letar efter score tracker 
                if (tracker != null) // checker om något finns  
                {
                    tracker.totalScore += score; // om componenten scoretaker fanns så lägg till en poäng 
                }
                else
                {
                    Debug.LogError("ScoreTracker saknas på GameController."); 
                }
            }
            else
            {
                Debug.LogError("GameContoller finns inte.");
            }

            Destroy(gameObject); //destroys gamobject coin 
        }
    }
}
