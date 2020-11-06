using System.Collections;
using System.Collections.Generic;
using System.Net;
using UnityEngine;

public class MyAdventure : MonoBehaviour
{


    private enum States
    {
        Story1,
        Story2,
        Story3,
        Story41,
        Story42,
        Story5,
        Story6,
        Story71,
        Story72,
        Story8,
        Story91,
        Story92
    }
    private States currentState = States.Story1;
    
    void Start()
    {
        ShowMainMenu();
    }

    void ShowMainMenu()
    {
        Terminal.ClearScreen();
        Terminal.WriteLine("This is Russian Roulette");
        Terminal.WriteLine("Please insert 'start' to start the game!");
    }

    void Story1()
    {
        Terminal.ClearScreen();
        Terminal.WriteLine("Its currently 9PM, Friday. You decided to hop on and play some Counter Strike : Global Offensive");
        Terminal.WriteLine("None of your buddies are currently available, so you decide to hop in a match with randoms.");
        Terminal.WriteLine("Please insert 'continue' to head on with the story.");
    }
    void Story2()
    {
        Terminal.ClearScreen();
        Terminal.WriteLine("You've joined the match, it appears you are in a lobby with a bunch of Russians as your teammates");
        Terminal.WriteLine("You hear some Russian words here and there, but dont quite understand what it means.");
        Terminal.WriteLine("Please insert 'continue' to head on with the story.");
        currentState = States.Story2;
    }
    void Story3()
    {
        Terminal.ClearScreen();
        Terminal.WriteLine("It appears after the first round you have accidently shot one of your Russian teammates");
        Terminal.WriteLine("You put it off like nothing happens, but your teammate seems to be swearing in Russian for you in the past 30 seconds");
        Terminal.WriteLine("Do you wish to try and communicate with your Russian teammate?");
        Terminal.WriteLine("Please insert 'yes' or 'no'.");
        currentState = States.Story3;
    }
    void Story41()
    {
        Terminal.ClearScreen();
        Terminal.WriteLine("It appears you have tried to communicate with your Russian teammate.");
        Terminal.WriteLine("The russian teammate is making you angry with his swearing, so you decide to kill him in-game");
        Terminal.WriteLine("The system has detected you are attacking an enemy and has votekicked you from the game");
        Terminal.WriteLine("The end.");
        currentState = States.Story41;
    }

    void Story42()
    {
        Terminal.ClearScreen();
        Terminal.WriteLine("It appears you've decided to ignore your Russian teammate.");
        Terminal.WriteLine("He eventually stops with the swearing, leaving you able to focus on the game again");
        currentState = States.Story42;
    }

    void Story5()
    {
        Terminal.ClearScreen();
        Terminal.WriteLine("");
        Terminal.WriteLine("You hear more rumbling in his microphone and eventually he leaves the match");
        Terminal.WriteLine("You put it off like it was nothing, and just act like he ragequit. You think...");
        Terminal.WriteLine("Please insert 'continue' to head on with the story");
        currentState = States.Story5;
    }

    void Story6()
    {
        Terminal.ClearScreen();
        Terminal.WriteLine("You hear the door bang downstairs, you wonder what it is.");
        Terminal.WriteLine("The lights flicker on and off, and your dog starts barking");
        Terminal.WriteLine("You expected no visitation that day, do you decide to to look downstairs?");
        Terminal.WriteLine("Please insert 'yes' or 'no'.");
        currentState = States.Story6;
    }

    void Story71()
    {
        Terminal.ClearScreen();
        Terminal.WriteLine("You decide to look downstairs, you see the Russian guy standing right in front of you");
        Terminal.WriteLine("He was just trying to be nice, but you die because of shock.");
        Terminal.WriteLine("The end");
        currentState = States.Story71;
    }

    void Story72()
    {
        Terminal.ClearScreen();
        Terminal.WriteLine("You decide to ignore it, you hear your sister call your name. She was home for a few minutes to pick up the keys she forgot.");
        Terminal.WriteLine("She leaves the house, as your match of swearing Russians end, you decide to go downstairs to have a drink");
        Terminal.WriteLine("Please insert 'continue' to head on with the story");
        currentState = States.Story72;
    }

    void Story8()
    {
        Terminal.ClearScreen();
        Terminal.WriteLine("Once downstairs, you hear weird mumbling noises coming from your basement");
        Terminal.WriteLine("Do you decide to take a look in your basement?");
        Terminal.WriteLine("Please insert 'yes' or 'no'.");
        currentState = States.Story8;
    }

    void Story91()
    {
        Terminal.ClearScreen();
        Terminal.WriteLine("You slowly open the door to your basement.");
        Terminal.WriteLine("You hear a loud bang, and see your life flashing by. It turns out you have been shot by the Russian invading your house.");
        Terminal.WriteLine("The end");
        currentState = States.Story91;
    }

    void Story92()
    {
        Terminal.ClearScreen();
        Terminal.WriteLine("Instead of opening the door, you decide to call the police.");
        Terminal.WriteLine("The police turns up quickly, and open up the basement door.");
        Terminal.WriteLine("It turns out the Russian was hiding in your basement, attempting to kill you.");
        Terminal.WriteLine("You survived.");
        currentState = States.Story92;
    }

    void OnUserInput(string input)
    {
        if (input.ToUpper() == "START")
            Story1();
        switch (currentState)
        {
            case States.Story1:
                if (input.ToUpper() == "CONTINUE")
                {
                    Story2();
                }
                break;
            case States.Story2:
                if (input.ToUpper() == "CONTINUE")
                {
                    Story3();
                }
                break;
            case States.Story3:
                if (input.ToUpper() == "YES")
                {
                    Story41();
                } else if (input.ToUpper() == "NO")
                {
                    Story42();
                }
                break;
            case States.Story41:
                currentState = States.Story1;
                Story1();
                break;
            case States.Story42:
                if (input.ToUpper() == "CONTINUE")
                {
                    Story5();
                }
                break;
            case States.Story5:
                if (input.ToUpper() == "CONTINUE")
                {
                    Story6();
                }
                break;
            case States.Story6:
                if (input.ToUpper() == "YES")
                {
                    Story71();
                } else if (input.ToUpper() == "NO")
                {
                    Story72();
                }
                break;
            case States.Story71:
                currentState = States.Story1;
                Story1();
                break;
            case States.Story72:
                if (input.ToUpper() == "CONTINUE")
                {
                    Story8();
                }
                break;
            case States.Story8:
                if (input.ToUpper() == "YES")
                {
                    Story91();
                } else if (input.ToUpper() == "NO")
                {
                    Story92();
                }
                break;
            case States.Story91:
                currentState = States.Story1;
                Story1();
                break;
            case States.Story92:
                currentState = States.Story1;
                Story1();
                break;
                


            
        }
    }
    // Update is called once per frame
    void Update()
    {

    }
}