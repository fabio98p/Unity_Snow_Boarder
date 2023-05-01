using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CrachDetector : MonoBehaviour
{
    [SerializeField] float loadDelay = 0.5f;
    [SerializeField] ParticleSystem crashEffect;
    [SerializeField] AudioClip crachSFX;

    bool hasCrashed = false;

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Ground" && !hasCrashed)
        {
            FindObjectOfType<PlayerController>().DisableControl();
            crashEffect.Play();
            GetComponent<AudioSource>().PlayOneShot(crachSFX);
            Invoke("ReloadScene", loadDelay);
            hasCrashed = true;
        }
    }
    void ReloadScene()
    {
        SceneManager.LoadScene(0);
    }
}
