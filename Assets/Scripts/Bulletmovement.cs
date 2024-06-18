using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bulletmovement : MonoBehaviour
{
    private Transform _compTransform;
    public int speed;
    public int Life_Time;
    // Start is called before the first frame update
    void Awake()
    {
        _compTransform = GetComponent<Transform>();
        
    }
    void Start()
    {
        speed = 5;
        Life_Time = 10;

        Destroy(gameObject, Life_Time);
    }
    void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.gameObject.tag == "EnemyShip")
        {
            Destroy(gameObject);
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
    void FixedUpdate()
    {
        _compTransform.position = new Vector2(transform.position.x , _compTransform.position.y + speed * Time.deltaTime);
    }
}
