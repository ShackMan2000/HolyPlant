using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{


    [SerializeField]
    private float dieAfterXSecondsDeadPlant;


    [SerializeField]
    private FloatRef deadPlantTime;


    private bool isGameOver;



    private void Awake()
    {
        deadPlantTime.Reset();
    }






    private void Update()
    {
        if (deadPlantTime.currentValue > dieAfterXSecondsDeadPlant)
            GameOver();
    }


    public void GameOver()
    {
        if(!isGameOver)
        {

            isGameOver = true;
        print("GameOver");

        }
    }


}
