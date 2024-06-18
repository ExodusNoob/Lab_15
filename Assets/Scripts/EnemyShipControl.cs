using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyShipControl : MonoBehaviour
{
    public GameObject explotionPrefab;
    private Rigidbody2D _compRigidbody2D;
    public EnemyContainerControl enemyContainer;
    public int speedY;
    public int Life_Time;
    public float ActualTimer; //public para revisión
    void Awake()
    {
        _compRigidbody2D = GetComponent<Rigidbody2D>();
    }
    void Start()
    {
        speedY = Random.Range(100, 200);
    }
    void Update()
    {

        ActualTimer = ActualTimer + Time.deltaTime;
        if (ActualTimer >= Life_Time)
        {
            ActualTimer = 0;
            Destroy(gameObject);
        }
    }
    public void SetEnemyContainerControl(EnemyContainerControl enemyContainer)
    {
        this.enemyContainer = enemyContainer;
    }
    void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.gameObject.tag == "bala")
        {
            enemyContainer.IncreasePoints(5);
            Instantiate(explotionPrefab, transform.position, transform.rotation);
            Destroy(gameObject);
        }
    }
    void FixedUpdate()
    {
        _compRigidbody2D.velocity = new Vector2(0, -speedY * Time.deltaTime);
    }
}
