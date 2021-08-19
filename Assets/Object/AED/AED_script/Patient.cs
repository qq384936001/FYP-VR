using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Patient : MonoBehaviour
{
    public Animator animator;
    public GameObject cloth;

    private void Start()
    {
        animator = GetComponent<Animator>();
    }

    //

    //cloth anim
    public void OnDisable()
    {
        cloth.gameObject.SetActive(false);
    }
    //if the player click the cloth, the cloth will disable 

}
