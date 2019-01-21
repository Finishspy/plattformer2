using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Victory : MonoBehaviour
{
    public string levelToLoad = "SampleScene"; // laddar branan 

    private void OnTriggerEnter2D(Collider2D collision) //om spelarn nuddar målinijen så vinner spelaren
    {
        if(collision.tag == "Player") // om spelarn nuddar flagan ´så printar spelat medalandet yay och startar om barnan 
        {
            print("Yay");   // printa yay 
            SceneManager.LoadScene(levelToLoad); // ladda om barnan 
        }
    }
}
