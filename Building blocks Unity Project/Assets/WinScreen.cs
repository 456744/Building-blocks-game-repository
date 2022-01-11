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
        count++;
        if (count >= 1500)
        {
            SceneManager.LoadScene(Level);
        }
    }
}
