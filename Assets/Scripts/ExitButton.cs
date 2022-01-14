using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ExitButton : MonoBehaviour
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
        Application.Quit();
    }
}
