using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScrollBackground : MonoBehaviour {

    public float scrollSpeed = -2f;
    private float elopsedTime = 0f;

	void Update () {

        elopsedTime += Time.deltaTime;

        if (elopsedTime < 30)
        {
            transform.Translate(scrollSpeed * Time.deltaTime, 0, 0);

            if (transform.position.y < -40)
            {
                transform.Translate(80, 0, 0);
            }
        }
        else if (elopsedTime < 60 && elopsedTime >= 30)
        {
            scrollSpeed = -3f;
            transform.Translate(scrollSpeed * Time.deltaTime, 0, 0);

            if (transform.position.y < -40)
            {
                transform.Translate(80, 0, 0);
            }
        }
        else if (elopsedTime < 100 && elopsedTime >= 60)
        {
            scrollSpeed = -4f;
            transform.Translate(scrollSpeed * Time.deltaTime, 0, 0);

            if (transform.position.y < -40)
            {
                transform.Translate(80, 0, 0);
            }
        }
        else if (elopsedTime < 150 && elopsedTime >= 100)
        {
            scrollSpeed = -5f;
            transform.Translate(scrollSpeed * Time.deltaTime, 0, 0);

            if (transform.position.y < -40)
            {
                transform.Translate(80, 0, 0);
            }
        }
        else if (elopsedTime < 200 && elopsedTime >= 150)
        {
            scrollSpeed = -6f;
            transform.Translate(scrollSpeed * Time.deltaTime, 0, 0);

            if (transform.position.y < -40)
            {
                transform.Translate(80, 0, 0);
            }
        }
        else
        {
            scrollSpeed = -6.5f;
            transform.Translate(scrollSpeed * Time.deltaTime, 0, 0);

            if (transform.position.y < -40)
            {
                transform.Translate(80, 0, 0);
            }
        }
    }
}
