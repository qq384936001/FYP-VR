using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FindTheAED : MonoBehaviour
{
    bool putted = false;
    //GameObject[] game = new GameObject[7];
    public GameObject object1;
    public GameObject object2;
    public GameObject object3;
    public GameObject object4;
    public GameObject object5;
    public GameObject object6;
    public GameObject object7;
    public GameObject object8;
    public GameObject object9;
    // Start is called before the first frame update
    void Start()
    {

        object1.SetActive(false);
        object2.SetActive(false);
        object3.SetActive(false);
        object4.SetActive(false);
        object5.SetActive(false);
        object6.SetActive(false);
        object7.SetActive(false);
        object8.SetActive(false);
        object9.SetActive(false);
        Debug.Log("disactive la la la");

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("AED") && !putted)
        {
            other.gameObject.transform.position = gameObject.transform.position;
            //other.gameObject.GetComponent<Rigidbody>().isKinematic = true;
            Debug.Log("Moved");
            object1.SetActive(true);
            object2.SetActive(true);
            object3.SetActive(true);
            object4.SetActive(true);
            object5.SetActive(true);
            object6.SetActive(true);
            object7.SetActive(true);
            object8.SetActive(true);
            object9.SetActive(true);
            putted = true;
            gameObject.SetActive(false);
        }
    }


    //if the object.tag = AED 
    /*
     position  = position 
    open the menu, show the button 
    
    
     
     */
}
