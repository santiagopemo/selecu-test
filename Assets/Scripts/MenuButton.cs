using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MenuButton : MonoBehaviour
{
    private Button button;

    private void Awake()
    {
        this.button = GetComponent<Button>();
    }
    // Start is called before the first frame update
    void Start()
    {
        button.onClick.AddListener(GoToGameScene);
    }
    void GoToGameScene()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
