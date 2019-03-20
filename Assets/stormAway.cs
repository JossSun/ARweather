using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class stormAway : MonoBehaviour {
    #region Public Variables
    public GameObject cloud1;
    public GameObject cloud2;
    public GameObject cloud3;
    public GameObject sun;
    public GameObject text;
    public Transform thunder;
    public Transform rain;
   
   // public float speed = 1F;
    //public Transform start;
    //public Transform target;

    #endregion

    #region Private Variables
    //private float _animationTimePosition;
    //private float startTime;
    private float journeyLength;
    private Animation animcloud1;
    private Animation animcloud2;
    private Animation animcloud3;
    private Animation animsun;
    private Animation animtext;
    #endregion

    // Use this for initialization
    void Start () {
        //startTime = Time.time;
        StartCoroutine(Handler());
        sun.gameObject.SetActive(false);
        text.gameObject.SetActive(false);
        //cloud3.gameObject.SetActive(true);
    }


    IEnumerator Handler()
    {
       
        yield return new WaitForSeconds(7);
        removeRain();
        yield return new WaitForSeconds(1f);
        removeCloud();
        yield return new WaitForSeconds(0.3f);
        removeThunder();
        sunrise();
        clearsky();
        showtext();
    }

    void removeRain(){
        rain.gameObject.SetActive(false);
    }

    void removeThunder(){
        thunder.gameObject.SetActive(false);
    }


    void removeCloud(){
   

        Animator animator = cloud1.GetComponent<Animator>();
        Animator animator3 = cloud3.GetComponent<Animator>();

        animcloud1 = cloud1.gameObject.GetComponent<Animation>();
        animcloud3 = cloud3.gameObject.GetComponent<Animation>();
        

        animcloud1["Fadeaway1"].speed = 0.05f;
        animcloud3["Fadeaway2"].speed = 0.04f;
        animcloud1.Play("Fadeaway1");
        animcloud3.Play("Fadeaway2");
    }

    void sunrise(){
        sun.gameObject.SetActive(true);
        Animator animatorsun = sun.GetComponent<Animator>();
        animsun = sun.gameObject.GetComponent<Animation>();
        animsun["sunrise"].speed = 0.1f;
        animsun.Play("sunrise");

    }

    void clearsky(){
        animcloud2 = cloud2.GetComponent<Animation>();
        animcloud2["Fadeaway3"].speed = 0.05f;
        animcloud2.Play("Fadeaway3");

    }

    void showtext(){
        text.gameObject.SetActive(true);
        animtext = text.GetComponent<Animation>();
        animtext["newtext"].speed = 0.05f;
        animtext.Play("newtext");
    }

    // Update is called once per frame
    void Update () {
       
    }
}
