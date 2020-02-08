using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class FloatRef : ScriptableObject
{
    public float initialValue;
    
    public float currentValue;




    public void Reset()
    {
        currentValue = initialValue;
    }



 
}
