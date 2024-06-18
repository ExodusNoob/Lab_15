using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyContainerControl : MonoBehaviour
{
    public GameObject enemyPrefab;
    public float CreateEnemyTimer = 3;
    private float ActualTimer = 0;
    public bool ActivatorCreateEnemy = true;
    public GameManagerControl gameManager;
    // Start is called before the first frame update
    void Start()
    {
        // :3
    }
    void CreateEnemyShip()
    {
        GameObject enemy = Instantiate(enemyPrefab, new Vector2(Random.Range(-5.33f, 5.33f), 7.06f), transform.rotation);
        enemy.GetComponent<EnemyShipControl>().SetEnemyContainerControl(this);
    }
    public void IncreasePoints(int pointsToAdd)
    {
        gameManager.IncreasePoints(pointsToAdd);
    }

    // Update is called once per frame
    void Update()
    {
        if (ActivatorCreateEnemy == true)
        {
            ActualTimer = ActualTimer + Time.deltaTime;
            if (ActualTimer >= CreateEnemyTimer)
            {
                ActualTimer = 0;
                CreateEnemyShip();
            }
        }
    }
}
