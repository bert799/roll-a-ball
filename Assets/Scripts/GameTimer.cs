using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

// adaptado do seguinte site: https://gamedevbeginner.com/how-to-make-countdown-timer-in-unity-minutes-seconds/

public class GameTimer : MonoBehaviour
{
    [SerializeField] private float totalTimeSec;
    [SerializeField] private bool timerIsRunning = false;
    [SerializeField] private TextMeshProUGUI timerText;
    [SerializeField] private GameObject countTextObject;
	[SerializeField] private GameObject TimerTextObject;
    [SerializeField] private GameObject gameOverScreen;
    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 1;
        timerIsRunning = true;
        gameOverScreen.SetActive(false);
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
                gameOverScreen.SetActive(true);
                TimerTextObject.SetActive(false);
                countTextObject.SetActive(false);
                Time.timeScale = 0;
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
