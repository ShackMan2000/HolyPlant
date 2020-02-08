using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Plant : MonoBehaviour
{
    [SerializeField]
    private float shrinkStagePerMinute;

    [SerializeField]
    private float looseGameAfterXSecondsNoPlant;


    public float growStage, oldGrowStage;


    [SerializeField]
    private List<GameObject> plantParts;



    [SerializeField]
    private FloatRef deadPlantTime;


  
    private GameManager manager;



    private void Awake()
    {
        manager = FindObjectOfType<GameManager>();
        NewGame();
        
    }

    public void NewGame()
    {
        growStage = 0.5f;
        SetSprites();
    }



    private void Update()
    {
        growStage -= (shrinkStagePerMinute / 60f) * Time.deltaTime;
        if (growStage < 0f)
            deadPlantTime.currentValue += Time.deltaTime;

        SetSprites();
    }



    private void OnTriggerEnter2D(Collider2D collision)
    {
        Drop drop = collision.GetComponent<Drop>();

        if (drop != null)
        {
            growStage += drop.effectOnPlantStage;
            SetSprites();
        }
    }







    private void SetSprites()
    {
        int stages = Mathf.CeilToInt(growStage);
        if (oldGrowStage == stages) return;

        oldGrowStage = stages;

        foreach (var part in plantParts)
        {
            part.gameObject.SetActive(false);
        }


        stages = Mathf.Clamp(stages, 0, plantParts.Count);



        for (int i = 0; i < stages; i++)
        {
            plantParts[i].gameObject.SetActive(true);
        }

    }





}
