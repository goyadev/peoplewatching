using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Yarn.Unity;


public class DialogueListViewSound : MonoBehaviour
{
    public AudioSource continueSound;

    [YarnCommand("playContinue")]
    void PlayContinue()
    {
        Debug.Log("PlayContinue");
        continueSound.Play();
    }
}
