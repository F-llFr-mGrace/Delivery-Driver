using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collsion : MonoBehaviour
{
     void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("Ouch!");
    }
}