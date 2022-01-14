using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CorrectAnswer : MonoBehaviour
{
    // Start is called before the first frame update
    void OnCollisionEnter2D(Collision2D col)
    {
        PlayerHealth player = col.gameObject.GetComponent<PlayerHealth>();
        if (player != null)
        {
            SceneManager.LoadScene("WinScene");
        }
    }
}
