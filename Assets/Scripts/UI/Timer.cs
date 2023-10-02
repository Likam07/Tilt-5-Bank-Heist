using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour
{
    public float timeRemaining = 10;
    public bool timerIsRunning = false;
    public TMP_Text TimerSecondsText;
    public UnityEvent onTimerCompleted;
    public UnityEvent TimerStoppedSoPlayerMovementStops;
    
    
    private PlayerMovement _playerMovement;
    

    
    private void Start()
    {
        timerIsRunning = true;
        _playerMovement = GetComponent<PlayerMovement>();                           

    }
    void Update()
    {
        if (timeRemaining > 0)
        {
            timeRemaining -= Time.deltaTime;
        }
        

        else
        {
            timerIsRunning = false;
            timeRemaining = 0;
            onTimerCompleted?.Invoke();
            TimerStoppedSoPlayerMovementStops?.Invoke();
            
            //SceneManager.LoadScene(SceneManager.GetActiveScene().name);

        }
        
       
        
        float sec=Mathf.FloorToInt(timeRemaining%60);
        TimerSecondsText.text="Timer: "+ sec.ToString();

        
    }

    

   
}
