using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Menu : MonoBehaviour
{
    [SerializeField] private ScoreTracker scoreTracker;
    [SerializeField] private Text GOtxt;
    [SerializeField] private GameObject GO;
    int finalscore;

    private void Update()
    {
        finalscore = ScoreTracker.Score;
        if (finalscore <= 15)
        {
            GOtxt.text = $"Score:{finalscore} Sadness :(";
        }
        else if (finalscore > 15 && finalscore < 35)
        {
            GOtxt.text = $"Score:{finalscore} Sugar Rush";
        }
        else if (finalscore > 35 && finalscore < 50)
        {
            GOtxt.text = $"Score:{finalscore} Halloween";
        }
        else if (finalscore > 50)
        {
            GOtxt.text = $"Score:{finalscore} Candy Craze";
        }
    }
    public void Restart()
    {
        Time.timeScale = 1f;
        GO.SetActive(false);
        string currentSceneName = SceneManager.GetActiveScene().name;
        SceneManager.LoadScene(currentSceneName);
    }
}
