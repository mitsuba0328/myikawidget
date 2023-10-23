using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

// Regist Salmon Results
// Attached to BackGround
public class SalmonRegister : MonoBehaviour
{
// ここにdropdown
    InputField inputDangerous;
    Dropdown inputStage;    
    InputField inputDeath;


    // Start is called before the first frame update
    public void Start()
    {
        inputDangerous = GameObject.Find("Dangerous").GetComponent<InputField>();
        inputStage = GameObject.Find("Stage").GetComponent<Dropdown>();
        inputDeath = GameObject.Find("Death").GetComponent<InputField>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void OnClickRegist()
    {   
        int count_dangerous = int.Parse(inputDangerous.text);
        PlayerPrefs.SetInt("Dangerous", count_dangerous);
        int name_stage = inputStage.value;
        PlayerPrefs.SetInt("Stage", name_stage);
        int count_death = int.Parse(inputDeath.text);
        PlayerPrefs.SetInt("Death", count_death);



        PlayerPrefs.Save();
    }
}
