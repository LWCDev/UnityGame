using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
public class TimeChanger : MonoBehaviour
{
    public float TimeMultiplier = 1;
    GameObject Button;
    public bool clickerDisable;
    //public void OnPointerClick(PointerEventData eventData)
    // {
    //    
    //    TimeMultiplier = 1f;
    //    print(TimeMultiplier);
    //    
    //}
    public void TimeFunc(float multiplier)
    {
        if (clickerDisable == false)
        {
            TimeMultiplier = multiplier;
            print("TimeMult " + TimeMultiplier + " mult : " + multiplier);
        }
    }
}
