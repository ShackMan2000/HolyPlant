using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ManagePlant : MonoBehaviour
{
    public GameObject PlantPart;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.N))
        {  
            GameObject NewPPart = Instantiate(PlantPart);
        }
    }


}
