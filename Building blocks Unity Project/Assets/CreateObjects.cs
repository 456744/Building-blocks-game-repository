using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateObjects : MonoBehaviour
{

    public int createHeat = 0;

    public GameObject HeatPrefab;

    public int createSteam = 0;

    public GameObject SteamPrefab;

    public int createMud = 0;

    public GameObject MudPrefab;

    public int createCloud = 0;

    public GameObject CloudPrefab;

    public int createLightning = 0;

    public GameObject LightningPrefab;

    public int createGlass = 0;

    public GameObject GlassPrefab;

    public int createSand = 0;

    public GameObject SandPrefab;

    public int createClay = 0;

    public GameObject ClayPrefab;

    public int createBrick = 0;

    public GameObject BrickPrefab;

    public int createBuilding = 0;

    public GameObject BuildingPrefab;

    public int createSmoke = 0;

    public GameObject SmokePrefab;

    public int createFood = 0;

    public GameObject FoodPrefab;

    public int createOffering = 0;

    public GameObject OfferingPrefab;

    public AudioSource Clip;


    // Update is called once per frame
    void Update()
    {
        if (createHeat >= 2)
        {
            createHeat -= 2;

            Instantiate(HeatPrefab, new Vector3(Random.Range(0, 5), 5, Random.Range(0, 5)), Quaternion.identity);

            Clip.Play(0);
        }

        if (createSteam >= 2)
        {
            createSteam -= 2;

            Instantiate(SteamPrefab, new Vector3(Random.Range(0, 5), 5, Random.Range(0, 5)), Quaternion.identity);

            Clip.Play(0);
        }

        if (createMud >= 2)
        {
            createMud -= 2;

            Instantiate(MudPrefab, new Vector3(Random.Range(0, 5), 5, Random.Range(0, 5)), Quaternion.identity);

            Clip.Play(0);
        }

        if (createCloud >= 2)
        {
            createCloud -= 2;

            Instantiate(CloudPrefab, new Vector3(Random.Range(0, 5), 5, Random.Range(0, 5)), Quaternion.identity);

            Clip.Play(0);
        }

        if (createLightning >= 2)
        {
            createLightning -= 2;

            Instantiate(LightningPrefab, new Vector3(Random.Range(0, 5), 5, Random.Range(0, 5)), Quaternion.identity);

            Clip.Play(0);
        }

        if (createGlass >= 2)
        {
            createGlass -= 2;

            Instantiate(GlassPrefab, new Vector3(Random.Range(0, 5), 5, Random.Range(0, 5)), Quaternion.identity);

            Clip.Play(0);
        }

        if (createSand >= 2)
        {
            createSand -= 2;

            Instantiate(SandPrefab, new Vector3(Random.Range(0, 5), 5, Random.Range(0, 5)), Quaternion.identity);

            Clip.Play(0);
        }

        if (createClay >= 2)
        {
            createClay -= 2;

            Instantiate(ClayPrefab, new Vector3(Random.Range(0, 5), 5, Random.Range(0, 5)), Quaternion.identity);

            Clip.Play(0);
        }

        if (createBrick >= 2)
        {
            createBrick -= 2;

            Instantiate(BrickPrefab, new Vector3(Random.Range(0, 5), 5, Random.Range(0, 5)), Quaternion.identity);

            Clip.Play(0);
        }

        if (createBuilding >= 2)
        {
            createBuilding -= 2;

            Instantiate(BuildingPrefab, new Vector3(Random.Range(0, 5), 5, Random.Range(0, 5)), Quaternion.identity);

            Clip.Play(0);
        }

        if (createSmoke >= 2)
        {
            createSmoke -= 2;

            Instantiate(SmokePrefab, new Vector3(Random.Range(0, 5), 5, Random.Range(0, 5)), Quaternion.identity);

            Clip.Play(0);
        }

        if (createFood >= 2)
        {
            createFood -= 2;

            Instantiate(FoodPrefab, new Vector3(Random.Range(0, 5), 5, Random.Range(0, 5)), Quaternion.identity);

            Clip.Play(0);
        }

        if (createOffering >= 2)
        {
            createOffering -= 2;

            Instantiate(OfferingPrefab, new Vector3(Random.Range(0, 5), 5, Random.Range(0, 5)), Quaternion.identity);

            Clip.Play(0);
        }


    }
}
