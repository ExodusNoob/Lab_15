using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManagerControl : MonoBehaviour
{
    public Text textPoints;
    public int points;
    public string ToLoadScene;
    // Start is called before the first frame update
    void Start()
    {
        if (textPoints != null)
        {
            IncreasePoints(0);
        }
    }
    public void IncreasePoints(int pointsToAdd)
    {
        points = points + pointsToAdd;
        textPoints.text = "Puntos: " + points;
    }
    public void ChangeScene()
    {
        SceneManager.LoadScene(ToLoadScene);
        //if (Input.GetKeyDown(KeyCode.Q))
        //{
          //  SceneManager.LoadScene(ToLoadScene); ;-;
        //}
    }
}
