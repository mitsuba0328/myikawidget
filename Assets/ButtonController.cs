using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonController : MonoBehaviour
{
    public int count_death = 0;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnClickSalmon()
    {
        Debug.Log("Go Salmon Scene");
        SceneManager.LoadScene("SalmonTop");
    }

    public void OnClickRoby()
    {
        Debug.Log("Go Roby Scene");
        SceneManager.LoadScene("Roby");
    }

    public void OnClickBackButton()
    {
        Debug.Log("Back to Top");
        SceneManager.LoadScene("TitleScene");
    }

    public void OnClickSalmonRegister()
    {
        SceneManager.LoadScene("SalmonRegister");
    }

    public void OnClickSalmonEnter()
    {
        PlayerPrefs.SetInt("Death", count_death);
        PlayerPrefs.Save();
    }
}
