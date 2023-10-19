using System.Collections;
using System.Collections.Generic;
using System.Xml.Serialization;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private float speed;
    [SerializeField] private GameObject[] candies;
    [SerializeField] private GameObject GameOver;
 
    private int count;
    private Vector2 moveDir;
    private float xpos;
    private Vector2 Spawnpoint;
    private float timer;

    private void Start()
    {
        InputManager.Init(myPlayer: this);
        InputManager.GameMode();
    }
    private void Update()
    {
        transform.position += transform.rotation * (speed * Time.deltaTime * moveDir);
        int spawntime = Random.Range(1, 4);
        if (timer >= spawntime)
        {
            CandySpawnpoint();
            PickCandy();
            timer = 0;
        }
        else
        {
            timer += Time.deltaTime;
        }
    }
    public void SetMovementDirection(Vector2 newDirection)
    {
        moveDir = newDirection;
    }
    private void CandySpawnpoint()
    {
        xpos = Random.Range(-5f, 5f);
        Spawnpoint = new Vector2(xpos, 4);
    }
    private void PickCandy()
    {
        int temp = Random.Range(1, 100);
        if (temp >= 1 && temp <= 5)
        {
            Instantiate(candies[0], Spawnpoint, Quaternion.identity);
        }
        else if (temp >= 6 && temp <= 15)
        {
            Instantiate(candies[5], Spawnpoint, Quaternion.identity);
        }
        else if (temp >= 16 && temp <= 30)
        {
            Instantiate(candies[4], Spawnpoint, Quaternion.identity);
        }
        else if (temp >= 31 && temp <= 50)
        {
            Instantiate(candies[3], Spawnpoint, Quaternion.identity);
        }
        else if (temp >= 51 && temp <= 75)
        {
            Instantiate(candies[2], Spawnpoint, Quaternion.identity);
        }
        else if (temp >= 76 && temp <= 100)
        {
            Instantiate(candies[1], Spawnpoint, Quaternion.identity);
        }
    }
    public void CheckSpawnedAmount()
    {
        count++;
        if (count >= 15)
        {
            GameOver.SetActive(true);
            Time.timeScale = 0f;
        }
    }
}
