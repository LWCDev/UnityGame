using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class ResearchProjectAdder : MonoBehaviour
{
    public string[] PossibleResearchProjects;
    public string[] AvailableResearchProjects;
    public string[] CompletedResearchProjects;
    public int[] ResearchBaseTimes;
    public GameObject DefaultText;
    public GameObject Viewporter;
    //public GameObject ViewPorter;
    Transform ViewPorter;
    Text textData;
    public GameObject Image;
    GameObject Scroll;
    // Use this for initialization
    
    void Start()
    {
        PossibleResearchProjects = new string[] { "Gray-man Autopsy", "Gray-man Interrogation", "Viper Autopsy", "Viper Interrogation", "Mini-bot Wreck Breakdown" ,"Disc Wreck Breakdown", "Brute Assault Autopsy", "Brute Assault Interrogation", "Brute Berseerker Autopsy", "Commander Autopsy", "Commander Interrogation", "Overlord Autopsy", "Overlord Interrogation", "Laser Technology", "Alien Alloys", "Plasma Technology", "Alien Elements", "Fusion Lance" };
        for (int i = 0; i < PossibleResearchProjects.Length; i++)
        {

            string newItem = PossibleResearchProjects[i];
            
            GameObject cloneObj;
            //DefaultText.transform.position = new Vector3(transform.position.x, -10, transform.position.z);
            float yLoc = DefaultText.transform.position.y - ((i-8) * 30);
            ViewPorter = Viewporter.GetComponent<Transform>();
            cloneObj = Instantiate(DefaultText);
            cloneObj.transform.SetParent(ViewPorter, false);
            float xLoc = DefaultText.transform.position.x + 150;
            cloneObj.transform.position = new Vector3(xLoc, yLoc, DefaultText.transform.position.z);
            cloneObj.transform.localScale = DefaultText.transform.localScale;
            textData = cloneObj.GetComponent<Text>();
            print(i);
            print(PossibleResearchProjects[i]);
            textData.text = PossibleResearchProjects[i] + "\n";
            //cloneObj = Instantiate(DefaultText);
            //cloneObj.transform.SetParent(ViewPorter, false);
            //cloneObj.transform.position = new Vector3(DefaultText.transform.position.x, yLoc, DefaultText.transform.position.z);
            //cloneObj.transform.localScale = DefaultText.transform.localScale;

            //Instantiate(DefaultText);
            //if (PossibleResearchProjects[i] == "NotUsed")
            //{
            //    //doesn't add to available projects
            //    AvailableProjects[i] = "";
            //}
            //print(AvailableProjects[i]);
        }
        
    }
    public void ManufactureUnlock(string Unlock)
    {
        string TextUnlock = Unlock;
        Transform Child;
        Text TextObject;
        Scroll = GameObject.Find("Scroll View");

        Child = Image.transform.GetChild(0);
        TextObject = Child.GetComponent<Text>();
        print(Child);
        TextObject.text = "You have unlocked: " + TextUnlock + " manufacture!";
        Image.transform.position = Scroll.transform.position;

    }
    public void ResearchTimers()
    {
        for(int i = 0; i < PossibleResearchProjects.Length; i++)
        {
            string CurrentArticle = PossibleResearchProjects[i];
            if (CurrentArticle.Contains("Interrogation") || CurrentArticle.Contains("Autopsy") || CurrentArticle.Contains("Breakdown"))
            {
                ResearchBaseTimes[i] = 5;
            }
            if (CurrentArticle.Contains("Laser"))
            {
                ResearchBaseTimes[i] = 15;
            }
            if (CurrentArticle.Contains("Plasma"))
            {
                ResearchBaseTimes[i] = 25;
            }
            if (CurrentArticle.Contains("Elements"))
            {
                ResearchBaseTimes[i] = 20;
            }
            if (CurrentArticle.Contains("Alloys"))
            {
                ResearchBaseTimes[i] = 10;
            }
            if (CurrentArticle.Contains("Fusion"))
            {
                ResearchBaseTimes[i] = 15;
                ManufactureUnlock("Fusion Lancer");
            }
        }
    }
    // Update is called once per frame
    void Update()
    {

    }
}

