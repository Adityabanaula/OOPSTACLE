using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CanvasUI : MonoBehaviour
{
    
    [SerializeField] private TMP_Text secondTimer;
    [SerializeField] private TMP_Text minuteTimer;

    // Update is called once per frame
    void Update()
    {

        float second = Time.timeSinceLevelLoad;
        float minute = second / 60f; 

        secondTimer.text = second.ToString("00");
        minuteTimer.text = minute.ToString("00");
        
    }
}
