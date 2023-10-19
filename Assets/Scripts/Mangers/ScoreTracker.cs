using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreTracker : MonoBehaviour
{
    [SerializeField] Text SCDisplay;
    internal static int Score;

    public void AddScore(int Points)
    {
        Score += Points;
        SCDisplay.text = $"Current Score: {Score}";
    }
}
