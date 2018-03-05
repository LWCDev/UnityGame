using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class ManufactureProjectAdder : MonoBehaviour {
    public string[] PossibleProjects;
    public List<string> AvailableProjects = new List<string>();
    public GameObject DefaultText;
    public GameObject Viewporter;
    //public GameObject ViewPorter;
    Transform ViewPorter;
    Text textData;
    
	// Use this for initialization
	void Start () {
        PossibleProjects = new string[16] { "Kevlar", "Sleep Rocket", "Rocket", "Laser Rifle", "Laser Pistol", "Laser Shotgun", "Plasma Pistol", "Plasma Rifle", "Alloy Cannon", "Hawk Missile", "Laser Missile", "EMP Cannon", "Plasma Cannon", "Fusion Lancer", "Alloy Armour", "Titan Armour" };
        for (int i = 0; i < PossibleProjects.Length; i++)
        {

            string newItem = PossibleProjects[i];
            AvailableProjects.Add(newItem);
            GameObject cloneObj;
            //DefaultText.transform.position = new Vector3(transform.position.x, -10, transform.position.z);
            float yLoc = DefaultText.transform.position.y - ((i) * 45);
            ViewPorter = Viewporter.GetComponent<Transform>();
            //DefaultText.transform.position.x = ViewPorter.transform.position.x;
            cloneObj = Instantiate(DefaultText);
            cloneObj.transform.SetParent(ViewPorter, true);
            cloneObj.transform.position = new Vector3(0, yLoc, 0);
            cloneObj.transform.localScale = ViewPorter.transform.localScale;
            textData = cloneObj.GetComponent<Text>();
            print(i);
            print(PossibleProjects[i]);
            textData.text = PossibleProjects[i] + "\n";
            cloneObj.transform.position = new Vector3(DefaultText.transform.position.x, yLoc, 0);
            //cloneObj = Instantiate(DefaultText);
            //cloneObj.transform.SetParent(ViewPorter, false);
            //cloneObj.transform.position = new Vector3(DefaultText.transform.position.x, yLoc, DefaultText.transform.position.z);
            //cloneObj.transform.localScale = DefaultText.transform.localScale;

            //Instantiate(DefaultText);
            if (PossibleProjects[i] == "NotUsed")
            {
                //doesn't add to available projects
                AvailableProjects[i] = "";
            }
            print(AvailableProjects[i]);
        }
       
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
