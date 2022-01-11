using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WinScreen : MonoBehaviour
{
    public string Level;

    public int count;

    // Update is called once per frame
    void Update()
    {

        // waits a short while and the moves onto the next scene
        count++;
        if (count >= 1500)
        {
            SceneManager.LoadScene(Level);
        }
    }
}
