using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class KlaxonButtonHandler : MonoBehaviour
{
    private AudioSource audioSource;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        GetComponent<Button>().onClick.AddListener(PlayKlaxonSound);
    }

    void PlayKlaxonSound()
    {
        audioSource.Play();
    }
}
