using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

// Display Salmon Results
public class SalmonText : MonoBehaviour
{   
    public GameObject text = null;
    public int count_dangerous = 0;
    public int name_stage = 0;
    public string nameStage = "";
    public int count_death = 0;
    public string ClearFailure = "";

    public string StageName(int name_stage)
    {
        switch(name_stage){
            case 0:
                nameStage = "？";
                break;
            case 1:
                nameStage = "アラマキ";
                break;
            case 2:
                nameStage = "ムニ・エール";
                break;
            case 3:
                nameStage = "シャケナダム";
                break;
            case 4:
                nameStage = "ドン・ブラコ";
                break;
            case 5:
                nameStage = "すじこ";
                break;
            case 6:
                nameStage = "トキシラズ";
                break;
        }
        return nameStage;
    }


    // Start is called before the first frame update
    void Start()
    {
        count_dangerous = PlayerPrefs.GetInt("Dangerous", 0);
        name_stage = PlayerPrefs.GetInt("Stage", 0);
        count_death = PlayerPrefs.GetInt("Death", 0);
        ClearFailure = PlayerPrefs.GetString("ClearFailure", "");
    }

    // Update is called once per frame
    void Update()
    {   
        Text Results = text.GetComponent<Text>();
        Results.text = "キケンド:" + count_dangerous + "\n"
                    + "ステージ:" + StageName(name_stage) + "\n"
                    + "ケッカ:" + ClearFailure + "\n"
                    + "デス:" + count_death;

    }
}
