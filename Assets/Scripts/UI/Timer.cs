using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour
{
    public float timeRemaining = 10;
    public bool timerIsRunning = false;
    public TMP_Text TimerSecondsText;
    
    

    // Update is called once per frame
    
    private void Start()
    {
        timerIsRunning = true;
        
    }
    void Update()
    {
        if (timeRemaining > 0)
        {
            timeRemaining -= Time.deltaTime;
        }

        else
        {
            timeRemaining = 0;
            timerIsRunning = false;
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
        
        float sec=Mathf.FloorToInt(timeRemaining%60);
        TimerSecondsText.text="Timer: "+ sec.ToString();

        
    }

   
}
