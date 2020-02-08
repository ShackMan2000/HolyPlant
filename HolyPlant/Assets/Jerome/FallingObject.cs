using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallingObject : MonoBehaviour
{
    public float effectOnPlantStage;

    public FallingObjectData settings;




    private void Awake()
    {
        Initialize(settings);
    }


    public void Initialize (FallingObjectData objectSettings) {
        // Set objecttype
        Debug.Log ("I am a " + objectSettings.getMass());


        effectOnPlantStage = objectSettings.effectOnPlantStage;

    }




}
