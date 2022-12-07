using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class LoadData : MonoBehaviour
{   
    public Text UserNameBox;
    // Start is called before the first frame update
    void Start()
    {
        UserNameBox.text = PlayerPrefs.GetString("firstName")+ " " + PlayerPrefs.GetString("middleName")+ " " + PlayerPrefs.GetString("lastName");
    }

    public void clickReset()
    {
        PlayerPrefs.DeleteKey("username");
        SceneManager.LoadScene("firstScene");

    }
}
