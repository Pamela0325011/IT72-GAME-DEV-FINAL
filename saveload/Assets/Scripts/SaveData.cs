using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SaveData : MonoBehaviour
{
    public InputField FirstName;
    public InputField MiddleName;
    public InputField LastName;

    public void clickSave()
    {
        PlayerPrefs.SetString("firstName", FirstName.text);
        PlayerPrefs.SetString("middleName", MiddleName.text);
        PlayerPrefs.SetString("lastName", LastName.text);
        SceneManager.LoadScene("secondScene");
    }
}
