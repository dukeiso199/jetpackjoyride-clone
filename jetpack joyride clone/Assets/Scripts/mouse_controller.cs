using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mouse_controller : MonoBehaviour
{
    public float jetpackForce = 75.0f;
    private Rigidbody2D playerRigidbody;

    // Start is called before the first frame update
    void Start()
    {
        playerRigidbody = GetComponent<Rigidbody2D>();
    }
    private void FixedUpdate()
    {
        //    bool jetpackActive = Input.GetButton("Fire1"); mouse left click

        bool Jetpackactive = Input.GetMouseButton(0);
        if (Jetpackactive)
        {
            playerRigidbody.AddForce(new Vector2(0, jetpackForce));

        }
    }

}
