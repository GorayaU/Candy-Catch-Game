using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Candy : MonoBehaviour
{
    [SerializeField] private ScoreTracker tracker;
    [SerializeField] private Player player;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Ground")
        {
            Destroy(gameObject);
            player.CheckSpawnedAmount();
        }
        if (collision.gameObject.tag == "Player")
        {
            CheckTag();
            Destroy(gameObject);
            player.CheckSpawnedAmount();
        }
    }

    private void CheckTag()
    {
        if (gameObject.tag == "Orange Candy")
        {
            tracker.AddScore(2);
        }
        else if (gameObject.tag == "Red Candy")
        {
            tracker.AddScore(3);
        }
        else if (gameObject.tag == "Gray Candy")
        {
            tracker.AddScore(4);
        }
        else if (gameObject.tag == "Blue Candy")
        {
            tracker.AddScore(5);
        }
        else if (gameObject.tag == "Green Candy")
        {
            tracker.AddScore(6);
        }
        else if (gameObject.tag == "Yellow Candy")
        {
            tracker.AddScore(7);
        }
    }
}
