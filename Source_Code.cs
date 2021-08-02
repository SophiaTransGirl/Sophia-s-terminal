using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class game : MonoBehaviour
{
    //inputs
    public InputField Field;

    //text
    public Text txt;

    //images
    public Image catGirl;

    //buttons
    public Button clear;

    //strings and/or commands
    public string remove = "Print:";
    public string pn = null;
    public string pa = null;

    //bools
    public bool gameing = false;

    //floats
    public float yesOrNo = 0f;
    public float yes = 0f;
    public float no = 0f;
    public float isUnsure = 0f;


    private void Update()
    {
        yes = Random.Range(1, 5);
        no = Random.Range(1, 5);
        yesOrNo = Random.Range(1, 5);
        clear.onClick.AddListener(clearthings);

        if (Input.GetKeyDown(KeyCode.Return) && gameing == false)
        {
            //varibles
            if (Field.text.Contains("{name}"))
            {
                Field.text = Field.text.Replace("{name}", pn);
            }
            if (Field.text.Contains("{age}"))
            {
                Field.text = Field.text.Replace("{age}", pa);
            }


            //commands
            if (Field.text.Contains("Hello World!"))
            {
                txt.text = ($"Hello I am {pn}, and I am {pa} years old!");
                Field.text = null;
            }
            if (Field.text.Contains("Print:"))
            {
                Field.text = Field.text.Replace(remove, "");
                txt.text += Field.text;
                Field.text = null;
            }
            if (Field.text.Contains("Return:"))
            {
                Field.text = Field.text.Replace("Retrun:", "");
                txt.text += $"\n";
                Field.text = "Added a line break!";
            }
            if (Field.text.Contains("Commands:"))
            {
                Field.text = Field.text.Replace("Commands:", "");
                txt.text += $"\n\nhere is a list of commands(there are some easter egg commands that are not listed here ;) ) \nIntro:\nPrint:\nReturn:\nCommands:\nAge:\nName:\nGame Start:\nStop:\nEdit:\n8B:\nRandomNumber:\n\nYou can type 'HelpUses:' to see how you use the commands!\n\nI Hope you enojoy!";
                Field.text = "Added a line break!";
            }
            if (Field.text.Contains("Age:"))
            {
                Field.text = Field.text.Replace("Age:", "");
                txt.text += $"You are {pa} years old!";
                Field.text = null;
            }
            if (Field.text.Contains("Name:"))
            {
                Field.text = Field.text.Replace("Name:", "");
                txt.text += $"Your name is {pn}!";
                Field.text = null;
            }
            if (Field.text.Contains("Edit:"))
            {
                Field.text = "Print:" + txt.text;
                txt.text = null;
            }
            if (Field.text.Contains("Game Start:"))
            {
                txt.text = $"Please tell me your name and age, by doing 'Name:' for your name and 'Age:' for your age!\n type 'Stop' to go back to normal mode!";
                gameing = true;
            }
            if (Field.text.Contains("RandomNumber:"))
            {
                txt.text += Random.Range(1, 100).ToString();
                Field.text = null;
            }
            if (Field.text.Contains("8B:"))
            {
                if (yesOrNo == yes)
                {
                    txt.text += $"\nI say yes";
                    isUnsure -= 1f;
                    Field.text = null;
                }
                else isUnsure += 1f;
                if (yesOrNo == no)
                {
                    txt.text += $"\nI predict no";
                    isUnsure -= 1f;
                    Field.text = null;
                }
                else isUnsure += 1f;
                if (isUnsure == 2)
                {
                    txt.text += $"\nI am unsure, please ask again";
                    Field.text = null;
                    isUnsure = 0f;
                }
            }
            if (Field.text.Contains("Intro:"))
            {
                txt.text = "Hello Welcome to 'SOPHIA'S TERMINAL'!, Type 'Commands:' To see a list of CURENT Commands!!!";
                Field.text = null;
            }
            if (Field.text.Contains("WHAT DOES THE FOX SAY"))
            {
                Field.text = "https://www.youtube.com/watch?v=jofNR_WkoCE";
                txt.text = "Click this link!";
            }
            if (Field.text.Contains("CAT GIRL"))
            {
                catGirl.gameObject.SetActive(true);
                Field.text = "NYAAAAAAA";
            }

        }
        if (gameing == true)
        {
            if (Input.GetKeyDown(KeyCode.Return))
            {
                if (Field.text.Contains("Age:"))
                {
                    Field.text = Field.text.Replace("Age:", "");
                    pa = Field.text;
                    txt.text += $"You are {pa} years old!";
                    Field.text = null;
                }
                if (Field.text.Contains("Name:"))
                {
                    Field.text = Field.text.Replace("Name:", "");
                    pn = Field.text;
                    txt.text += $"Your name is {pn}!";
                    Field.text = null;
                }
                if (Field.text.Contains("Stop:"))
                {
                    Field.text = Field.text.Replace("Stop:", "");
                    txt.text = "Back To Normal Terminal!";
                    gameing = false;
                    Field.text = null;
                }

            }
        }
    }
    private void clearthings()
    {
        txt.text = null;
    }


    public void games()
    {
        
    }
}
