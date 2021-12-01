using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateObjects : MonoBehaviour
{

    public int createObject = 0;

    public GameObject myPrefab;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (createObject >= 2)
        {
            createObject -= 2;

            Instantiate(myPrefab, new Vector3(0, 0, 0), Quaternion.identity);
        }


    }
}
