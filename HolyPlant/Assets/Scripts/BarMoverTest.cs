using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BarMoverTest : MonoBehaviour
{

    [SerializeField]
    private float handMoveSpeed;

    [SerializeField]
    private Transform leftHand, rightHand, bar;





    private void Update()
    {
       //                                                                                                                 MoveLeftHand();
        MoveRightHand();
        MoveLeftHand();


       // MoveBar();


    }

    private void MoveBar()
    {
        Vector2 middlePoint = (leftHand.position + rightHand.position) *0.5f;

        bar.position = middlePoint;
        bar.rotation = Quaternion.LookRotation(Vector3.forward, leftHand.position - bar.position);
        bar.Rotate(new Vector3(0f, 0f, 90f));
     


    }

    private void MoveLeftHand()
    {
        Vector2 oldPosition = leftHand.position;
        float changeX = 0f;
        float changeY = 0f;

        if (Input.GetKey(KeyCode.U))
            changeY = handMoveSpeed * Time.deltaTime;
        else if (Input.GetKey(KeyCode.J))
                changeY = -handMoveSpeed * Time.deltaTime;

        leftHand.transform.position = new Vector2(oldPosition.x + changeX, oldPosition.y + changeY);

    }


    private void MoveRightHand()
    {
        Vector2 oldPosition = rightHand.position;
        float changeX = 0f;
        float changeY = 0f;

        if (Input.GetKey(KeyCode.O))
            changeY = handMoveSpeed * Time.deltaTime;
        else if (Input.GetKey(KeyCode.L))
            changeY = -handMoveSpeed * Time.deltaTime;

        rightHand.transform.position = new Vector2(oldPosition.x + changeX, oldPosition.y + changeY);
    }

    

    private void FixedUpdate()
    {
        MoveBar();
    }
}
