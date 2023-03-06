using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameTimer : MonoBehaviour
{
    [SerializeField] private float totalTimeSec;
    [SerializeField] private bool timerIsRunning = false;
    [SerializeField] private TextMeshProUGUI timerText;
    // Start is called before the first frame update
    void Start()
    {
        timerIsRunning = true;
    }

    // Update is called once per frame
    void Update()
    {
      if (timerIsRunning)
        {
            if (totalTimeSec > 0)
            {
                totalTimeSec -= Time.deltaTime;
                DisplayTime(totalTimeSec);
            }
            else
            {
                Debug.Log("Time has run out!");
                totalTimeSec = 0;
                timerIsRunning = false;
            }
        }  
    }

    void DisplayTime(float timeToDisplay)
    {
        timeToDisplay += 1;
        float minutes = Mathf.FloorToInt(timeToDisplay / 60); 
        float seconds = Mathf.FloorToInt(timeToDisplay % 60);
        timerText.text = string.Format("{0:00}:{1:00}", minutes, seconds);
    }

}
