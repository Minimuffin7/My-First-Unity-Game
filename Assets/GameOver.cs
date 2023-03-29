using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOver : MonoBehaviour
{
    void Start()
    {
        // Hide the canvas at the start of the game
        gameObject.GetComponent<CanvasGroup>().alpha = 0;
    }

    void OnPlayerDeath()
    {
        // Show the canvas when the player dies
        gameObject.GetComponent<CanvasGroup>().alpha = 1;
    }
}