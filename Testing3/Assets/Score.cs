using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public static Text scoretext;
    public static int numberOfPeopleSaved;
    // Start is called before the first frame update
    void Start()
    {
        scoretext = GetComponent<Text>();
        numberOfPeopleSaved = PlayerPrefs.GetInt("ScoreData", numberOfPeopleSaved);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public static void addSavedPeople(int value) {
        numberOfPeopleSaved += value;
        PlayerPrefs.SetInt("ScoreData", numberOfPeopleSaved);
        PlayerPrefs.Save();
        scoretext.text = numberOfPeopleSaved.ToString();
    }
}
