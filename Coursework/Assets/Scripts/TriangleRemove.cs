using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class TriangleRemove : MonoBehaviour {
    public GameObject scroll;
    public GameObject sprite;
    SpriteRenderer Triangle;
    Scrollbar ScrollBar;
    Scrollbar scrollnum;
	// Use this for initialization
	void Start () {
        scrollnum = scroll.GetComponent<Scrollbar>();
        Triangle = sprite.GetComponent<SpriteRenderer>();
        ScrollBar = scroll.GetComponent<Scrollbar>();
    }
	
	// Update is called once per frame
	
    public void SpriteRemove()
    {
        if (scrollnum.value < 0.3)
        {
            Triangle.enabled = false;
        }
        else
        {
            Triangle.enabled = true;
        }
    }
}
