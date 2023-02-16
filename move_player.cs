using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move_player : MonoBehaviour
{
    public float playerSpeed = 100f;
    private Vector2 hMovement = new Vector2(0f, 0f);
    void Start()
    {
        
    }

    void Update()
    {
        hMovement = new Vector2(Input.GetAxisRaw("Horizontal"), 0);
    }

    private void FixedUpdate()
    {
        GetComponent<Rigidbody2D>().velocity = hMovement * playerSpeed * Time.fixedDeltaTime;
    }
}
