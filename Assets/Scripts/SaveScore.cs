using System.Collections;
using System.Collections.Generic;
using Firebase.Sample.Database;
using UnityEngine;
using UnityEngine.UI;

public class SaveScore : MonoBehaviour
{
    private DBHandler dbManager;
    private InputField Email, Score;

    public void RegisterScore() {

        dbManager = GameObject.Find("ScoreManager").GetComponent<DBHandler>();
        Email = GameObject.Find("EmailInput").GetComponent<InputField>();
        Score = GameObject.Find("ScoreInput").GetComponent<InputField>();
        dbManager.email = Email.text;
        dbManager.score = System.Convert.ToInt32(Score.text);

        dbManager.AddScore();
    }
}
