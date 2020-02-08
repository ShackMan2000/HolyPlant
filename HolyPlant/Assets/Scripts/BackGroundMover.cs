using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackGroundMover : MonoBehaviour
{
    private float speed;

    [SerializeField]
    private Camera camera;



    private SpriteRenderer renderer;




    private GameManager manager;




    private void Awake()
    {
        renderer = GetComponent<SpriteRenderer>();
        manager = FindObjectOfType<GameManager>();


        float topOfCamera = camera.ViewportToWorldPoint(new Vector3(1, 1, camera.nearClipPlane)).y;
        float topOfBackground = renderer.transform.position.y + renderer.sprite.bounds.extents.y * renderer.transform.localScale.y;


        speed = (topOfBackground - topOfCamera) / manager.timeTillWin;

    }



    private void Update()
    {
        if (manager.winCounter > 0f)
            transform.position = new Vector2(transform.position.x, transform.position.y - speed * Time.deltaTime);


        float input = Input.GetAxis("Horizontal");
        print(input);

    }








}
