using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StopButton : MonoBehaviour
{
    public AudioSource audioSource;
    private Button button;

    private void Awake()
    {
        this.button = GetComponent<Button>();
    }
    // Start is called before the first frame update
    void Start()
    {
        button.onClick.AddListener(StopClip);
    }

    void StopClip()
    {
        audioSource.Stop();
    }
}
