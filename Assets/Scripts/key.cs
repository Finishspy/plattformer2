using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class key : MonoBehaviour {

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")  // om spelarn nuddar 
        {
            GameObject[] holes = GameObject.FindGameObjectsWithTag("Keyhole"); //hittar alla gameobjects med "Keyhole" taget och förstör dem 
            foreach (GameObject item in holes)
            {
                Destroy(item); // förstör objektet
            }
            Destroy(gameObject);  //  förstör spel objektet 
        }
    }
}
