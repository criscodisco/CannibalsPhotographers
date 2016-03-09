using UnityEngine;
using System.Collections;
using System;


public class RulesButtonEvent : MonoBehaviour {

    //public float waitTime = 10.0f;
    /*public partial class RouteEventAddRemoveHandler
    {
        void onButtonClick(object sender, EventArgs e)
        {
            Application.LoadLevel(1);
        }
    }
    */

    public bool timeIsUp = true;



    public void coRoutine()
    {
        if (timeIsUp == true)
        {
            StartCoroutine(loadSceneStart(10.0f));
            //timeIsUp = false;

        }
    }
    

    IEnumerator loadSceneStart(float waitTime)
    {
        // suspend execution for waitTime seconds
        yield return new WaitForSeconds(waitTime);
        Application.LoadLevel(1);
    }

    

    // Use this for initialization
    void Start () {
        //Application.LoadLevel(0);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
