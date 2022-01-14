using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using Random = System.Random;
using TMPro;

public class PlayerController : MonoBehaviour
{
    public float speed = 0;

    private Rigidbody rb;
    private float movementX;
    private float movementY;
    private Random rand = new Random();

    private int points;
    public TextMeshProUGUI countText;

    public GameObject deathText;

    // Start is called before the first frame update
    void Start()
    {
        this.rb = GetComponent<Rigidbody>();
        this.points = 0;
        SetCountText();

        this.deathText.SetActive(false);
    }

    private void OnMove(InputValue movementValue)
    {
        Vector2 movementVector = movementValue.Get<Vector2>();
        this.movementX = movementVector.x;
        this.movementY = movementVector.y;
    }

    void SetCountText() {
        this.countText.text = "Count: " + this.points.ToString();
    }

    private void FixedUpdate()
    {
        Vector3 movement = new Vector3(this.movementX, 0.0f, this.movementY);

        rb.AddForce(movement * this.speed);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("PickUp"))
        {
            this.points++;
            SetCountText();
        } else if(other.gameObject.CompareTag("PowerUp"))
        {
            Timer.timeValue += 3;
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.CompareTag("Enemy")) {
            this.deathText.SetActive(true);
            gameObject.SetActive(false);
            Timer.timeValue = 0;
        }
    }
}
