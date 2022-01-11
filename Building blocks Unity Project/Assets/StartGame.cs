using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartGame : MonoBehaviour
{
    // when the screen is clicked move onto the first level
    private void OnMouseDown()
    {
        SceneManager.LoadScene("Level 1");
    }
}
