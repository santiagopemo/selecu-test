using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{
    public new Collider2D collider { get; private set; }
    public Movement movement { get; private set; }
    public Renderer rigthArrow, leftArrow, upArrow, downArrow;
    private Color pressedColor = new Color(1f, 1f, 1f, 1.8f);
    private Color unpressedColor = new Color(1f, 1f, 1f, 0.6f);

    private void Awake()
    {
        this.collider = GetComponent<Collider2D>();
        this.movement = GetComponent<Movement>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.RightArrow))
        {
            this.MoveRight();
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            this.MoveLeft();
        }
        if (Input.GetKey(KeyCode.UpArrow))
        {
            this.MoveUp();
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            this.MoveDown();
        }

    }

    public void MoveRight()
    {
        this.movement.SetDirection(Vector2.right);
        this.rigthArrow.material.color = pressedColor;
        this.leftArrow.material.color = this.upArrow.material.color = this.downArrow.material.color = unpressedColor;
    }

    public void MoveLeft()
    {
        this.movement.SetDirection(Vector2.left);
        this.leftArrow.material.color = pressedColor;
        this.rigthArrow.material.color = this.upArrow.material.color = this.downArrow.material.color = unpressedColor;
    }

    public void MoveUp()
    {
        this.movement.SetDirection(Vector2.up);
        this.upArrow.material.color = pressedColor;
        this.rigthArrow.material.color = this.leftArrow.material.color = this.downArrow.material.color = unpressedColor;
    }

    public void MoveDown()
    {
        this.movement.SetDirection(Vector2.down);
        this.downArrow.material.color = pressedColor;
        this.rigthArrow.material.color = this.leftArrow.material.color = this.upArrow.material.color = unpressedColor;
    }
}
