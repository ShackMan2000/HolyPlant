using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "FallingObjectData", menuName = "HolyPlant/FallingObjectData", order = 0)]
public class FallingObjectData : ScriptableObject {

    public float mass;

    public float effectOnPlantStage;


    public string getMass() {
     return mass.ToString();   
    }

}