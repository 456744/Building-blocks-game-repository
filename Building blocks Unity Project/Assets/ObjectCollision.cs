using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectCollision : MonoBehaviour
{

    CreateObjects progress = null;

    private void Start()
    {
        progress = GameObject.Find("ObjectCreator").GetComponent<CreateObjects>();
    }

    //Detect collisions between the GameObjects with Colliders attached
    void OnCollisionEnter(Collision collision)
    {

        //Check for a match with the specific tag on any GameObject that collides with your GameObject
        if (collision.gameObject.tag == "Fire" || collision.gameObject.tag == "Water")
        {
            //If the GameObject has the same tag as specified, create a prefab object
            progress.createSteam++;
        }
    }
}
