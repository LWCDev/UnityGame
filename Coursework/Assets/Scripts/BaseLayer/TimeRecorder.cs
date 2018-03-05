using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class TimeRecorder : MonoBehaviour {

    public GameObject textbox;
    public GameObject textbox2;
    public GameObject Neg10Mult;
    public GameObject Neg4Mult;
    public GameObject Neg2Mult;
    public GameObject DefMult;
    public GameObject Pos10Mult;
    public GameObject Pos4Mult;
    public GameObject PosMult;
    public GameObject Camera;
    Text DateText;
    Text MultText;
    string Timer;
    string Dayer;
    public static string Monther;
    string Yearer;
    string ExampleText;
    string MultiplierText;
    public static int hours;
    public static int minutes;
    float seconds;
    public static int days;
    string NdTh = "st";
    float timeMulti;
    public TimeChanger OtherScript;
    public MissionMaker AlsoScript;
    //int[] Ths = { 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 24, 25, 26, 27, 28, 29, 30 };
    //int[] Rds = { 3, 23 };
    //int[] Nds = { 2, 22 };
    //int[] Sts = { 1, 21, 31 };
    int years;
    string[] monthList = { "January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December" };
    int monthIndex;
    // Use this for initialization
    void Start () {
        years = 2020;
        days = 1;
        hours = 0;
        seconds = 0f;
        minutes = 0;
        monthIndex = 3;
        Timer = hours.ToString() + ":" + minutes.ToString() + ";" + seconds.ToString();
        
        Dayer = days.ToString() + NdTh;
        Monther = monthList[monthIndex] ;
        Yearer = years.ToString();
        DateText = textbox.GetComponent<Text>();
        MultText = textbox2.GetComponent<Text>();
        ExampleText = "TIME: "+Timer+ "\nDAY: " +Dayer+ "\nMONTH: " + Monther +"\nYEAR: "+ Yearer;
        MultiplierText = "Speed up/Slow down: 1x";
        MultText.text = MultiplierText;
        DateText.text = ExampleText;
        OtherScript = Camera.GetComponent<TimeChanger>();
        //AlsoScript = Camera.GetComponent<MissionMaker>();
        timeMulti = 1;

        //print(DateText.text);
        
        
    }
    //public class ClickAction : MonoBehaviour, IPointerClickHandler
    //{
    //    public void OnPointerClick(PointerEventData eventData)
    //    {
    //        print("Hello");
    //    }
    //}
    // Update is called once per frame

    void Update () {
        //float timeMulti = TimeChanger.TimeMultiplier;
        //print("This is the time multiplier: "+ timeMulti);
        
        TimeTrack(timeMulti);
        
        Timer = hours.ToString() + ":" + minutes.ToString() + ";" + seconds.ToString("N0");
        Dayer = days.ToString() + NdTh;
        Monther = monthList[monthIndex];
        Yearer = years.ToString();
        ExampleText = "TIME: " + Timer + "\nDAY: " + Dayer + "\nMONTH: " + Monther + "\nYEAR: " + Yearer;
        if (timeMulti > 10)
        {
            if (timeMulti == 3600)
            {
                MultiplierText = "Speed up/Slow down: 1 hour";
            }
            else if (timeMulti == 14400)
            {
                MultiplierText = "Speed up/Slow down: 4 hours";
            }
            else if (timeMulti == 3600 * 24)
            {
                MultiplierText = "Speed up/Slow down: 1 day";
            }
            
        }
        else
        {
            MultiplierText = "Speed up/Slow down: " + timeMulti.ToString() + "x";
        }
        MultText.text = MultiplierText;
        DateText.text = ExampleText;
        //print(ExampleText);
        //DateText.text = "Hello!";

        
        timeMulti = OtherScript.TimeMultiplier;
    }
    void TimeTrack(float multiplier)
    {
        if (multiplier == 2001)
        {
            hours = hours + 24;
            multiplier = 0;
            MultiplierText = "Speed up/Slow down: 1 day";

        }
        if (multiplier == 2000)
        {
            hours = hours + 4;
            MultiplierText = "Speed up/Slow down: 4 hours";
            //multiplier = 0;

        }
        seconds = seconds + multiplier*Time.deltaTime;
        //print("This is the multiplier being passed to function: " +multiplier);
        //print(Time.deltaTime);
        //print(seconds.ToString("N0")); 
        if (seconds >= 60){
            minutes = minutes + 1;
            seconds = 0f;
            //print(seconds);
            //print(minutes);
            //print(hours);
        }
        if (minutes >= 60)
        {
            hours = hours + 1;
            minutes = 0;
            //print(minutes);
            //AlsoScript.Update();

        }
        if (hours >= 24)
        {
            days = days + 1;
            hours = 0;
            //AlsoScript.counter = AlsoScript.counter + 1;
            //AlsoScript.Update();
        }
        if (days == 29)
        {
            if (monthList[monthIndex] == "February")
            {
                monthIndex = monthIndex + 1;
                //MissionMaker.Day = 1;
                //print("Day updated on other script!");
                //AlsoScript.Update();
                List<int> EmptyList = new List<int>();
                AlsoScript.FoundDays = EmptyList;
            }
            
        }
        if (days == 31)
        {
            if (monthList[monthIndex] == "September" || monthList[monthIndex] == "November" || monthList[monthIndex] == "April" ||monthList[monthIndex] == "June")
            {
                monthIndex = monthIndex + 1;
                days = 1;
                //AlsoScript.Update();
                // MissionMaker.Day = 1;
                //print("Day updated on other script!");
                List<int> EmptyList = new List<int>();
                AlsoScript.FoundDays = EmptyList;
            }
        }
        if (days == 32)
        {
            monthIndex = monthIndex + 1;
            days = 1;
            //AlsoScript.Update();
            //MissionMaker.Day = 1;
            //print("Day updated on other script!");
            List<int> EmptyList = new List<int>(); 
            AlsoScript.FoundDays = EmptyList;
        }
        if (monthIndex >= 11)
        {
            years = years + 1;
            monthIndex = 0;
            //AlsoScript.Update();
            //MissionMaker.Day = 1;
            //print("Day updated on other script!");
        }
        //int i = 0;
        if (days == 3 || days == 23)
        {
            NdTh = "rd";
        }
        else if (days == 2 || days == 22)
        {
            NdTh = "nd";
        }
        else if (days == 1 || days == 21 || days == 31)
        {
            NdTh = "st";
        }
        else
        {
            NdTh = "th";
        }
        //for (i = 0; i < 1; i++)
        //{
        //    if (Rds[i] == days)
        //    {
        //        NdTh = "rd";
        //        break;
        //    }
        //    else if (Nds[i] == days) {
        //        NdTh = "nd";
        //        break;
        //    }
        //int x = 0;    
        //for (x = 0; i < 2; x++)
        //    {
        //        print(days);
        //        if (Sts[x] == days) 
        //        {
        //            NdTh = "st";
        //            break;
        //        }
        //        else
        //       {
        //            NdTh = "th";
        //            print("Th activated");
        //        }
        //    }
        //}
    }
}
