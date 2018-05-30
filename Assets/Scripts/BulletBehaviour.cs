using System.Collections;
using UnityEngine;

public class BulletBehaviour : MonoBehaviour {

    private GameControl gameControl;
    public float bulletSpeed = 3f;
	void Start () {
        gameControl = GameObject.Find("GameControl").GetComponent<GameControl>();
	}
	

	void Update () {
        transform.Translate(0, bulletSpeed * Time.deltaTime, 0);
	}

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Destroy(collision.gameObject);
        gameControl.AddScore();
        Destroy(gameObject);
    }
}
