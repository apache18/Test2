using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;   

public class ScoreManager : MonoBehaviour
{//размещён на GameManager

    public static int scoreLeftWall;
    public static int scoreRightWall;
    public Text LeftText;
    public Text Righttext;

    private void Start()
    {
        scoreLeftWall = 0;
        scoreRightWall = 0;
    }

    private void Update()
    {
        LeftText.text = scoreLeftWall.ToString();
        Righttext.text = scoreRightWall.ToString();
    }
}
