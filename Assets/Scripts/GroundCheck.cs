using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundCheck : MonoBehaviour //kollar om spelaren nuddar marken 
{
    public int touches;

    private void OnTriggerEnter2D(Collider2D collision) // om du nuddar marken så kan du hoppa 
    {
        touches++;
    }

    private void OnTriggerExit2D(Collider2D collision) // om den inte nuddar marken så kan du inte hoppa 
    {
        touches--;
    }
}
