using System.Collections;
using System.Collections.Generic;
using UnityEngine; 
using TMPro; //<- "namespace"

public class ScoreTracker : MonoBehaviour
{
    public TextMeshProUGUI scoreText; //kollar vad för poäng du har och ökar eller minskar berebnde om du tar coins
    public int totalScore;

    private void Update()
    {
        scoreText.text = string.Format("Score: {0}", totalScore); // visar att du har 0 coins näe spelet startar
    }
}
