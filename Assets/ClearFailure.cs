using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ClearFailure : MonoBehaviour
{
    GameObject ClearButton;
    GameObject FailureButton;
    // Start is called before the first frame update
    void Start()
    {
        ClearButton = GameObject.Find("Clear");
        FailureButton = GameObject.Find("Failure");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnClickClear()
    {
        PlayerPrefs.SetString("ClearFailure", "Clear!");
        PlayerPrefs.Save();
    }

    public void OnClickFailure()
    {
        PlayerPrefs.SetString("ClearFailure", "Failure...");
        PlayerPrefs.Save();
    }
}
