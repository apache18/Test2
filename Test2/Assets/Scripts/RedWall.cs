using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RedWall : MonoBehaviour
{//Правая красная стенка

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "RedCube") 
        {
            ScoreManager.scoreRightWall++;
            collision.gameObject.GetComponent<DragObjects>().DestroyCube();
            SpawnCubes.numberToSpawn--;
        }
        else if (collision.gameObject.tag == "BlueCube") 
        {
            BlueWall.check = false;

            Debug.Log("Ошибка");
        }
    }
}
