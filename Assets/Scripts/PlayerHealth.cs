using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayerHealth : MonoBehaviour
{
    public TextMeshProUGUI healthText;
    private int lives = 3;
    private Movement movement;

    // Start is called before the first frame update
    private void Awake()
    {
        movement = GetComponent<Movement>();
    }
    void Start()
    {
        healthText.text = "X " + lives;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void TakeDamage()
    {
        this.lives--;
        if (this.lives == 0)
            SceneManager.LoadScene("LoseScene");
        healthText.text = "X " + lives;
        movement.ResetState();

    }
}
