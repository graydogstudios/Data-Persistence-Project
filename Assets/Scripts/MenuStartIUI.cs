using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
using UnityEngine.UI;

public class MenuStartIUI : MonoBehaviour
{ 
    public InputField enterPlayerName;
    
    public Text inputField;
    public void StartNew()
    {
       // Debug.Log(enterPlayerName.text);
        UpdatePlayerName();
        SceneManager.LoadScene(1);
    }


    public void SaveName()
    { 
    
    }
    public void SaveHighScore()

    {
        GameManager.Instance.SaveHighScore();
    }

    public void LoadHighScore()
    {
        GameManager.Instance.LoadHighScore();
        //ColorPicker.SelectColor(GameManager.Instance.TeamColor);

    }

    public void UpdatePlayerName()
    {
        GameManager.Instance.playerName = enterPlayerName.text;
    }
     

}
