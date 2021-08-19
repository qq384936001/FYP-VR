using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AED_Button_Effect : MonoBehaviour
{
    public AudioClip AED_Turn_Effect;
    public AudioClip AED_Help_Effect;
    public AudioClip AED_Stock_Effect;
    public AudioClip AED_After_Stock_Effect;
    public bool stocked = false;
    public bool turned = false;
    public bool readyToStock = false;
    public int turnedOn = 0;
    AudioSource audioSource;

    private void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    private void Update()
    {
        if (turned && turnedOn == 0) {
            turnOnAED();
            turnedOn++;
        }

        //if the player stick 2 pad, show the next audio and show thw stock button
        if (check_pad_is_correct.PADNumber == 4 && !readyToStock)
        {
            readyToStock = true;
        }
        else if (check_pad_is_correct.PADNumber == 4 && readyToStock)
        {
            afterStickThePAD();
            check_pad_is_correct.PADNumber = 5;
        }
        

        //if the stock is done, call the next audio
        if (stocked && turnedOn==1) {
            afterStock();
            turnedOn++;
        }
    }

    public void turnOnAED()
    {
        Debug.Log("I turned on you");
        audioSource.PlayOneShot(AED_Turn_Effect);
        audioSource.PlayOneShot(AED_Help_Effect);
        //show the pads and the position
    }

    public void afterStickThePAD() {
        audioSource.PlayOneShot(AED_Stock_Effect);
        //
    }

    public void afterStock() {
        audioSource.PlayOneShot(AED_After_Stock_Effect);
    }



    //player press turned button


    //機: 立即.......  , spawn pad x 2  ,show stick position

    //解衣物

    //衣服setactive = false

    //提示貼pad 

    //if pad = 4, said leave patient >>分析中 

    //機: leave patient, ready to stock 

    //player press stock 

    //stock , 機: finish stock 

    //player keep to do CPR, after 5 around, will call player and computer to leave patient 



    //player >>take AED >> press button >> take off patient>> stick pad>> leave patient>> press stock>>wait 5 round>> press stock
    //AED                   turn on >> pad set active>>         check pad number            
    //patient   fall down       show pad position    cloth off                             random 1-2 time will car come
    //computer  keep doing CPR                                             leave patient               CPR again 
    

}
