using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaveHim : MonoBehaviour
{
    // Start is called before the first frame update
    public float fuseTime;
    void Start()
    {
        //Invoke("Explode", fuseTime);
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    private void OnTriggerEnter(Collider other)
    {
        if (other.tag=="AED") {
            Debug.Log("I save you 2");
            Score.addSavedPeople(1);
            Explode();
        }
    }

    void Explode() {
        ParticleSystem exp = GetComponent<ParticleSystem>();
        exp.Play();
        
    }
}
