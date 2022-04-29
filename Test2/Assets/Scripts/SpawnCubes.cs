using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnCubes : MonoBehaviour
{//размещён на GameManager
    public static int numberToSpawn;
    public List<GameObject> spawnPol;
    public GameObject imagePlayAgain;

    private void Start()
    {
        imagePlayAgain.SetActive(false);

        numberToSpawn = Random.Range(4, 10);

        int randomItem = 0;
        GameObject toSpawn;

        float screenX, screenY = -2f, screenZ;
        Vector3 pos;

        for (int i = 0; i < numberToSpawn; i++)
        {
            randomItem = Random.Range(0, spawnPol.Count);
            toSpawn = spawnPol[randomItem];

            screenX = Random.Range(-2f, 2f);
            screenZ = Random.Range(0f, -5f);
            pos = new Vector3(screenX, screenY, screenZ);

            Instantiate(toSpawn, pos, toSpawn.transform.rotation);
        }
    }
    private void Update()
    {
        if (numberToSpawn <= 0) 
        {
            imagePlayAgain.SetActive(true);
        }
    }
}
