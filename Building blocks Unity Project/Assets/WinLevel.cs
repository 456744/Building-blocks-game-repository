using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WinLevel : MonoBehaviour
{

    public string Level;
    void OnCollisionEnter(Collision collision)
    {

        //Checks if the desired object was created
        if (collision.gameObject.tag == "Objective")
        {
            SceneManager.LoadScene(Level);

        }

    }

}
