using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AlertCloser : MonoBehaviour {
    GameObject Image;
    public GameObject Mcamera;
    MissionMaker script;
    TimeChanger OtherScript;
    
    public void Destroyer(GameObject GO)
    {

        GO.transform.parent = Mcamera.transform;
        script = Mcamera.GetComponent<MissionMaker>();
        OtherScript = Mcamera.GetComponent<TimeChanger>();
        script.accessed = false;
        print("Accessed has been changed to true!!!!");
        OtherScript.clickerDisable = false;
    }
	
}
