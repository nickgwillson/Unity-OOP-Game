using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SideWalls : MonoBehaviour     //this defines the behavior of the wall, this class uses multiple inheritance
{                                           //The inheritnce is done with the below code as well as through the unity UI
                                            // in the unity UI, which you can see on my demo, I can use this code as a parent to the other 'walls'
                                            // inside unity I can write small code for the child classes of this code in order to change the behaviors of the different characcters

    void OnTriggerEnter2D(Collider2D whoCollided)
    {
        if (whoCollided.name == "Ball")
        {
            string wallType = transform.name;           //here we call the child class of 'sidewalls', we call this class when the ball colides with something. One the ball collides with one of the walls...
                                                       // we use the line transform.name to call the child classes, each which have their own behaviors in the unity UI. in short each wall inherits this code, 
                                                       // but have different characteristics. In this code right here we check the walls and their respective behaviors.

            GameManager.ScoreBoard(wallType);       // we notify the gamemanager scoreboard of the wall type that was given, depending on which wall was hit we will add point to respective player

            whoCollided.gameObject.SendMessage("GameRestart", 1.0f, SendMessageOptions.RequireReceiver);    //here we call 'game restart' from the game manager, and call an observer which will update the respective 
                                                                                                            //classes

        }
    }
}

