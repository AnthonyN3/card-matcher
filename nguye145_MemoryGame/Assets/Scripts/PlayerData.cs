﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//This class is a static class used to pass Data accross between scenes
public static class PlayerData 
{   
    //The number of unique cards is defaulted to 6
    public static int numOfCards = 6;
    //The total game time
    public static float gameTime = 0f;
    //The score after a game
    public static int gameScore = 0;

}
