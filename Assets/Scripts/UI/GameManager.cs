using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    [SerializeField] private GameObject loseText;
    
   // [SerializeField] private GameObject winText;

   private PlayerMovement _playerMovement;
   
   public UnityEvent StopTimer;
   
   public AudioClip _sirens;
   private AudioSource _audioSource;

   
   

   private void Start()
    {
       
        loseText.SetActive(false);
        _playerMovement = GetComponent<PlayerMovement>();
        _audioSource = GetComponent<AudioSource>();
        


    }

   

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.CompareTag("Obstacles"))
        {
           YouLose();
           StopTimer?.Invoke();
           _audioSource.clip = _sirens;
           _audioSource.Play();
           Debug.Log("I have made contact with an obstacle");
        }
    }

    void YouLose()
    {
        loseText.SetActive(true);
        _playerMovement.canMove = false;
    }
}
