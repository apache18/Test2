using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlueWall : MonoBehaviour
{//Расположен на левоя синей стенке

    public static bool check = true;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "BlueCube")
        {
            ScoreManager.scoreLeftWall++;
            collision.gameObject.GetComponent<DragObjects>().DestroyCube();
            SpawnCubes.numberToSpawn--;
        }
        else if (collision.gameObject.tag == "RedCube")
        {
            check = false;

            Debug.Log("Ошибка");
        }
    }

}
