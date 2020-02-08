using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallingObject : MonoBehaviour
{

 





    public virtual void Initialize (FallingObjectData objectSettings) {
        // Set objecttype
        Debug.Log ("I am a " + objectSettings.getMass());


       

    }




}
