using UnityEngine;
using System.Collections;

public class GameMagic : MonoBehaviour {

    public boatcrossnorth boat;
    public float width = 1, height = 1;
    public float x, y, z;
    public float speed;
    public Vector3 southBeachPos, northBeachPos;
    //public Vector3[] southBeachArray = new Vector3[5];
    //public Vector3[] northBeachArray = new Vector3[5];
    //public static Vector3[] southBeachArray = new[] { new Vector3(0f, 0f, 0f), new Vector3(1f, 1f, 1f), new Vector3(2f,2f,2f) };
    //southBeachArray[] = { new Vector2(0, 1), new Vector2(1, 0) };
    //southBeachArray[0] = (x, y, z);
    //new Vector3(1f, 1f, 1f) };
    //southBeachArray[0] = new Vector3(sb1);
    public int click_num = 0;
    public static bool topOfBoatFull = false;
    //public static bool allOfBoatFull;
    public static bool botOfBoatFull = false;
    public static bool topOfNorthBoatFull = false;
    public static bool botOfNorthBoatFull = false;
    public Vector3 boattop_pos, boatbot_pos, boattop_posN, boatbot_posN, southDock, northDock;
   // public Vector3 boatPos;
    
    public bool getTopOfBoatFull()
    {
        return topOfBoatFull;
    }
    public void setTopOfBoatFull(bool topOfBoat)
    {
        topOfBoatFull = topOfBoat;
    }
    public bool getBotOfBoatFull()
    {
        return botOfBoatFull; 
    }
    public void setBotOfBoatFull(bool botOfBoat)
    {
        botOfBoatFull = botOfBoat;
    }
    public bool getTopOfNorthBoatFull()
    {
        return topOfNorthBoatFull;
    }
    public void setTopOfNorthBoatFull(bool topOfBoatNorth)
    {
        topOfNorthBoatFull = topOfBoatNorth;
    }
    public bool getBotOfNorthBoatFull()
    {
        return botOfNorthBoatFull;
    }
    public void setBotOfNorthBoatFull(bool botOfBoatNorth)
    {
        botOfNorthBoatFull = botOfBoatNorth;
    }
    public Vector3 getBoatBottomPos()
    {
        return boatbot_pos;
    }

    public Vector3 getBoatTopPos()
    {
        return boattop_pos;
    }

    public bool getTopOfBoatFullStatus()
    {
        return topOfBoatFull;
    }
   

    public int getClickNum()
    {
        return click_num;
    }

    public void setClickNum(int clickNum)
    {
        clickNum = click_num;
    }

    public void resetClickNum()
    {
        click_num = 0;
    }
    public Vector3 getSouthBeachPos()
    {
        return southBeachPos;
    }

    public Vector3 getNorthBeachPos()
    {
        return northBeachPos;
    }

    void Start()
    {
        // set the scaling
        // Vector3 scale = new Vector3(width, height, 1f);
        // transform.localScale = scale;

        transform.position = southBeachPos;
       // boatPos = boat.transform.position;
        //boat.transform.position = southDock;

        //var cannibal = gameObject;
        //save the y axis value of gameobject
        //yAxis = gameObject.transform.position.y;
    }

    void Awake()
    {
        DontDestroyOnLoad(this.gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        DontDestroyOnLoad(this.gameObject);

       

    }

    public void attachToSouthBoat()
    {

        
        //boatPos = boat.transform.position;
        if (boat.boatPos == southDock)
        {
            if (topOfBoatFull == false && botOfBoatFull == false)
            {
                transform.position = Vector3.MoveTowards(transform.position, boattop_pos, speed * Time.deltaTime);

                topOfBoatFull = true;
            }
            else if (topOfBoatFull == true && botOfBoatFull == false)
            {
                transform.position = Vector3.MoveTowards(transform.position, boatbot_pos, speed * Time.deltaTime);


                // topOfBoatFull = false;
                botOfBoatFull = true;

            }
            else if (topOfBoatFull == true && botOfBoatFull == true)
            {
                topOfBoatFull = false;
                botOfBoatFull = false;
            }

        }

    }

    public void attachToNorthBoat()
    {
        //boatPos = boat.transform.position;
        // north boat position
        if (boat.boatPos == northDock)
        {
            if (topOfNorthBoatFull == false && botOfNorthBoatFull == false)
            {
                transform.position = Vector3.MoveTowards(transform.position, boattop_posN, speed * Time.deltaTime);

                topOfNorthBoatFull = true;


            }
            else if (topOfNorthBoatFull == true && botOfNorthBoatFull == false)
            {
                transform.position = Vector3.MoveTowards(transform.position, boatbot_posN, speed * Time.deltaTime);

                botOfNorthBoatFull = true;
                //botOfNorthBoatFull = false;


            }
            else if (topOfNorthBoatFull == true && botOfNorthBoatFull == true)
            {
                topOfNorthBoatFull = false;
                botOfNorthBoatFull = false;
            }
        }
    }
    public void OnMouseDown()
    {
        //boattopfull = !boattopfull;

        //boat.executedTime = Time.time;
        
        DontDestroyOnLoad(this.gameObject);

       // boatPos = boat.transform.position;
        if(boat.boatPos==southDock)
        {
            attachToSouthBoat();
            //if(transform.position == boattop_pos || transform.position == boatbot_pos)
            //{
             //   topOfBoatFull = false;
              //  botOfBoatFull = false;
            //}

        }
        else if(boat.boatPos == northDock)
        {
            attachToNorthBoat();
            //if(transform.position == boattop_posN || transform.position == boatbot_posN)
            //{
              //  topOfNorthBoatFull = false;
               // botOfNorthBoatFull = false;
            //}
        }
        



        /*else if (boatPos == southDock && topOfBoatFull == true && botOfBoatFull == true)
        {
            transform.position = Vector3.MoveTowards(transform.position, southBeachPos, speed * Time.deltaTime);
            if (boattop_pos == transform.position)
            {
                topOfBoatFull = false;
            }
            else if(boatbot_pos == transform.position)
            {
                botOfBoatFull = false;
            }
            
             //allOfBoatFull = false;
         }
         */
        /*
        // from north beach
               else if ((boatPos == northDock && topOfBoatFull == false && botOfBoatFull == false))
                {
                    transform.position = Vector3.MoveTowards(transform.position, boattop_posN, speed * Time.deltaTime);
                    topOfBoatFull = true;
                 

                }
                else if (boatPos == northDock && topOfBoatFull == true && allOfBoatFull == false)
                {
                    transform.position = Vector3.MoveTowards(transform.position, boatbot_posN, speed * Time.deltaTime);
                    allOfBoatFull = true;

                }
                else if (boatPos == northDock && topOfBoatFull == true && allOfBoatFull == true)
                {
                    transform.position = Vector3.MoveTowards(transform.position, northBeachPos, speed * Time.deltaTime);
                    topOfBoatFull = false;
                    allOfBoatFull = false;
                }

            }
          */
        /*
            if (boattopnorth == true) //&& click_num == 0  )
                {
                    transform.position = Vector3.MoveTowards(transform.position, boatbot_pos, speed * Time.deltaTime);
                    click_num++;

                    boattopnorth = false;

               }
               else if (boattopnorth == false) //&& click_num == 0)
                {
                    transform.position = Vector3.MoveTowards(transform.position, boattop_pos, speed * Time.deltaTime);
                    click_num++;
                    boattopnorth = true;
                }
            }

        */
    }

}
