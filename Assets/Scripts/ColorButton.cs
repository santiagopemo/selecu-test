using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ColorButton : MonoBehaviour
{
    public SpriteRenderer playerBody;
    private Color buttonColor;
    private Button button;

    private void Awake()
    {
        this.buttonColor = GetComponent<Image>().color;
        this.button = GetComponent<Button>();
        print(buttonColor);
        print(playerBody.material.color);
    }
    // Start is called before the first frame update
    void Start()
    {
        button.onClick.AddListener(ChangeBodyColor);
    }

    public void ChangeBodyColor()
    {
        playerBody.material.SetColor("_Color", buttonColor);
        print(playerBody.material.color);
    }
}
