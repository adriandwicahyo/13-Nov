using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AniationFunction : MonoBehaviour
{

    [SerializeField] MenuButtonController menuButtonController;

    // Update is called once per frame
    void PlaySound(AudioClip whichSound)
    {
        menuButtonController.audioSource.PlayOneShot(whichSound);
    }
}
