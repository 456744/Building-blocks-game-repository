using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinLevel : MonoBehaviour
{
    void OnCollisionEnter(Collision collision)
    {

        //Checks if the desired object was created
        if (collision.gameObject.tag == "Objective")
        {
            Debug.LogWarning("Win!");

        }

    }

}
