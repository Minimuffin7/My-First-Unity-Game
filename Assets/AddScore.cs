using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddScore : MonoBehaviour
{
    public SoundManager instance;

    public AudioClip scoreSound;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Score.score++;
        instance.PlaySound(scoreSound);
    }
}