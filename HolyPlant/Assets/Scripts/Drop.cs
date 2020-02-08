using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Drop : MonoBehaviour
{


   
    private float initialScale, fullScale, growTime;

    private float growPerSecond;

    private bool isGrowing;

    [HideInInspector]
    public float effectOnPlantStage;




    private void Awake()
    {
        GetComponent<Rigidbody2D>().isKinematic = true;
    }

    public  void Initialize(FallingObjectData settings)
    {
      
    effectOnPlantStage = settings.effectOnPlantStage;


        initialScale = settings.initialScale;
        fullScale = settings.fullScale;
        growTime = settings.growTime;


        growPerSecond = 1f / (fullScale - initialScale);
        transform.localScale = new Vector3(initialScale, initialScale, initialScale);
        isGrowing = true;

    }



    private void Update()
    {
        if(isGrowing)
        {
            float oldScale = transform.localScale.x;
            float newScale = oldScale + growPerSecond * Time.deltaTime;
            transform.localScale = new Vector3(newScale, newScale, newScale);

            if (newScale >= fullScale)
            {
                isGrowing = false;
                GetComponent<Rigidbody2D>().isKinematic = false;
            }

        }





    }









}
