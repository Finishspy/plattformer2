using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HurtObject : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision) // om spelearen nuddar detta så startar man om barnan
    {
        if(collision.gameObject.tag == "Player")  // om spelarn nuddar så laddar man om barnan 
        {
            Scene active = SceneManager.GetActiveScene(); // variabeln active tilldelas den activa scenen 
            SceneManager.LoadScene(active.name); // laddar den activa scenen
        }
    }
}
