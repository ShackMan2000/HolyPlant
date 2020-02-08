using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Plant : MonoBehaviour
{
    [SerializeField]
    private float growStagePerMinute;


    public float growStage;


    [SerializeField]
    private List<GameObject> plantParts;



    public void NewGame()
    {
        growStage = 0f;
    }




    





    private void SetSprites()
    {
        int stages = Mathf.CeilToInt(growStage);

        foreach (var part in plantParts)
        {
            part.gameObject.SetActive(false);
        }

        for (int i = 0; i < stages; i++)
        {
            plantParts[i].gameObject.SetActive(true);
        }        

    }




  
}
