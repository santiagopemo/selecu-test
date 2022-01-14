using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PllayMusic : MonoBehaviour
{
    public AudioSource audioSource;
    public AudioClip audioClip;
    private Button button;

    private void Awake()
    {
        this.button = GetComponent<Button>();
    }
    // Start is called before the first frame update
    void Start()
    {
        button.onClick.AddListener(PlayClip);
    }

    void PlayClip()
    {
        audioSource.clip = audioClip;
        audioSource.Play();
    }
}
