using System.Collections;
using UnityEngine;

public class ShipMovement : MonoBehaviour {

    public GameControl gameControl;
    public GameObject bullet;
    public float shipSpeed = 10f;
    public float reloadTime = 0.5f;

    private float elapsedTime = 0f;
    private Vector3 shipPosition;
    private Vector3 bullet1Position;
    private Vector3 bullet2Position;
    private float xMovement;

	void Update ()
    {
        elapsedTime += Time.deltaTime;
        xMovement = Input.GetAxis("Horizontal") * shipSpeed * Time.deltaTime;
        transform.Translate(xMovement, 0, 0);

        shipPosition = transform.position;
        shipPosition.x = Mathf.Clamp(transform.position.x, -7, 7);
        transform.position = shipPosition;

        if (Input.GetButton("Jump") && elapsedTime > reloadTime)
        {
            bullet1Position = shipPosition + new Vector3(-0.3f, 1.2f, 0);
            bullet2Position = shipPosition + new Vector3(0.3f, 1.2f, 0);
            Instantiate(bullet, bullet1Position, Quaternion.identity);
            Instantiate(bullet, bullet2Position, Quaternion.identity);
            elapsedTime = 0;
        }
	}

    private void OnTriggerEnter2D(Collider2D collision)
    {
        gameControl.PlayerDied();
    }
}
