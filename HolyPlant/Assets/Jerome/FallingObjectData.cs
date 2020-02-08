using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "FallingObjectData", menuName = "HolyPlant/FallingObjectData", order = 0)]
public class FallingObjectData : ScriptableObject {

    public Sprite sprite;


    public float mass;

    public float effectOnPlantStage;

    public float initialScale, fullScale, growTime;


    public string getMass() {
     return mass.ToString();   
    }

}