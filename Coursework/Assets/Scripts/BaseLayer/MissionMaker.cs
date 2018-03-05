using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class MissionMaker : MonoBehaviour {

	// Use this for initialization
	void Start () {
        
	}
    public static int Day;
    public static int Hours;
    public static int Minutes;
    public GameObject Image;
    Transform imageLoc;
    public GameObject Camera;
    TimeChanger OtherScript;
    public bool accessed;
    public GameObject UFOImage;
    public GameObject AbductionImage;
    //int FlagForFound = 0;
    int counter;
    public List<int> FoundDays;
    // Update is called once per frame
    public void Update () {
        
        Day = TimeRecorder.days;
        Hours = TimeRecorder.hours;
        Minutes = TimeRecorder.minutes;
        //print(Day);
        //print(Hours);
        //print(Minutes);
        int RandX = Random.Range(-480, 170);
        int RandY = Random.Range(-155, 155);
        print(RandX);
        print(RandY);
        float xLoc = RandX;
        float yLoc = RandY;
        //UFOImage.transform.position = new Vector3(xLoc, yLoc, 0);
        //AbductionImage.transform.position = new Vector3(xLoc, yLoc, 0);
        //UFOImage.transform.position = new Vector3(0, 0, 0);
        if (accessed == false)
        {
            if (FoundDays.Contains(Day) == false)
            {
                if (Day == 2)
                {
                    MissionGenerator("Monthly");
                    MissionAlerter("Monthly");
                    FoundDays.Add(Day);

                }
                if (Day == 5 || Day == 10 || Day == 15 || Day == 20 || Day == 25)
                {

                    int chance = Random.Range(1, 10);
                    print(chance);
                    if (chance <= 4)
                    
                    {
                        MissionGenerator("Randomed");
                        MissionAlerter("Random");
                        print("It randomed a mission!");


                    }
                    if (chance == 6)
                    {
                        MissionGenerator("UFO");
                        MissionAlerter("UFO");
                        print("UFO missioN!");
                        
                            
                    }
                    FoundDays.Add(Day);
                }
                
            }
            

        }
	}
    public void MissionGenerator(string Type)
    {
        if(Type == "Monthly")
        {
            print("Monthly!");
            //Xvalues are = -483 to 170
            //YValues are = 155 to -155
            
        }
        if(Type == "Randomed")
        {
            print("Randomed!");
            
        }
        if(Type == "UFO")
        {
            print("UFO!");
            
        }
        if(Type == "Base")
        {

        }
    }
    public void MissionAlerter(string Mission)
    {

        Text TextObject;
        //Image = GameObject.Find("AlertBackgroundImage1");


        imageLoc = Image.transform.GetChild(0);
        TextObject = imageLoc.GetComponent<Text>();
        print(imageLoc);
        
        if(Mission == "UFO")
        {
            TextObject.text = "Alien activity detected! A UFO has been spotted!";
            //int RandX = Random.Range(-480, 170);
            //int RandY = Random.Range(-155, 155);
            //print(RandX);
            //print(RandY);
            UFOImage.transform.localScale = new Vector3(1, 1, 1);
            UFOImage.transform.position = new Vector3(0,0,0);
            
        }
        else
        {
            TextObject.text = "Alien activtity detected! Abduction in progress!";
            //int RandX = Random.Range(-480, 170);
            //int RandY = Random.Range(-155, 155);
            //print(RandX);
            //print(RandY);
            AbductionImage.transform.localScale = new Vector3(1, 1, 1);
            AbductionImage.transform.position = new Vector3(0, 0, 0);
            
        }
        Camera cam = Camera.GetComponent<Camera>();
        Image.transform.position = cam.ViewportToWorldPoint(new Vector3(0.5f, 0.5f, 10f));
        Image.transform.parent = Camera.transform.GetChild(0);
        OtherScript = Camera.GetComponent<TimeChanger>();
        OtherScript.TimeFunc(0);
        accessed = true;
        OtherScript.clickerDisable = true;
    }
}
