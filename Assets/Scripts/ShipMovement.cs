using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipMovement : MonoBehaviour
{
    public int speed;
    private float horizontal;
    private float vertical;
    private Rigidbody2D _compRigidbody2D;
    public AudioSource _compAudioSource;
    public GameObject bulletPrefab;
    // Start is called before the first frame update
    void Awake()
    {
        _compRigidbody2D = GetComponent<Rigidbody2D>();
    }
    void Start()
    {
        speed = 5;
    }

    // Update is called once per frame
    void Update()
    {
        horizontal = Input.GetAxis("Horizontal");
        vertical = Input.GetAxis("Vertical");

        //Crear bala

        if(Input.GetButtonDown("Fire1") == true)
        {
            Instantiate(bulletPrefab, transform.position, transform.rotation);
            _compAudioSource.Play();
        }
    }
    void FixedUpdate()
    {
        _compRigidbody2D.velocity = new Vector2(speed * horizontal, speed * vertical);
    }
}
