using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FinishLine : MonoBehaviour
{
    [SerializeField] float loadDelay = 0.5f;
    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
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
