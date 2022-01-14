using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Niantic.ARDKExamples.Helpers;

public class SoundManager : MonoBehaviour
{
    [SerializeField] private AudioSource SoundA;

    private void OnEnable()
    {
        ARHitTester.LetterSpawn += PlaySoundA;
    }

    private void OnDisable()
    {
        ARHitTester.LetterSpawn -= PlaySoundA;
    }

    private void PlaySoundA()
    {
        SoundA.Play();
    }

}
