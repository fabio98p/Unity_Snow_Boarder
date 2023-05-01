using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CrachDetector : MonoBehaviour
{
    [SerializeField] float loadDelay = 0.5f;
    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Ground")
        {
            //Debug.Log("you crash");
            Invoke("ReloadScene", loadDelay);

        }
    }
    void ReloadScene()
    {
        SceneManager.LoadScene(0);
    }
}
