using UnityEngine;
using System.Collections;

public class boatcrossnorth : MonoBehaviour {

    public float width = 1;
    public float height = 1;
    public static bool boatPosNorth = false;
    public Vector3 boatN_pos;
    public Vector3 boatS_pos;
    public float speed;

    public GameMagic cannibal1, cannibal2, cannibal3, photog1, photog2, photog3;
    public static Vector3 cannibal1Pos, cannibal2Pos, cannibal3Pos, photog1Pos, photog2Pos, photog3Pos;

    public static bool boatFullStatus = false;
    public static bool boatEmptySouth, boatEmptyNorth;

    public Vector3 boatPos;

    public bool showText = false;
    public bool showWinText = false;
    public float waitTime = 15.0f;
    //public float currentTime = 0.0f, executedTime = 0.0f, timeToWait = 5.0f;

    public GUIStyle guiStyleEaten = new GUIStyle();
    public GUIStyle guiStyleWinner = new GUIStyle();
    Texture2D textureMoreCannibals = new Texture2D(128, 128);
    Texture2D textureWinner = new Texture2D(128, 128);


    // Use this for initialization
    void Start() {
        // set the scaling
        //Vector3 scale = new Vector3(width, height, 1f);
        // transform.localScale = scale;
        transform.position = boatS_pos;
        boatPos = boatS_pos;
    }

    /*
    void OnGUI()
    {
        if (showText)
        {
            StartCoroutine(DisappearBoxAfter(6.0f));

            // too many cannibals on one side message
            // change the font size
            guiStyleEaten.fontSize = 18;
            GUI.backgroundColor = Color.white;
            GUILayout.BeginArea(new Rect(70, 80, 500, 500));
            GUI.Label(new Rect(0, 0, 100, 100), "There are more cannibals than photographers on one side of the river!" + System.Environment.NewLine + "The cannibals eat the photographers!", guiStyleEaten);
            GUILayout.EndArea();
        }

        if (showWinText)
        {
            // you win message
            StartCoroutine(YouWin(waitTime));
            guiStyleWinner.fontSize = 22;
            Texture2D texture = new Texture2D(128, 128);
        */

    public void OnGUI()
    {
        if (showText)
        {
            StartCoroutine(DisappearBoxAfter(10.0f));


            
            GUILayout.BeginArea(new Rect(300, 135, 1000, 1000));
            //guiStyleEaten.fontSize = 40;
            GUI.Label(new Rect(0, 0, 300, 300), "There are more cannibals on one side than photographers!" + System.Environment.NewLine + "The cannibals have eaten the photographers!");
            GUILayout.EndArea();
        }

            if(showWinText)
            {
                StartCoroutine(YouWin(waitTime));
                
                GUILayout.BeginArea(new Rect(300, 150, 1000, 1000));
                //guiStyleWinner.fontSize = 40;
                GUI.Label(new Rect(0, 0, 300, 300), "CONGRATULATIONS!!!    YOU ARE A WINNER!");
                GUILayout.EndArea();
                

            }
    }

           /* currentTime = Time.time;

            if (executedTime != 0.0f)
            {
                if (currentTime - executedTime > timeToWait)
                {
                    executedTime = 0.0f;

                }
            }
            */
        
    

    IEnumerator YouWin(float waitTime)
    {
        // suspend execution for waitTime seconds
        yield return new WaitForSeconds(waitTime);
        showText = false;
    }

    IEnumerator DisappearBoxAfter(float waitTime)
    {
        // suspend execution for waitTime seconds
        yield return new WaitForSeconds(waitTime);
        showText = false;
        cannibal1.transform.position = cannibal1.getSouthBeachPos();
        cannibal2.transform.position = cannibal2.getSouthBeachPos();
        cannibal3.transform.position = cannibal3.getSouthBeachPos();
        photog1.transform.position = photog1.getSouthBeachPos();
        photog2.transform.position = photog2.getSouthBeachPos();
        photog3.transform.position = photog3.getSouthBeachPos();

        transform.position = boatS_pos;
        boatEmptyNorth = true;
        boatEmptySouth = true;
    }

    // Update is called once per frame
    void Update() {


        cannibal1Pos = cannibal1.transform.position;
        cannibal2Pos = cannibal2.transform.position;
        cannibal3Pos = cannibal3.transform.position;
        photog1Pos = photog1.transform.position;
        photog2Pos = photog2.transform.position;
        photog3Pos = photog3.transform.position;
        
        if(boatPos == boatS_pos && (cannibal1Pos != cannibal1.boattop_pos && cannibal1Pos != cannibal1.boatbot_pos && cannibal2Pos != cannibal2.boattop_pos && cannibal2Pos != cannibal2.boatbot_pos && cannibal3Pos != cannibal3.boattop_pos && cannibal3Pos != cannibal3.boatbot_pos && photog1Pos != photog1.boattop_pos && photog1Pos != photog1.boatbot_pos && photog2Pos != photog2.boattop_pos && photog2Pos != photog2.boatbot_pos && photog3Pos != photog3.boattop_pos && photog3Pos != photog3.boatbot_pos))
        {
            boatEmptySouth = true;
        }
        else if (boatPos == boatN_pos && (cannibal1Pos != cannibal1.boattop_posN && cannibal1Pos != cannibal1.boatbot_posN && cannibal2Pos != cannibal2.boattop_posN && cannibal2Pos != cannibal2.boatbot_posN && cannibal3Pos != cannibal3.boattop_posN && cannibal3Pos != cannibal3.boatbot_posN && photog1Pos != photog1.boattop_posN && photog1Pos != photog1.boatbot_posN && photog2Pos != photog2.boattop_posN && photog2Pos != photog2.boatbot_posN && photog3Pos != photog3.boattop_posN && photog3Pos != photog3.boatbot_posN))
        {
            boatEmptyNorth = true;
        }
        else if (boatPos == boatS_pos && (cannibal1Pos == cannibal1.boattop_pos || cannibal1Pos == cannibal1.boatbot_pos || cannibal2Pos == cannibal2.boattop_pos || cannibal2Pos == cannibal2.boatbot_pos || cannibal3Pos == cannibal3.boattop_pos || cannibal3Pos == cannibal3.boatbot_pos || photog1Pos == photog1.boattop_pos || photog1Pos == photog1.boatbot_pos || photog2Pos == photog2.boattop_pos || photog2Pos == photog2.boatbot_pos || photog3Pos == photog3.boattop_pos || photog3Pos == photog3.boatbot_pos))
        {
            boatEmptySouth = false;
        }
        else if (boatPos == boatN_pos && (cannibal1Pos == cannibal1.boattop_posN || cannibal1Pos == cannibal1.boatbot_posN || cannibal2Pos == cannibal2.boattop_posN || cannibal2Pos == cannibal2.boatbot_posN || cannibal3Pos == cannibal3.boattop_posN || cannibal3Pos == cannibal3.boatbot_posN || photog1Pos == photog1.boattop_posN || photog1Pos == photog1.boatbot_posN || photog2Pos == photog2.boattop_posN || photog2Pos == photog2.boatbot_posN || photog3Pos == photog3.boattop_posN || photog3Pos == photog3.boatbot_posN))
        {
            boatEmptyNorth = false;
        }
    }

    public void OnMouseDown()
    {
        boatPos = transform.position;



        //executedTime = Time.time;

        if (boatPosNorth == true)//&& cannibal1Pos )
        {
            

            if (boatEmptyNorth == false)
            {
                // boat position south for more cannibals than photographers
                if ((cannibal1.transform.position == cannibal1.getNorthBeachPos() && cannibal2.transform.position == cannibal2.getNorthBeachPos() && cannibal3.transform.position == cannibal3.getNorthBeachPos())
            && ((photog1.transform.position == photog1.getNorthBeachPos() && photog2.transform.position == photog2.getNorthBeachPos() && photog3.transform.position != photog3.getNorthBeachPos()) || (photog1.transform.position == photog1.getNorthBeachPos() && photog2.transform.position != photog2.getNorthBeachPos() && photog3.transform.position == photog3.getNorthBeachPos()) ||
            (photog1.transform.position != photog1.getNorthBeachPos() && photog2.transform.position == photog2.getNorthBeachPos() && photog3.transform.position == photog3.getNorthBeachPos())))
                {
                    showText = true;

                    cannibal1.transform.position = cannibal1.getSouthBeachPos();
                    cannibal2.transform.position = cannibal2.getSouthBeachPos();
                    cannibal3.transform.position = cannibal3.getSouthBeachPos();
                    photog1.transform.position = photog1.getSouthBeachPos();
                    photog2.transform.position = photog2.getSouthBeachPos();
                    photog3.transform.position = photog3.getSouthBeachPos();

                    transform.position = boatS_pos;
                    boatEmptyNorth = true;



                }
                else if ((cannibal1.transform.position == cannibal1.getNorthBeachPos() && cannibal2.transform.position == cannibal2.getNorthBeachPos() && cannibal3.transform.position != cannibal3.getNorthBeachPos())
            && ((photog1.transform.position == photog1.getNorthBeachPos() && photog2.transform.position != photog2.getNorthBeachPos() && photog3.transform.position != photog3.getNorthBeachPos()) || (photog1.transform.position != photog1.getNorthBeachPos() && photog2.transform.position == photog2.getNorthBeachPos() && photog3.transform.position != photog3.getNorthBeachPos()) ||
            (photog1.transform.position != photog1.getNorthBeachPos() && photog2.transform.position != photog2.getNorthBeachPos() && photog3.transform.position == photog3.getNorthBeachPos())))
                {
                    showText = true;

                    cannibal1.transform.position = cannibal1.getSouthBeachPos();
                    cannibal2.transform.position = cannibal2.getSouthBeachPos();
                    cannibal3.transform.position = cannibal3.getSouthBeachPos();
                    photog1.transform.position = photog1.getSouthBeachPos();
                    photog2.transform.position = photog2.getSouthBeachPos();
                    photog3.transform.position = photog3.getSouthBeachPos();

                    transform.position = boatS_pos;
                    boatEmptyNorth = true;
                }
                else if ((cannibal1.transform.position == cannibal1.getNorthBeachPos() && cannibal2.transform.position != cannibal2.getNorthBeachPos() && cannibal3.transform.position == cannibal3.getNorthBeachPos())
             && ((photog1.transform.position == photog1.getNorthBeachPos() && photog2.transform.position != photog2.getNorthBeachPos() && photog3.transform.position != photog3.getNorthBeachPos()) || (photog1.transform.position != photog1.getNorthBeachPos() && photog2.transform.position == photog2.getNorthBeachPos() && photog3.transform.position != photog3.getNorthBeachPos()) ||
            (photog1.transform.position != photog1.getNorthBeachPos() && photog2.transform.position != photog2.getNorthBeachPos() && photog3.transform.position == photog3.getNorthBeachPos())))
                {
                    showText = true;

                    cannibal1.transform.position = cannibal1.getSouthBeachPos();
                    cannibal2.transform.position = cannibal2.getSouthBeachPos();
                    cannibal3.transform.position = cannibal3.getSouthBeachPos();
                    photog1.transform.position = photog1.getSouthBeachPos();
                    photog2.transform.position = photog2.getSouthBeachPos();
                    photog3.transform.position = photog3.getSouthBeachPos();

                    transform.position = boatS_pos;
                    boatEmptyNorth = true;
                }
                else if ((cannibal1.transform.position != cannibal1.getNorthBeachPos() && cannibal2.transform.position == cannibal2.getNorthBeachPos() && cannibal3.transform.position == cannibal3.getNorthBeachPos())
             && ((photog1.transform.position == photog1.getNorthBeachPos() && photog2.transform.position != photog2.getNorthBeachPos() && photog3.transform.position != photog3.getNorthBeachPos()) || (photog1.transform.position != photog1.getNorthBeachPos() && photog2.transform.position == photog2.getNorthBeachPos() && photog3.transform.position != photog3.getNorthBeachPos()) ||
            (photog1.transform.position != photog1.getNorthBeachPos() && photog2.transform.position != photog2.getNorthBeachPos() && photog3.transform.position == photog3.getNorthBeachPos())))
                {
                    showText = true;

                    cannibal1.transform.position = cannibal1.getSouthBeachPos();
                    cannibal2.transform.position = cannibal2.getSouthBeachPos();
                    cannibal3.transform.position = cannibal3.getSouthBeachPos();
                    photog1.transform.position = photog1.getSouthBeachPos();
                    photog2.transform.position = photog2.getSouthBeachPos();
                    photog3.transform.position = photog3.getSouthBeachPos();

                    transform.position = boatS_pos;
                    boatEmptyNorth = true;
                }

                else
                {
                    showText = false;

                    boatTransport();

                    cannibal1Pos = cannibal1.transform.position;
                    cannibal2Pos = cannibal2.transform.position;
                    cannibal3Pos = cannibal3.transform.position;
                    photog1Pos = photog1.transform.position;
                    photog2Pos = photog2.transform.position;
                    photog3Pos = photog3.transform.position;

                    if (cannibal1Pos == cannibal1.getNorthBeachPos() && cannibal2Pos == cannibal2.getNorthBeachPos() && cannibal3Pos == cannibal3.getNorthBeachPos() && photog1Pos == photog1.getNorthBeachPos() && photog2Pos == photog2.getNorthBeachPos() && photog3Pos == photog3.getNorthBeachPos())
                    {

                        showWinText = true;
                    }

                    transform.position = Vector3.MoveTowards(transform.position, boatS_pos, speed * Time.deltaTime);
                    boatPosNorth = false;
                    boatPos = boatS_pos;
                    boatEmptyNorth = true;

                }
            }
        }
        else if (boatPosNorth == false)
        {

            if (boatEmptySouth == false)
            {
                // boat position south for more cannibals than photographers
                if ((cannibal1.transform.position == cannibal1.getSouthBeachPos() && cannibal2.transform.position == cannibal2.getSouthBeachPos() && cannibal3.transform.position == cannibal3.getSouthBeachPos())
             && ((photog1.transform.position == photog1.getSouthBeachPos() && photog2.transform.position != photog2.getSouthBeachPos() && photog3.transform.position != photog3.getSouthBeachPos()) || (photog1.transform.position != photog1.getSouthBeachPos() && photog2.transform.position == photog2.getSouthBeachPos() && photog3.transform.position != photog3.getSouthBeachPos()) ||
            (photog1.transform.position != photog1.getSouthBeachPos() && photog2.transform.position != photog2.getSouthBeachPos() && photog3.transform.position == photog3.getSouthBeachPos())))
                {
                    showText = true;

                    cannibal1.transform.position = cannibal1.getSouthBeachPos();
                    cannibal2.transform.position = cannibal2.getSouthBeachPos();
                    cannibal3.transform.position = cannibal3.getSouthBeachPos();
                    photog1.transform.position = photog1.getSouthBeachPos();
                    photog2.transform.position = photog2.getSouthBeachPos();
                    photog3.transform.position = photog3.getSouthBeachPos();

                    transform.position = boatS_pos;
                    boatEmptySouth = true;

                }




                else if ((cannibal1.transform.position == cannibal1.getSouthBeachPos() && cannibal2.transform.position == cannibal2.getSouthBeachPos() && cannibal3.transform.position != cannibal3.getSouthBeachPos())
            && ((photog1.transform.position == photog1.getSouthBeachPos() && photog2.transform.position != photog2.getSouthBeachPos() && photog3.transform.position != photog3.getSouthBeachPos()) || (photog1.transform.position != photog1.getSouthBeachPos() && photog2.transform.position == photog2.getSouthBeachPos() && photog3.transform.position != photog3.getSouthBeachPos()) ||
            (photog1.transform.position != photog1.getSouthBeachPos() && photog2.transform.position != photog2.getSouthBeachPos() && photog3.transform.position == photog3.getSouthBeachPos())))
                {
                    showText = true;

                    cannibal1.transform.position = cannibal1.getSouthBeachPos();
                    cannibal2.transform.position = cannibal2.getSouthBeachPos();
                    cannibal3.transform.position = cannibal3.getSouthBeachPos();
                    photog1.transform.position = photog1.getSouthBeachPos();
                    photog2.transform.position = photog2.getSouthBeachPos();
                    photog3.transform.position = photog3.getSouthBeachPos();

                    transform.position = boatS_pos;
                    boatEmptySouth = true;
                }
                else if ((cannibal1.transform.position == cannibal1.getSouthBeachPos() && cannibal2.transform.position != cannibal2.getSouthBeachPos() && cannibal3.transform.position == cannibal3.getSouthBeachPos())
            && ((photog1.transform.position == photog1.getSouthBeachPos() && photog2.transform.position != photog2.getSouthBeachPos() && photog3.transform.position != photog3.getSouthBeachPos()) || (photog1.transform.position != photog1.getSouthBeachPos() && photog2.transform.position == photog2.getSouthBeachPos() && photog3.transform.position != photog3.getSouthBeachPos()) ||
            (photog1.transform.position != photog1.getSouthBeachPos() && photog2.transform.position != photog2.getSouthBeachPos() && photog3.transform.position == photog3.getSouthBeachPos())))
                {
                    showText = true;

                    cannibal1.transform.position = cannibal1.getSouthBeachPos();
                    cannibal2.transform.position = cannibal2.getSouthBeachPos();
                    cannibal3.transform.position = cannibal3.getSouthBeachPos();
                    photog1.transform.position = photog1.getSouthBeachPos();
                    photog2.transform.position = photog2.getSouthBeachPos();
                    photog3.transform.position = photog3.getSouthBeachPos();

                    transform.position = boatS_pos;
                    boatEmptySouth = true;
                }
                else if ((cannibal1.transform.position != cannibal1.getSouthBeachPos() && cannibal2.transform.position == cannibal2.getSouthBeachPos() && cannibal3.transform.position == cannibal3.getSouthBeachPos())
           && ((photog1.transform.position == photog1.getSouthBeachPos() && photog2.transform.position != photog2.getSouthBeachPos() && photog3.transform.position != photog3.getSouthBeachPos()) || (photog1.transform.position != photog1.getSouthBeachPos() && photog2.transform.position == photog2.getSouthBeachPos() && photog3.transform.position != photog3.getSouthBeachPos()) ||
            (photog1.transform.position != photog1.getSouthBeachPos() && photog2.transform.position != photog2.getSouthBeachPos() && photog3.transform.position == photog3.getSouthBeachPos())))
                {
                    showText = true;

                    cannibal1.transform.position = cannibal1.getSouthBeachPos();
                    cannibal2.transform.position = cannibal2.getSouthBeachPos();
                    cannibal3.transform.position = cannibal3.getSouthBeachPos();
                    photog1.transform.position = photog1.getSouthBeachPos();
                    photog2.transform.position = photog2.getSouthBeachPos();
                    photog3.transform.position = photog3.getSouthBeachPos();

                    transform.position = boatS_pos;
                    boatEmptySouth = true;
                }

                else
                {
                    showText = false;

                    boatTransport();

                    cannibal1Pos = cannibal1.transform.position;
                    cannibal2Pos = cannibal2.transform.position;
                    cannibal3Pos = cannibal3.transform.position;
                    photog1Pos = photog1.transform.position;
                    photog2Pos = photog2.transform.position;
                    photog3Pos = photog3.transform.position;

                    if (cannibal1Pos == cannibal1.getNorthBeachPos() && cannibal2Pos == cannibal2.getNorthBeachPos() && cannibal3Pos == cannibal3.getNorthBeachPos() && photog1Pos == photog1.getNorthBeachPos() && photog2Pos == photog2.getNorthBeachPos() && photog3Pos == photog3.getNorthBeachPos())
                    {

                        showWinText = true;
                    }

                    transform.position = Vector3.MoveTowards(transform.position, boatN_pos, speed * Time.deltaTime);
                    boatPosNorth = true;
                    boatPos = boatN_pos;
                    boatEmptySouth = true;
                }

            }
        }
    }
    
    public void boatTransport()
    {

        cannibal1Pos = cannibal1.transform.position;
        cannibal2Pos = cannibal2.transform.position;
        cannibal3Pos = cannibal3.transform.position;
        photog1Pos = photog1.transform.position;
        photog2Pos = photog2.transform.position;
        photog3Pos = photog3.transform.position;


        if (cannibal1.getTopOfBoatFull() == true || cannibal2.getTopOfBoatFull() == true || cannibal3.getTopOfBoatFull() == true || photog1.getTopOfBoatFull() == true || photog2.getTopOfBoatFull() == true || photog3.getTopOfBoatFull() == true)
        {
            cannibal1.setTopOfBoatFull(false);
            cannibal2.setTopOfBoatFull(false);
            cannibal3.setTopOfBoatFull(false);
            photog1.setTopOfBoatFull(false);
            photog2.setTopOfBoatFull(false);
            photog3.setTopOfBoatFull(false);

        }
        if (cannibal1.getBotOfBoatFull() == true || cannibal2.getBotOfBoatFull() == true || cannibal3.getBotOfBoatFull() == true || photog1.getBotOfBoatFull() == true || photog2.getBotOfBoatFull() == true || photog3.getBotOfBoatFull() == true)
        {
            cannibal1.setBotOfBoatFull(false);
            cannibal2.setBotOfBoatFull(false);
            cannibal3.setBotOfBoatFull(false);
            photog1.setBotOfBoatFull(false);
            photog2.setBotOfBoatFull(false);
            photog3.setBotOfBoatFull(false);

        }

        if (cannibal1.getTopOfNorthBoatFull() == true || cannibal2.getTopOfNorthBoatFull() == true || cannibal3.getTopOfNorthBoatFull() == true || photog1.getTopOfNorthBoatFull() == true || photog2.getTopOfNorthBoatFull() == true || photog3.getTopOfNorthBoatFull() == true)
        {
            cannibal1.setTopOfNorthBoatFull(false);
            cannibal2.setTopOfNorthBoatFull(false);
            cannibal3.setTopOfNorthBoatFull(false);
            photog1.setTopOfNorthBoatFull(false);
            photog2.setTopOfNorthBoatFull(false);
            photog3.setTopOfNorthBoatFull(false);

        }
        if (cannibal1.getBotOfNorthBoatFull() == true || cannibal2.getBotOfNorthBoatFull() == true || cannibal3.getBotOfNorthBoatFull() == true || photog1.getBotOfNorthBoatFull() == true || photog2.getBotOfNorthBoatFull() == true || photog3.getBotOfNorthBoatFull() == true)
        {
            cannibal1.setBotOfNorthBoatFull(false);
            cannibal2.setBotOfNorthBoatFull(false);
            cannibal3.setBotOfNorthBoatFull(false);
            photog1.setBotOfNorthBoatFull(false);
            photog2.setBotOfNorthBoatFull(false);
            photog3.setBotOfNorthBoatFull(false);

        }


        if (boatS_pos == boatPos)
        {

            // one person on bottom of boat

            if (cannibal1Pos == cannibal1.getBoatBottomPos() && (cannibal2Pos != cannibal2.getBoatTopPos() || cannibal3Pos != cannibal3.getBoatTopPos() || photog1Pos != photog1.getBoatTopPos() || photog2Pos != photog2.getBoatTopPos() || photog3Pos != photog3.getBoatTopPos()))
            {
                cannibal1.transform.position = Vector3.MoveTowards(cannibal1.transform.position, cannibal1.getNorthBeachPos(), speed * Time.deltaTime);
            }

            if (cannibal2Pos == cannibal2.getBoatBottomPos() && (cannibal1Pos != cannibal1.getBoatTopPos() || cannibal3Pos != cannibal3.getBoatTopPos() || photog1Pos != photog1.getBoatTopPos() || photog2Pos != photog2.getBoatTopPos() || photog3Pos != photog3.getBoatTopPos()))
            {
                cannibal2.transform.position = Vector3.MoveTowards(cannibal2.transform.position, cannibal2.getNorthBeachPos(), speed * Time.deltaTime);
            }
            if (cannibal3Pos == cannibal3.getBoatBottomPos() && (cannibal1Pos != cannibal1.getBoatTopPos() || cannibal2Pos != cannibal2.getBoatTopPos() || photog1Pos != photog1.getBoatTopPos() || photog2Pos != photog2.getBoatTopPos() || photog3Pos != photog3.getBoatTopPos()))
            {
                cannibal3.transform.position = Vector3.MoveTowards(cannibal3.transform.position, cannibal3.getNorthBeachPos(), speed * Time.deltaTime);
            }
            if (photog1Pos == photog1.getBoatBottomPos() && (cannibal1Pos != cannibal1.getBoatTopPos() || cannibal2Pos != cannibal2.getBoatTopPos() || cannibal3Pos != cannibal3.getBoatTopPos() || photog2Pos != photog2.getBoatTopPos() || photog3Pos != photog3.getBoatTopPos()))
            {
                photog1.transform.position = Vector3.MoveTowards(photog1.transform.position, photog1.getNorthBeachPos(), speed * Time.deltaTime);
            }
            if (photog2Pos == photog2.getBoatBottomPos() && (cannibal1Pos != cannibal1.getBoatTopPos() || cannibal2Pos != cannibal2.getBoatTopPos() || cannibal3Pos != cannibal3.getBoatTopPos() || photog1Pos != photog1.getBoatTopPos() || photog3Pos != photog3.getBoatTopPos()))
            {
                photog2.transform.position = Vector3.MoveTowards(photog2.transform.position, photog2.getNorthBeachPos(), speed * Time.deltaTime);
            }
            if (photog3Pos == photog3.getBoatBottomPos() && (cannibal1Pos != cannibal1.getBoatTopPos() || cannibal2Pos != cannibal2.getBoatTopPos() || cannibal3Pos != cannibal3.getBoatTopPos() || photog1Pos != photog1.getBoatTopPos() || photog2Pos != photog2.getBoatTopPos()))
            {
                photog3.transform.position = Vector3.MoveTowards(photog3.transform.position, photog3.getNorthBeachPos(), speed * Time.deltaTime);
            }

            // one person on top of boat
            if (cannibal1Pos == cannibal1.getBoatTopPos() && (cannibal2Pos != cannibal2.getBoatBottomPos() && cannibal2Pos != cannibal2.getSouthBeachPos() || cannibal3Pos != cannibal3.getBoatBottomPos() || photog1Pos != photog1.getBoatBottomPos() || photog2Pos != photog2.getBoatBottomPos() || photog3Pos != photog3.getBoatBottomPos()))
            {
                cannibal1.transform.position = Vector3.MoveTowards(cannibal1.transform.position, cannibal1.getNorthBeachPos(), speed * Time.deltaTime);
            }

            if (cannibal2Pos == cannibal2.getBoatTopPos() && (cannibal1Pos != cannibal1.getBoatBottomPos() || cannibal3Pos != cannibal3.getBoatBottomPos() || photog1Pos != photog1.getBoatBottomPos() || photog2Pos != photog2.getBoatBottomPos() || photog3Pos != photog3.getBoatBottomPos()))
            {
                cannibal2.transform.position = Vector3.MoveTowards(cannibal2.transform.position, cannibal2.getNorthBeachPos(), speed * Time.deltaTime);
            }
            if (cannibal3Pos == cannibal3.getBoatTopPos() && (cannibal1Pos != cannibal1.getBoatBottomPos() || cannibal2Pos != cannibal2.getBoatBottomPos() || photog1Pos != photog1.getBoatBottomPos() || photog2Pos != photog2.getBoatBottomPos() || photog3Pos != photog3.getBoatBottomPos()))
            {
                cannibal3.transform.position = Vector3.MoveTowards(cannibal3.transform.position, cannibal3.getNorthBeachPos(), speed * Time.deltaTime);
            }
            if (photog1Pos == photog1.getBoatTopPos() && (cannibal1Pos != cannibal1.getBoatBottomPos() || cannibal2Pos != cannibal2.getBoatBottomPos() || cannibal3Pos != cannibal3.getBoatBottomPos() || photog2Pos != photog2.getBoatBottomPos() || photog3Pos != photog3.getBoatBottomPos()))
            {
                photog1.transform.position = Vector3.MoveTowards(photog1.transform.position, photog1.getNorthBeachPos(), speed * Time.deltaTime);
            }
            if (photog2Pos == photog2.getBoatTopPos() && (cannibal1Pos != cannibal1.getBoatBottomPos() || cannibal2Pos != cannibal2.getBoatBottomPos() || cannibal3Pos != cannibal3.getBoatBottomPos() || photog1Pos != photog1.getBoatBottomPos() || photog3Pos != photog3.getBoatBottomPos()))
            {
                photog2.transform.position = Vector3.MoveTowards(photog2.transform.position, photog2.getNorthBeachPos(), speed * Time.deltaTime);
            }
            if (photog3Pos == photog3.getBoatTopPos() && (cannibal1Pos != cannibal1.getBoatBottomPos() || cannibal2Pos != cannibal2.getBoatBottomPos() || cannibal3Pos != cannibal3.getBoatBottomPos() || photog1Pos != photog1.getBoatBottomPos() || photog2Pos != photog2.getBoatBottomPos()))
            {
                photog3.transform.position = Vector3.MoveTowards(photog3.transform.position, photog3.getNorthBeachPos(), speed * Time.deltaTime);
            }






            // two people on boat

            // cannibal1 South boat position
            if (cannibal1Pos == cannibal1.getBoatBottomPos() && cannibal2Pos == cannibal2.getBoatTopPos())
            {
                cannibal1.transform.position = Vector3.MoveTowards(cannibal1.transform.position, cannibal1.getNorthBeachPos(), speed * Time.deltaTime);
                cannibal2.transform.position = Vector3.MoveTowards(cannibal2.transform.position, cannibal2.getNorthBeachPos(), speed * Time.deltaTime);

            }



            if (cannibal1Pos == cannibal1.getBoatBottomPos() && cannibal3Pos == cannibal3.getBoatTopPos())
            {
                cannibal1.transform.position = Vector3.MoveTowards(cannibal1.transform.position, cannibal1.getNorthBeachPos(), speed * Time.deltaTime);
                cannibal3.transform.position = Vector3.MoveTowards(cannibal3.transform.position, cannibal3.getNorthBeachPos(), speed * Time.deltaTime);

            }



            if (cannibal1Pos == cannibal1.getBoatBottomPos() && photog1Pos == photog1.getBoatTopPos())
            {
                cannibal1.transform.position = Vector3.MoveTowards(cannibal1.transform.position, cannibal1.getNorthBeachPos(), speed * Time.deltaTime);
                photog1.transform.position = Vector3.MoveTowards(photog2.transform.position, photog2.getNorthBeachPos(), speed * Time.deltaTime);

            }

            if (cannibal1Pos == cannibal1.getBoatBottomPos() && photog2Pos == photog2.getBoatTopPos())
            {
                cannibal1.transform.position = Vector3.MoveTowards(cannibal1.transform.position, cannibal1.getNorthBeachPos(), speed * Time.deltaTime);
                photog2.transform.position = Vector3.MoveTowards(photog2.transform.position, photog2.getNorthBeachPos(), speed * Time.deltaTime);

            }

            if (cannibal1Pos == cannibal1.getBoatBottomPos() && photog3Pos == photog3.getBoatTopPos())
            {
                cannibal1.transform.position = Vector3.MoveTowards(cannibal1.transform.position, cannibal1.getNorthBeachPos(), speed * Time.deltaTime);
                photog3.transform.position = Vector3.MoveTowards(photog3.transform.position, photog3.getNorthBeachPos(), speed * Time.deltaTime);

            }

            // cannibal2 South boat position

            if (cannibal2Pos == cannibal2.getBoatBottomPos() && cannibal1Pos == cannibal1.getBoatTopPos())
            {
                cannibal2.transform.position = Vector3.MoveTowards(cannibal2.transform.position, cannibal2.getNorthBeachPos(), speed * Time.deltaTime);
                cannibal1.transform.position = Vector3.MoveTowards(cannibal1.transform.position, cannibal1.getNorthBeachPos(), speed * Time.deltaTime);

            }


            if (cannibal2Pos == cannibal2.getBoatBottomPos() && cannibal3Pos == cannibal3.getBoatTopPos())
            {
                cannibal2.transform.position = Vector3.MoveTowards(cannibal2.transform.position, cannibal2.getNorthBeachPos(), speed * Time.deltaTime);
                cannibal3.transform.position = Vector3.MoveTowards(cannibal3.transform.position, cannibal3.getNorthBeachPos(), speed * Time.deltaTime);

            }


            if (cannibal2Pos == cannibal2.getBoatBottomPos() && photog1Pos == photog1.getBoatTopPos())
            {
                cannibal2.transform.position = Vector3.MoveTowards(cannibal2.transform.position, cannibal2.getNorthBeachPos(), speed * Time.deltaTime);
                photog1.transform.position = Vector3.MoveTowards(photog2.transform.position, photog2.getNorthBeachPos(), speed * Time.deltaTime);

            }

            if (cannibal2Pos == cannibal2.getBoatBottomPos() && photog2Pos == photog2.getBoatTopPos())
            {
                cannibal2.transform.position = Vector3.MoveTowards(cannibal2.transform.position, cannibal2.getNorthBeachPos(), speed * Time.deltaTime);
                photog2.transform.position = Vector3.MoveTowards(photog2.transform.position, photog2.getNorthBeachPos(), speed * Time.deltaTime);

            }

            if (cannibal2Pos == cannibal2.getBoatBottomPos() && photog3Pos == photog3.getBoatTopPos())
            {
                cannibal2.transform.position = Vector3.MoveTowards(cannibal2.transform.position, cannibal2.getNorthBeachPos(), speed * Time.deltaTime);
                photog3.transform.position = Vector3.MoveTowards(photog3.transform.position, photog3.getNorthBeachPos(), speed * Time.deltaTime);

            }

            // cannibal3 South boat position

            if (cannibal3Pos == cannibal3.getBoatBottomPos() && cannibal1Pos == cannibal1.getBoatTopPos())
            {
                cannibal3.transform.position = Vector3.MoveTowards(cannibal3.transform.position, cannibal3.getNorthBeachPos(), speed * Time.deltaTime);
                cannibal1.transform.position = Vector3.MoveTowards(cannibal1.transform.position, cannibal1.getNorthBeachPos(), speed * Time.deltaTime);

            }


            if (cannibal3Pos == cannibal3.getBoatBottomPos() && cannibal2Pos == cannibal2.getBoatTopPos())
            {
                cannibal3.transform.position = Vector3.MoveTowards(cannibal3.transform.position, cannibal3.getNorthBeachPos(), speed * Time.deltaTime);
                cannibal2.transform.position = Vector3.MoveTowards(cannibal2.transform.position, cannibal2.getNorthBeachPos(), speed * Time.deltaTime);

            }


            if (cannibal3Pos == cannibal3.getBoatBottomPos() && photog1Pos == photog1.getBoatTopPos())
            {
                cannibal3.transform.position = Vector3.MoveTowards(cannibal3.transform.position, cannibal3.getNorthBeachPos(), speed * Time.deltaTime);
                photog1.transform.position = Vector3.MoveTowards(photog2.transform.position, photog2.getNorthBeachPos(), speed * Time.deltaTime);

            }

            if (cannibal3Pos == cannibal3.getBoatBottomPos() && photog2Pos == photog2.getBoatTopPos())
            {
                cannibal3.transform.position = Vector3.MoveTowards(cannibal3.transform.position, cannibal3.getNorthBeachPos(), speed * Time.deltaTime);
                photog2.transform.position = Vector3.MoveTowards(photog2.transform.position, photog2.getNorthBeachPos(), speed * Time.deltaTime);

            }

            if (cannibal3Pos == cannibal3.getBoatBottomPos() && photog3Pos == photog3.getBoatTopPos())
            {
                cannibal3.transform.position = Vector3.MoveTowards(cannibal3.transform.position, cannibal3.getNorthBeachPos(), speed * Time.deltaTime);
                photog3.transform.position = Vector3.MoveTowards(photog3.transform.position, photog3.getNorthBeachPos(), speed * Time.deltaTime);

            }

            // photographer1 South boat position

            if (photog1Pos == photog1.getBoatBottomPos() && cannibal1Pos == cannibal1.getBoatTopPos())
            {
                photog1.transform.position = Vector3.MoveTowards(photog1.transform.position, photog1.getNorthBeachPos(), speed * Time.deltaTime);
                cannibal1.transform.position = Vector3.MoveTowards(cannibal1.transform.position, cannibal1.getNorthBeachPos(), speed * Time.deltaTime);

            }


            if (photog1Pos == photog1.getBoatBottomPos() && cannibal2Pos == cannibal2.getBoatTopPos())
            {
                photog1.transform.position = Vector3.MoveTowards(photog1.transform.position, photog1.getNorthBeachPos(), speed * Time.deltaTime);
                cannibal2.transform.position = Vector3.MoveTowards(cannibal2.transform.position, cannibal2.getNorthBeachPos(), speed * Time.deltaTime);

            }


            if (photog1Pos == photog1.getBoatBottomPos() && cannibal3Pos == cannibal3.getBoatTopPos())
            {
                photog1.transform.position = Vector3.MoveTowards(photog1.transform.position, photog1.getNorthBeachPos(), speed * Time.deltaTime);
                cannibal3.transform.position = Vector3.MoveTowards(cannibal3.transform.position, cannibal3.getNorthBeachPos(), speed * Time.deltaTime);

            }

            if (photog1Pos == photog1.getBoatBottomPos() && photog2Pos == photog2.getBoatTopPos())
            {
                photog1.transform.position = Vector3.MoveTowards(photog1.transform.position, photog1.getNorthBeachPos(), speed * Time.deltaTime);
                photog2.transform.position = Vector3.MoveTowards(photog2.transform.position, photog2.getNorthBeachPos(), speed * Time.deltaTime);

            }

            if (photog1Pos == photog1.getBoatBottomPos() && photog3Pos == photog3.getBoatTopPos())
            {
                photog1.transform.position = Vector3.MoveTowards(photog1.transform.position, photog1.getNorthBeachPos(), speed * Time.deltaTime);
                photog3.transform.position = Vector3.MoveTowards(photog3.transform.position, photog3.getNorthBeachPos(), speed * Time.deltaTime);

            }


            // photographer2 South boat position

            if (photog2Pos == photog2.getBoatBottomPos() && cannibal1Pos == cannibal1.getBoatTopPos())
            {
                photog2.transform.position = Vector3.MoveTowards(photog2.transform.position, photog2.getNorthBeachPos(), speed * Time.deltaTime);
                cannibal1.transform.position = Vector3.MoveTowards(cannibal1.transform.position, cannibal1.getNorthBeachPos(), speed * Time.deltaTime);
            }


            if (photog2Pos == photog2.getBoatBottomPos() && cannibal2Pos == cannibal2.getBoatTopPos())
            {
                photog2.transform.position = Vector3.MoveTowards(photog2.transform.position, photog2.getNorthBeachPos(), speed * Time.deltaTime);
                cannibal2.transform.position = Vector3.MoveTowards(cannibal2.transform.position, cannibal2.getNorthBeachPos(), speed * Time.deltaTime);
            }


            if (photog2Pos == photog2.getBoatBottomPos() && cannibal3Pos == cannibal3.getBoatTopPos())
            {
                photog2.transform.position = Vector3.MoveTowards(photog2.transform.position, photog2.getNorthBeachPos(), speed * Time.deltaTime);
                cannibal3.transform.position = Vector3.MoveTowards(cannibal3.transform.position, cannibal3.getNorthBeachPos(), speed * Time.deltaTime);
            }

            if (photog2Pos == photog2.getBoatBottomPos() && photog1Pos == photog1.getBoatTopPos())
            {
                photog2.transform.position = Vector3.MoveTowards(photog2.transform.position, photog2.getNorthBeachPos(), speed * Time.deltaTime);
                photog1.transform.position = Vector3.MoveTowards(photog1.transform.position, photog1.getNorthBeachPos(), speed * Time.deltaTime);
            }

            if (photog2Pos == photog2.getBoatBottomPos() && photog3Pos == photog3.getBoatTopPos())
            {
                photog2.transform.position = Vector3.MoveTowards(photog2.transform.position, photog2.getNorthBeachPos(), speed * Time.deltaTime);
                photog3.transform.position = Vector3.MoveTowards(photog3.transform.position, photog3.getNorthBeachPos(), speed * Time.deltaTime);
            }

            // photographer3 South boat position

            if (photog3Pos == photog3.getBoatBottomPos() && cannibal1Pos == cannibal1.getBoatTopPos())
            {
                photog3.transform.position = Vector3.MoveTowards(photog3.transform.position, photog3.getNorthBeachPos(), speed * Time.deltaTime);
                cannibal1.transform.position = Vector3.MoveTowards(cannibal1.transform.position, cannibal1.getNorthBeachPos(), speed * Time.deltaTime);
            }


            if (photog3Pos == photog3.getBoatBottomPos() && cannibal2Pos == cannibal2.getBoatTopPos())
            {
                photog3.transform.position = Vector3.MoveTowards(photog3.transform.position, photog3.getNorthBeachPos(), speed * Time.deltaTime);
                cannibal2.transform.position = Vector3.MoveTowards(cannibal2.transform.position, cannibal2.getNorthBeachPos(), speed * Time.deltaTime);
            }


            if (photog3Pos == photog3.getBoatBottomPos() && cannibal3Pos == cannibal3.getBoatTopPos())
            {
                photog3.transform.position = Vector3.MoveTowards(photog3.transform.position, photog3.getNorthBeachPos(), speed * Time.deltaTime);
                cannibal3.transform.position = Vector3.MoveTowards(cannibal3.transform.position, cannibal3.getNorthBeachPos(), speed * Time.deltaTime);
            }

            if (photog3Pos == photog3.getBoatBottomPos() && photog1Pos == photog1.getBoatTopPos())
            {
                photog3.transform.position = Vector3.MoveTowards(photog3.transform.position, photog3.getNorthBeachPos(), speed * Time.deltaTime);
                photog1.transform.position = Vector3.MoveTowards(photog1.transform.position, photog1.getNorthBeachPos(), speed * Time.deltaTime);
            }

            if (photog3Pos == photog3.getBoatBottomPos() && photog2Pos == photog2.getBoatTopPos())
            {
                photog3.transform.position = Vector3.MoveTowards(photog3.transform.position, photog3.getNorthBeachPos(), speed * Time.deltaTime);
                photog2.transform.position = Vector3.MoveTowards(photog2.transform.position, photog2.getNorthBeachPos(), speed * Time.deltaTime);
            }


        }
        



     
        // NORTH BOAT POSITION ************************************


       
       

        //boatPos = transform.position;

        if (boatN_pos == boatPos)
        {
            // one person on bottom of boat

            if (cannibal1Pos == cannibal1.boattop_posN && (cannibal2Pos != cannibal2.boattop_posN || cannibal3Pos != cannibal3.boattop_posN || photog1Pos != photog1.boattop_posN || photog2Pos != photog2.boattop_posN || photog3Pos != photog3.boattop_posN))
            {
                cannibal1.transform.position = Vector3.MoveTowards(cannibal1.transform.position, cannibal1.getSouthBeachPos(), speed * Time.deltaTime);
            }

            if (cannibal2Pos == cannibal2.boatbot_posN && (cannibal1Pos != cannibal1.boattop_posN || cannibal3Pos != cannibal3.boattop_posN || photog1Pos != photog1.boattop_posN || photog2Pos != photog2.boattop_posN || photog3Pos != photog3.boattop_posN))
            {
                cannibal2.transform.position = Vector3.MoveTowards(cannibal2.transform.position, cannibal2.getSouthBeachPos(), speed * Time.deltaTime);
            }
            if (cannibal3Pos == cannibal3.boatbot_posN && (cannibal1Pos != cannibal1.boattop_posN || cannibal2Pos != cannibal2.boattop_posN || photog1Pos != photog1.boattop_posN || photog2Pos != photog2.boattop_posN || photog3Pos != photog3.boattop_posN))
            {
                cannibal3.transform.position = Vector3.MoveTowards(cannibal3.transform.position, cannibal3.getSouthBeachPos(), speed * Time.deltaTime);
            }
            if (photog1Pos == photog1.boatbot_posN && (cannibal1Pos != cannibal1.boattop_posN || cannibal2Pos != cannibal2.boattop_posN || cannibal3Pos != cannibal3.boattop_posN || photog2Pos != photog2.boattop_posN || photog3Pos != photog3.boattop_posN))
            {
                photog1.transform.position = Vector3.MoveTowards(photog1.transform.position, photog1.getSouthBeachPos(), speed * Time.deltaTime);
            }
            if (photog2Pos == photog2.boatbot_posN && (cannibal1Pos != cannibal1.boattop_posN || cannibal2Pos != cannibal2.boattop_posN || cannibal3Pos != cannibal3.boattop_posN || photog1Pos != photog1.boattop_posN || photog3Pos != photog3.boattop_posN))
            {
                photog2.transform.position = Vector3.MoveTowards(photog2.transform.position, photog2.getSouthBeachPos(), speed * Time.deltaTime);
            }
            if (photog3Pos == photog3.boatbot_posN && (cannibal1Pos != cannibal1.boattop_posN || cannibal2Pos != cannibal2.boattop_posN || cannibal3Pos != cannibal3.boattop_posN || photog1Pos != photog1.boattop_posN || photog2Pos != photog2.boattop_posN))
            {
                photog3.transform.position = Vector3.MoveTowards(photog3.transform.position, photog3.getSouthBeachPos(), speed * Time.deltaTime);
            }

            // one person on top of boat
            if (cannibal1Pos == cannibal1.boattop_posN && (cannibal2Pos != cannibal2.getBoatBottomPos() && cannibal2Pos != cannibal2.getSouthBeachPos() || cannibal3Pos != cannibal3.getBoatBottomPos() || photog1Pos != photog1.boatbot_posN || photog2Pos != photog2.boatbot_posN || photog3Pos != photog3.boatbot_posN))
            {
                cannibal1.transform.position = Vector3.MoveTowards(cannibal1.transform.position, cannibal1.getSouthBeachPos(), speed * Time.deltaTime);
            }

            if (cannibal2Pos == cannibal2.boattop_posN && (cannibal1Pos != cannibal1.boatbot_posN || cannibal3Pos != cannibal3.boatbot_posN || photog1Pos != photog1.boatbot_posN || photog2Pos != photog2.boatbot_posN || photog3Pos != photog3.boatbot_posN))
            {
                cannibal2.transform.position = Vector3.MoveTowards(cannibal2.transform.position, cannibal2.getSouthBeachPos(), speed * Time.deltaTime);
            }
            if (cannibal3Pos == cannibal3.boattop_posN && (cannibal1Pos != cannibal1.boatbot_posN || cannibal2Pos != cannibal2.boatbot_posN || photog1Pos != photog1.boatbot_posN || photog2Pos != photog2.boatbot_posN || photog3Pos != photog3.boatbot_posN))
            {
                cannibal3.transform.position = Vector3.MoveTowards(cannibal3.transform.position, cannibal3.getSouthBeachPos(), speed * Time.deltaTime);
            }
            if (photog1Pos == photog1.boattop_posN && (cannibal1Pos != cannibal1.boatbot_posN || cannibal2Pos != cannibal2.boatbot_posN || cannibal3Pos != cannibal3.boatbot_posN || photog2Pos != photog2.boatbot_posN || photog3Pos != photog3.boatbot_posN))
            {
                photog1.transform.position = Vector3.MoveTowards(photog1.transform.position, photog1.getSouthBeachPos(), speed * Time.deltaTime);
            }
            if (photog2Pos == photog2.boattop_posN && (cannibal1Pos != cannibal1.boatbot_posN || cannibal2Pos != cannibal2.boatbot_posN || cannibal3Pos != cannibal3.boatbot_posN || photog1Pos != photog1.boatbot_posN || photog3Pos != photog3.boatbot_posN))
            {
                photog2.transform.position = Vector3.MoveTowards(photog2.transform.position, photog2.getSouthBeachPos(), speed * Time.deltaTime);
            }
            if (photog3Pos == photog3.boattop_posN && (cannibal1Pos != cannibal1.boatbot_posN || cannibal2Pos != cannibal2.boatbot_posN || cannibal3Pos != cannibal3.boatbot_posN || photog1Pos != photog1.boatbot_posN || photog2Pos != photog2.boatbot_posN))
            {
                photog3.transform.position = Vector3.MoveTowards(photog3.transform.position, photog3.getSouthBeachPos(), speed * Time.deltaTime);
            }



            // cannibal1 South boat position
            if (cannibal1Pos == cannibal1.boatbot_posN && cannibal2Pos == cannibal2.boattop_posN)
            {
                cannibal1.transform.position = Vector3.MoveTowards(cannibal1.transform.position, cannibal1.getSouthBeachPos(), speed * Time.deltaTime);
                cannibal2.transform.position = Vector3.MoveTowards(cannibal2.transform.position, cannibal2.getSouthBeachPos(), speed * Time.deltaTime);

            }



            if (cannibal1Pos == cannibal1.boatbot_posN && cannibal3Pos == cannibal3.boattop_posN)
            {
                cannibal1.transform.position = Vector3.MoveTowards(cannibal1.transform.position, cannibal1.getSouthBeachPos(), speed * Time.deltaTime);
                cannibal3.transform.position = Vector3.MoveTowards(cannibal3.transform.position, cannibal3.getSouthBeachPos(), speed * Time.deltaTime);

            }



            if (cannibal1Pos == cannibal1.boatbot_posN && photog1Pos == photog1.boattop_posN)
            {
                cannibal1.transform.position = Vector3.MoveTowards(cannibal1.transform.position, cannibal1.getSouthBeachPos(), speed * Time.deltaTime);
                photog1.transform.position = Vector3.MoveTowards(photog2.transform.position, photog2.getSouthBeachPos(), speed * Time.deltaTime);

            }

            if (cannibal1Pos == cannibal1.boatbot_posN && photog2Pos == photog2.boattop_posN)
            {
                cannibal1.transform.position = Vector3.MoveTowards(cannibal1.transform.position, cannibal1.getSouthBeachPos(), speed * Time.deltaTime);
                photog2.transform.position = Vector3.MoveTowards(photog2.transform.position, photog2.getSouthBeachPos(), speed * Time.deltaTime);

            }

            if (cannibal1Pos == cannibal1.boatbot_posN && photog3Pos == photog3.boattop_posN)
            {
                cannibal1.transform.position = Vector3.MoveTowards(cannibal1.transform.position, cannibal1.getSouthBeachPos(), speed * Time.deltaTime);
                photog3.transform.position = Vector3.MoveTowards(photog3.transform.position, photog3.getSouthBeachPos(), speed * Time.deltaTime);

            }

            // cannibal2 South boat position

            if (cannibal2Pos == cannibal2.boatbot_posN && cannibal1Pos == cannibal1.boattop_posN)
            {
                cannibal2.transform.position = Vector3.MoveTowards(cannibal2.transform.position, cannibal2.getSouthBeachPos(), speed * Time.deltaTime);
                cannibal1.transform.position = Vector3.MoveTowards(cannibal1.transform.position, cannibal1.getSouthBeachPos(), speed * Time.deltaTime);

            }


            if (cannibal2Pos == cannibal2.boatbot_posN && cannibal3Pos == cannibal3.boattop_posN)
            {
                cannibal2.transform.position = Vector3.MoveTowards(cannibal2.transform.position, cannibal2.getSouthBeachPos(), speed * Time.deltaTime);
                cannibal3.transform.position = Vector3.MoveTowards(cannibal3.transform.position, cannibal3.getSouthBeachPos(), speed * Time.deltaTime);

            }


            if (cannibal2Pos == cannibal2.boatbot_posN && photog1Pos == photog1.boattop_posN)
            {
                cannibal2.transform.position = Vector3.MoveTowards(cannibal2.transform.position, cannibal2.getSouthBeachPos(), speed * Time.deltaTime);
                photog1.transform.position = Vector3.MoveTowards(photog2.transform.position, photog2.getSouthBeachPos(), speed * Time.deltaTime);

            }

            if (cannibal2Pos == cannibal2.boatbot_posN && photog2Pos == photog2.boattop_posN)
            {
                cannibal2.transform.position = Vector3.MoveTowards(cannibal2.transform.position, cannibal2.getSouthBeachPos(), speed * Time.deltaTime);
                photog2.transform.position = Vector3.MoveTowards(photog2.transform.position, photog2.getSouthBeachPos(), speed * Time.deltaTime);

            }

            if (cannibal2Pos == cannibal2.boatbot_posN && photog3Pos == photog3.boattop_posN)
            {
                cannibal2.transform.position = Vector3.MoveTowards(cannibal2.transform.position, cannibal2.getSouthBeachPos(), speed * Time.deltaTime);
                photog3.transform.position = Vector3.MoveTowards(photog3.transform.position, photog3.getSouthBeachPos(), speed * Time.deltaTime);

            }

            // cannibal3 South boat position

            if (cannibal3Pos == cannibal3.boatbot_posN && cannibal1Pos == cannibal1.boattop_posN)
            {
                cannibal3.transform.position = Vector3.MoveTowards(cannibal3.transform.position, cannibal3.getSouthBeachPos(), speed * Time.deltaTime);
                cannibal1.transform.position = Vector3.MoveTowards(cannibal1.transform.position, cannibal1.getSouthBeachPos(), speed * Time.deltaTime);

            }


            if (cannibal3Pos == cannibal3.boatbot_posN && cannibal2Pos == cannibal2.boattop_posN)
            {
                cannibal3.transform.position = Vector3.MoveTowards(cannibal3.transform.position, cannibal3.getSouthBeachPos(), speed * Time.deltaTime);
                cannibal2.transform.position = Vector3.MoveTowards(cannibal2.transform.position, cannibal2.getSouthBeachPos(), speed * Time.deltaTime);

            }


            if (cannibal3Pos == cannibal3.boatbot_posN && photog1Pos == photog1.boattop_posN)
            {
                cannibal3.transform.position = Vector3.MoveTowards(cannibal3.transform.position, cannibal3.getSouthBeachPos(), speed * Time.deltaTime);
                photog1.transform.position = Vector3.MoveTowards(photog2.transform.position, photog2.getSouthBeachPos(), speed * Time.deltaTime);

            }

            if (cannibal3Pos == cannibal3.boatbot_posN && photog2Pos == photog2.boattop_posN)
            {
                cannibal3.transform.position = Vector3.MoveTowards(cannibal3.transform.position, cannibal3.getSouthBeachPos(), speed * Time.deltaTime);
                photog2.transform.position = Vector3.MoveTowards(photog2.transform.position, photog2.getSouthBeachPos(), speed * Time.deltaTime);

            }

            if (cannibal3Pos == cannibal3.boatbot_posN && photog3Pos == photog3.boattop_posN)
            {
                cannibal3.transform.position = Vector3.MoveTowards(cannibal3.transform.position, cannibal3.getSouthBeachPos(), speed * Time.deltaTime);
                photog3.transform.position = Vector3.MoveTowards(photog3.transform.position, photog3.getSouthBeachPos(), speed * Time.deltaTime);

            }

            // photographer1 South boat position

            if (photog1Pos == photog1.boatbot_posN && cannibal1Pos == cannibal1.boattop_posN)
            {
                photog1.transform.position = Vector3.MoveTowards(photog1.transform.position, photog1.getSouthBeachPos(), speed * Time.deltaTime);
                cannibal1.transform.position = Vector3.MoveTowards(cannibal1.transform.position, cannibal1.getSouthBeachPos(), speed * Time.deltaTime);

            }


            if (photog1Pos == photog1.boatbot_posN && cannibal2Pos == cannibal2.boattop_posN)
            {
                photog1.transform.position = Vector3.MoveTowards(photog1.transform.position, photog1.getSouthBeachPos(), speed * Time.deltaTime);
                cannibal2.transform.position = Vector3.MoveTowards(cannibal2.transform.position, cannibal2.getSouthBeachPos(), speed * Time.deltaTime);

            }


            if (photog1Pos == photog1.boatbot_posN && cannibal3Pos == cannibal3.boattop_posN)
            {
                photog1.transform.position = Vector3.MoveTowards(photog1.transform.position, photog1.getSouthBeachPos(), speed * Time.deltaTime);
                cannibal3.transform.position = Vector3.MoveTowards(cannibal3.transform.position, cannibal3.getSouthBeachPos(), speed * Time.deltaTime);

            }

            if (photog1Pos == photog1.boatbot_posN && photog2Pos == photog2.boattop_posN)
            {
                photog1.transform.position = Vector3.MoveTowards(photog1.transform.position, photog1.getSouthBeachPos(), speed * Time.deltaTime);
                photog2.transform.position = Vector3.MoveTowards(photog2.transform.position, photog2.getSouthBeachPos(), speed * Time.deltaTime);

            }

            if (photog1Pos == photog1.boatbot_posN && photog3Pos == photog3.boattop_posN)
            {
                photog1.transform.position = Vector3.MoveTowards(photog1.transform.position, photog1.getSouthBeachPos(), speed * Time.deltaTime);
                photog3.transform.position = Vector3.MoveTowards(photog3.transform.position, photog3.getSouthBeachPos(), speed * Time.deltaTime);

            }


            // photographer2 South boat position

            if (photog2Pos == photog2.boatbot_posN && cannibal1Pos == cannibal1.boattop_posN)
            {
                photog2.transform.position = Vector3.MoveTowards(photog2.transform.position, photog2.getSouthBeachPos(), speed * Time.deltaTime);
                cannibal1.transform.position = Vector3.MoveTowards(cannibal1.transform.position, cannibal1.getSouthBeachPos(), speed * Time.deltaTime);
            }


            if (photog2Pos == photog2.boatbot_posN && cannibal2Pos == cannibal2.boattop_posN)
            {
                photog2.transform.position = Vector3.MoveTowards(photog2.transform.position, photog2.getSouthBeachPos(), speed * Time.deltaTime);
                cannibal2.transform.position = Vector3.MoveTowards(cannibal2.transform.position, cannibal2.getSouthBeachPos(), speed * Time.deltaTime);
            }


            if (photog2Pos == photog2.boatbot_posN && cannibal3Pos == cannibal3.boattop_posN)
            {
                photog2.transform.position = Vector3.MoveTowards(photog2.transform.position, photog2.getSouthBeachPos(), speed * Time.deltaTime);
                cannibal3.transform.position = Vector3.MoveTowards(cannibal3.transform.position, cannibal3.getSouthBeachPos(), speed * Time.deltaTime);
            }

            if (photog2Pos == photog2.boatbot_posN && photog1Pos == photog1.boattop_posN)
            {
                photog2.transform.position = Vector3.MoveTowards(photog2.transform.position, photog2.getSouthBeachPos(), speed * Time.deltaTime);
                photog1.transform.position = Vector3.MoveTowards(photog1.transform.position, photog1.getSouthBeachPos(), speed * Time.deltaTime);
            }

            if (photog2Pos == photog2.boatbot_posN && photog3Pos == photog3.boattop_posN)
            {
                photog2.transform.position = Vector3.MoveTowards(photog2.transform.position, photog2.getSouthBeachPos(), speed * Time.deltaTime);
                photog3.transform.position = Vector3.MoveTowards(photog3.transform.position, photog3.getSouthBeachPos(), speed * Time.deltaTime);
            }

            // photographer3 South boat position

            if (photog3Pos == photog3.boatbot_posN && cannibal1Pos == cannibal1.boattop_posN)
            {
                photog3.transform.position = Vector3.MoveTowards(photog3.transform.position, photog3.getSouthBeachPos(), speed * Time.deltaTime);
                cannibal1.transform.position = Vector3.MoveTowards(cannibal1.transform.position, cannibal1.getSouthBeachPos(), speed * Time.deltaTime);
            }


            if (photog3Pos == photog3.boatbot_posN && cannibal2Pos == cannibal2.boattop_posN)
            {
                photog3.transform.position = Vector3.MoveTowards(photog3.transform.position, photog3.getSouthBeachPos(), speed * Time.deltaTime);
                cannibal2.transform.position = Vector3.MoveTowards(cannibal2.transform.position, cannibal2.getSouthBeachPos(), speed * Time.deltaTime);
            }


            if (photog3Pos == photog3.boatbot_posN && cannibal3Pos == cannibal3.boattop_posN)
            {
                photog3.transform.position = Vector3.MoveTowards(photog3.transform.position, photog3.getSouthBeachPos(), speed * Time.deltaTime);
                cannibal3.transform.position = Vector3.MoveTowards(cannibal3.transform.position, cannibal3.getSouthBeachPos(), speed * Time.deltaTime);
            }

            if (photog3Pos == photog3.boatbot_posN && photog1Pos == photog1.boattop_posN)
            {
                photog3.transform.position = Vector3.MoveTowards(photog3.transform.position, photog3.getSouthBeachPos(), speed * Time.deltaTime);
                photog1.transform.position = Vector3.MoveTowards(photog1.transform.position, photog1.getSouthBeachPos(), speed * Time.deltaTime);
            }

            if (photog3Pos == photog3.boatbot_posN && photog2Pos == photog2.boattop_posN)
            {
                photog3.transform.position = Vector3.MoveTowards(photog3.transform.position, photog3.getSouthBeachPos(), speed * Time.deltaTime);
                photog2.transform.position = Vector3.MoveTowards(photog2.transform.position, photog2.getSouthBeachPos(), speed * Time.deltaTime);
            }

        }
        
    }
}
