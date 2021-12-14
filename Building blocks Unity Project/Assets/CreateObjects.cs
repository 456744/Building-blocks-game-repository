using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateObjects : MonoBehaviour
{

    public int createSteam = 0;

    public GameObject SteamPrefab;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (createSteam >= 2)
        {
            createSteam -= 2;

            Instantiate(SteamPrefab, new Vector3(Random.Range(0, 5), 5, Random.Range(0, 5)), Quaternion.identity);
        }


    }
}
