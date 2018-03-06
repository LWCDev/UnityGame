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
    // static System.Random rnd = new System.Random();
    // Update is called once per frame
    public static class IntUtil
    {
        private static System.Random random;

        private static void Init()
        {
            if (random == null) random = new System.Random();
        }

        public static int Random(int min, int max)
        {
            Init();
            return random.Next(min, max);
        }
    }
    public void Update () {
        
        Day = TimeRecorder.days;
        Hours = TimeRecorder.hours;
        Minutes = TimeRecorder.minutes;
        //print(Day);
        //print(Hours);
        //print(Minutes);
        
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

                    int chance = IntUtil.Random(1, 10);
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
            //UFOImage.transform.localScale = new Vector3(1, 1, 1);
            int RandX = IntUtil.Random(-480, 170);
            int RandY = IntUtil.Random(-155, 155);
            //print(RandX);
            //print(RandY);
            float xLoc = RandX;
            float yLoc = RandY;
            UFOImage.transform.localPosition = new Vector3(xLoc,yLoc,0);
            
        }
        else
        {
            
            //int RandX = Random.Range(-480, 170);
            //int RandY = Random.Range(-155, 155);
            float xLoc;
            float yLoc;
            string Country;
            int RandC = IntUtil.Random(0, 11);
            print("This is RandC " +RandC);
            if (RandC == 1)
            {
                //China
                xLoc = 41;
                yLoc = 66;
                Country = "China";
                AbductionImage.transform.localPosition = new Vector3(xLoc, yLoc, 0f);
                TextObject.text = "Alien activtity detected! Abduction in progress in " + Country + "!" ;
            }
            if (RandC == 2)
            {
                //UK
                xLoc = -160;
                yLoc = 101;
                Country = "UK";
                AbductionImage.transform.localPosition = new Vector3(xLoc, yLoc, 0f);
                TextObject.text = "Alien activtity detected! Abduction in progress in " + Country + "!";
            }
            if (RandC == 3)
            {
                //Australia
                xLoc = 94;
                yLoc = -37;
                Country = "Australia";
                AbductionImage.transform.localPosition = new Vector3(xLoc, yLoc, 0f);
                TextObject.text = "Alien activtity detected! Abduction in progress in " + Country + "!";
            }
            if (RandC == 4)
            {
                //USA
                xLoc = -332;
                yLoc = 72;
                Country = "USA";
                AbductionImage.transform.localPosition = new Vector3(xLoc, yLoc, 0f);
                TextObject.text = "Alien activtity detected! Abduction in progress in " + Country + "!";
            }
            if (RandC == 5)
            {
                //Canada
                xLoc = -361;
                yLoc = 108;
                Country = "Canada";
                AbductionImage.transform.localPosition = new Vector3(xLoc, yLoc, 0f);
                TextObject.text = "Alien activtity detected! Abduction in progress in " + Country + "!";
            }
            if (RandC == 6)
            {
                //Germany
                xLoc = -136;
                yLoc = 95;
                Country = "Germany";
                AbductionImage.transform.localPosition = new Vector3(xLoc, yLoc, 0f);
                TextObject.text = "Alien activtity detected! Abduction in progress in " + Country + "!";
            }
            if (RandC == 7)
            {
                //France
                xLoc = -152;
                yLoc = 87;
                Country = "France";
                AbductionImage.transform.localPosition = new Vector3(xLoc, yLoc, 0f);
                TextObject.text = "Alien activtity detected! Abduction in progress in " + Country + "!";
            }
            if (RandC == 8)
            {
                //Mexico
                xLoc = -347;
                yLoc = 48;
                Country = "Mexico";
                AbductionImage.transform.localPosition = new Vector3(xLoc, yLoc, 0f);
                TextObject.text = "Alien activtity detected! Abduction in progress in " + Country + "!";
            }
            if (RandC == 9)
            {
                //Japan
                xLoc = 105;
                yLoc = 70;
                Country = "Japan";
                AbductionImage.transform.localPosition = new Vector3(xLoc, yLoc, 0f);
                TextObject.text = "Alien activtity detected! Abduction in progress in " + Country + "!";
            }
            if (RandC == 10)
            {
                //South Korea
                xLoc = 85;
                yLoc = 73;
                Country = "South Korea";
                AbductionImage.transform.localPosition = new Vector3(xLoc, yLoc, 0f);
                TextObject.text = "Alien activtity detected! Abduction in progress in " + Country + "!";
            }
            if (RandC == 11)
            {
                //Italy
                xLoc = -133;
                yLoc = 80;
                Country = "Italy";
                AbductionImage.transform.localPosition = new Vector3(xLoc, yLoc, 0f);
                TextObject.text = "Alien activtity detected! Abduction in progress in " + Country + "!";
            }
            if (RandC == 0)
            {
                //Egypt
                xLoc = -100;
                yLoc = 51;
                Country = "Egypt";
                AbductionImage.transform.localPosition = new Vector3(xLoc, yLoc, 0f);
                TextObject.text = "Alien activtity detected! Abduction in progress in " + Country + "!";
            }
            //print(RandX);
            //print(RandY);
            //float xLoc = RandX;
            //float yLoc = RandY;
            //AbductionImage.transform.localScale = new Vector3(1, 1, 1);

            //Transform Canvas1 = Camera.transform.GetChild(0);
            //AbductionImage.transform.parent = Canvas1.transform;
            
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
