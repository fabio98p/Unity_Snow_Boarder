using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FinishLine : MonoBehaviour
{
    [SerializeField] float loadDelay = 0.5f;
    [SerializeField] ParticleSystem finishEffect;

    bool gameEnd = false;

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player" && !gameEnd)
        {
            finishEffect.Play();
            GetComponent<AudioSource>().Play();
            Invoke("ReloadScene", loadDelay);
            gameEnd = true;
        }
    }
    void ReloadScene()
    {
        SceneManager.LoadScene(0);
    }
}
