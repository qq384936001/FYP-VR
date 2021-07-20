using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Johnson_move : MonoBehaviour
{
    // Start is called before the first frame update
    
    Rigidbody rb;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        
    }

    // Update is called once per frame
    void Update()
    {
        rb.transform.position += new Vector3(-1f * Time.deltaTime, 0, 0);
    }
}
