using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeteorScript : MonoBehaviour {

    public float meteorSpeed = -2f;
    private Rigidbody2D rb;
    private float elopsedTime = 0f;

    void Start () {
        rb = GetComponent<Rigidbody2D>();
	}
	
	void Update () {
        elopsedTime += Time.deltaTime;

        if (elopsedTime < 30)
        {
            rb.velocity = new Vector2(0, meteorSpeed);
        }
        else if (elopsedTime < 60 && elopsedTime >= 30)
        {
            meteorSpeed = -6f;
            rb.velocity = new Vector2(0, meteorSpeed);
        }
        else if (elopsedTime < 100 && elopsedTime >= 60)
        {
            meteorSpeed = -9f;
            rb.velocity = new Vector2(0, meteorSpeed);
        }
        else if (elopsedTime < 150 && elopsedTime >= 100)
        {
            meteorSpeed = -12f;
            rb.velocity = new Vector2(0, meteorSpeed);
        }
        else if (elopsedTime < 200 && elopsedTime >= 150)
        {
            meteorSpeed = -15f;
            rb.velocity = new Vector2(0, meteorSpeed);
        }
        else
        {
            meteorSpeed = -18f;
            rb.velocity = new Vector2(0, meteorSpeed);
        }

    }
}
