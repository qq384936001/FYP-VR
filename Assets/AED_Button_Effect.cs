using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AED_Button_Effect : MonoBehaviour
{
    public AudioClip AED_Turn_Effect;
    public AudioClip AED_Help_Effect;
    AudioSource audioSource;

    private void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }
    public void turnOnAED()
    {
        Debug.Log("I turned on you");
        audioSource.PlayOneShot(AED_Turn_Effect);
        audioSource.PlayOneShot(AED_Help_Effect);
    }
}
