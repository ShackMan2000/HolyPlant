using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloudMover : MonoBehaviour
{

    [SerializeField]
    private float rotationSpeed;
    public GameObject Cloud;
    public float SideBoundary;
    public float MaxSpeed;

    
    // Update is called once per frame
    void Update()
    {
        RotatePlayer();
        MoveCloud();
    }

    private void RotatePlayer()
    {
        Vector3 oldRotation = this.transform.eulerAngles;
        float changeR = 0;

        if (Input.GetKey(KeyCode.Z))
        {
            changeR = 1f;//rotationSpeed * Time.deltaTime;
        }
        else if (Input.GetKey(KeyCode.P))
        {
            changeR = -1f;
        };

        Vector3 rotAm = new Vector3(0f, 0f, changeR);
        this.transform.Rotate(rotAm); 
    }

    private void MoveCloud() 
    {
        Vector3 oldPosition = Cloud.transform.position;
        float changeVec = 0f;

        if ((Mathf.Abs(Cloud.transform.position.x) < SideBoundary)) 
        {
            changeVec = this.transform.rotation.z / 90 * MaxSpeed; 
        } else 
        {
            if (Mathf.Sign(Cloud.transform.position.x) != Mathf.Sign(Cloud.transform.rotation.z)) 
            {
                changeVec = this.transform.rotation.z / 90 * MaxSpeed;
            }
        }
        Cloud.transform.position = new Vector3(oldPosition.x + changeVec, oldPosition.y, oldPosition.z);
    }
}
