using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{

    [HideInInspector]
    public float winCounter;

    [SerializeField]
    private float dieAfterXSecondsDeadPlant;


    [SerializeField]
    private FloatRef deadPlantTime;


    private bool isGameOver;
    public float timeTillWin;


    private void Awake()
    {
        deadPlantTime.Reset();
        winCounter = timeTillWin;

    }






    private void Update()
    {
        if (deadPlantTime.currentValue > dieAfterXSecondsDeadPlant)
            GameOver();

        winCounter -= Time.deltaTime;
        if (winCounter < 0f)
            print("winnger");
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
