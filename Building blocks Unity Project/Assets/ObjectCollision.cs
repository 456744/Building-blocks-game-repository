using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectCollision : MonoBehaviour
{

    CreateObjects progress = null;

    public GameObject Hold;

    private void Start()
    {
        //finds the object creator object and the object attatched to the player that is used to hold objects
        progress = GameObject.Find("ObjectCreator").GetComponent<CreateObjects>();

        Hold = GameObject.Find("Hold object");
    }

    //Detect collisions between the GameObjects with Colliders attached
    void OnCollisionEnter(Collision collision)
    {

        //Checks if the game object and colliding object should make a heat object
        if (collision.gameObject.tag == "Fire" && gameObject.tag == "Air" || collision.gameObject.tag == "Air" && gameObject.tag == "Fire")
        {
            //tells the object creating script to create the desired prefab
            progress.createHeat++;
        }

        //Checks if the game object and colliding object should make a steam object
        if (collision.gameObject.tag == "Water" && gameObject.tag == "Heat" || collision.gameObject.tag == "Heat" && gameObject.tag == "Water")
        {
            //tells the object creating script to create the desired prefab
            progress.createSteam++;
        }

        //Checks if the game object and colliding object should make a mud object
        if (collision.gameObject.tag == "Earth" && gameObject.tag == "Water" || collision.gameObject.tag == "Water" && gameObject.tag == "Earth" || collision.gameObject.tag == "Earth" && gameObject.tag == "Cloud" || collision.gameObject.tag == "Cloud" && gameObject.tag == "Earth")
        {
            //tells the object creating script to create the desired prefab
            progress.createMud++;
        }

        //Checks if the game object and colliding object should make a cloud object
        if (collision.gameObject.tag == "Water" && gameObject.tag == "Air" || collision.gameObject.tag == "Air" && gameObject.tag == "Water")
        {
            //tells the object creating script to create the desired prefab
            progress.createCloud++;
        }

        //Checks if the game object and colliding object should make a lightning object
        if (collision.gameObject.tag == "Fire" && gameObject.tag == "Cloud" || collision.gameObject.tag == "Cloud" && gameObject.tag == "Fire")
        {
            //tells the object creating script to create the desired prefab
            progress.createLightning++;
        }

        //Checks if the game object and colliding object should make a glass object
        if (collision.gameObject.tag == "lightning" && gameObject.tag == "Earth" || collision.gameObject.tag == "Earth" && gameObject.tag == "lightning" || collision.gameObject.tag == "Fire" && gameObject.tag == "Sand" || collision.gameObject.tag == "Sand" && gameObject.tag == "Fire")
        {
            //tells the object creating script to create the desired prefab
            progress.createGlass++;
        }

        //Checks if the game object and colliding object should make a sand object
        if (collision.gameObject.tag == "Glass" && gameObject.tag == "Earth" || collision.gameObject.tag == "Earth" && gameObject.tag == "Glass")
        {
            //tells the object creating script to create the desired prefab
            progress.createSand++;
        }

        //Checks if the game object and colliding object should make a clay object
        if (collision.gameObject.tag == "Sand" && gameObject.tag == "Water" || collision.gameObject.tag == "Water" && gameObject.tag == "Sand")
        {
            //tells the object creating script to create the desired prefab
            progress.createClay++;
        }

        //Checks if the game object and colliding object should make a Brick object
        if (collision.gameObject.tag == "Fire" && gameObject.tag == "Clay" || collision.gameObject.tag == "Clay" && gameObject.tag == "Fire")
        {
            //tells the object creating script to create the desired prefab
            progress.createBrick++;
        }

        //Checks if the game object and colliding object should make a building object
        if (collision.gameObject.tag == "Brick" && gameObject.tag == "Mud" || collision.gameObject.tag == "Mud" && gameObject.tag == "Brick")
        {
            //tells the object creating script to create the desired prefab
            progress.createBuilding++;
        }

        //Checks if the game object and colliding object should make a smoke object
        if (collision.gameObject.tag == "Fire" && gameObject.tag == "Steam" || collision.gameObject.tag == "Steam" && gameObject.tag == "Fire")
        {
            //tells the object creating script to create the desired prefab
            progress.createSmoke++;
        }

        //Checks if the game object and colliding object should make a food object
        if (collision.gameObject.tag == "Smoke" && gameObject.tag == "Building" || collision.gameObject.tag == "Building" && gameObject.tag == "Smoke")
        {
            //tells the object creating script to create the desired prefab
            progress.createFood++;
        }

        //Checks if the game object and colliding object should make an offering object
        if (collision.gameObject.tag == "Food" && gameObject.tag == "lightning" || collision.gameObject.tag == "lightning" && gameObject.tag == "Food")
        {
            //tells the object creating script to create the desired prefab
            progress.createOffering++;
        }
    }

    private void OnMouseDown()
    {
        //when an object is clicked it is attatched to the player object to help move the objects and when an attatched object is clicked it is detatched
        if (transform.parent == null)
        {
            gameObject.transform.parent = Hold.transform;
        }
        else
        {
            transform.parent = null;
        }
    }

}
