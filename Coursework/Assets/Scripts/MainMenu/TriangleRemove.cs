using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class TriangleRemove : MonoBehaviour {
    public GameObject scroll;
    public GameObject sprite;
    SpriteRenderer Triangle;
    
    Scrollbar scrollnum;
	// Use this for initialization
	void Start () {
        scrollnum = scroll.GetComponent<Scrollbar>();
        Triangle = sprite.GetComponent<SpriteRenderer>();
        
        //print(scrollnum.value);
        //print(Triangle);
    }

    // Update is called once per frame
    
    public void valuecheck()
    {
        if (Triangle != null)
        {
            print("Value is right");
        }
        else
        {
            print("Value is wrong");
        }
    }
    public void SpriteRemove()
    {
        if (scrollnum.value < 0.3)
        {
            Triangle.enabled = false;
            //print("False accessed");
            //print("Value is: " + scrollnum.value);
        }
        else
        {
            Triangle.enabled = true;
            
            //print("True accessed");
            //print("Value is: " + scrollnum.value);
        }
    }
    private void Update()
    {
        //valuecheck();
        //SpriteRemove();
    }
    public void RemoverFunction()
    {
        SpriteRemove();
    }
}
