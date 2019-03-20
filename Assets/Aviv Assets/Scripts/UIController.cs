using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Video;

public class UIController : MonoBehaviour {

    public Button replay_button;
    public Button share_button;
    public Button menu_button;
    public Button help_button;
    public Slider timeline;

    public Button allow_camera;

    public Text time;
    public Text temp;

    public GameObject intro_ui;
    public GameObject main_ui;
    public GameObject share_ui;

    public VideoPlayer videoplane;

	// Use this for initialization
	void Start () {

        replay_button.onClick.AddListener(replay);
        share_button.onClick.AddListener(share);
        menu_button.onClick.AddListener(menu);
        help_button.onClick.AddListener(help);
        allow_camera.onClick.AddListener(startscene);
        timeline.onValueChanged.AddListener(delegate { changetime(); });

        videoplane.GetComponent<VideoPlayer>().Prepare();
    }

    // Update is called once per frame
    void Update () {
		
	}

    void changetime ()
    {
        time.GetComponent<Text>().text = "3 PM";



    }


    void replay ()
    {

    }

    void share()
    {
        main_ui.SetActive(false);
        share_ui.SetActive(true);

    }

    void menu()
    {

    }

    void help()
    {

    }

    void startscene()
    {
        intro_ui.SetActive(false);
        main_ui.SetActive(true);

    }
}
