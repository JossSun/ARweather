using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spin1 : MonoBehaviour {
    public float speed = 10f;
    public GameObject earth;
    public GameObject cloud1;
    public GameObject cloud2;
    public GameObject cloud3;
    public GameObject cloud4;
    public GameObject cloud5;
    public GameObject cloud6;
//public GameObject cloud7;


    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        cloud1.transform.RotateAround(earth.transform.position, earth.transform.up, 2 * Time.deltaTime);
        cloud2.transform.RotateAround(earth.transform.position, earth.transform.up, 3 * Time.deltaTime);
        cloud3.transform.RotateAround(earth.transform.position, earth.transform.up, 1 * Time.deltaTime);
        cloud4.transform.RotateAround(earth.transform.position, earth.transform.up, 4 * Time.deltaTime);
        cloud5.transform.RotateAround(earth.transform.position, earth.transform.up, 1 * Time.deltaTime);
        cloud6.transform.RotateAround(earth.transform.position, earth.transform.up, 2 * Time.deltaTime);
        //cloud7.transform.RotateAround(earth.transform.position, earth.transform.up, 2 * Time.deltaTime);
    }
}
