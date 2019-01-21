using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetInvisible : MonoBehaviour
{
    // Use this for initialization
    void Start()
    {
        GetComponent<SpriteRenderer>().enabled = false; // gör så att ett obejekt inte syns i spelet
    }
}
