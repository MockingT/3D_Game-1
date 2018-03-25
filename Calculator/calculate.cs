using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class calculate : MonoBehaviour
{
    public string result = "0", str1, str2, operate; 
    //result is the equation to show to the user, str1 & str2 are the two numbers to be calculated
    float sum = 0; // the sum after calculation

    void OnGUI()
    {
        // show the result
        GUI.Box(new Rect(0, 160, 230, 30), result);

        // show the buttons of number
        if (GUI.Button(new Rect(0, 0, 50, 30), "1"))
        {
            str1 += "1";
            result += "1";
        }
        if (GUI.Button(new Rect(60, 0, 50, 30), "2"))
        {
            str1 += "2";
            result += "2";
        }
        if (GUI.Button(new Rect(120, 0, 50, 30), "3"))
        {
            str1 += "3";
            result += "3";
        }
        if (GUI.Button(new Rect(0, 40, 50, 30), "4"))
        {
            str1 += "4";
            result += "4";
        }
        if (GUI.Button(new Rect(60, 40, 50, 30), "5"))
        {
            str1 += "5";
            result += "5";
        }
        if (GUI.Button(new Rect(120, 40, 50, 30), "6"))
        {
            str1 += "6";
            result += "6";
        }
        if (GUI.Button(new Rect(0, 80, 50, 30), "7"))
        {
            str1 += "7";
            result += "7";
        }
        if (GUI.Button(new Rect(60, 80, 50, 30), "8"))
        {
            str1 += "8";
            result += "8";
        }
        if (GUI.Button(new Rect(120, 80, 50, 30), "9"))
        {
            str1 += "9";
            result += "9";
        }
        if (GUI.Button(new Rect(60, 120, 50, 30), "0"))
        {
            str1 += "0";
            result += "0";
        }
        
        // show the four operators
        if (GUI.Button(new Rect(180, 0, 50, 30), "+"))
        {
            operate = "+";
            str2 = str1;
            str1 = "";
            result += "+";
        }
        if (GUI.Button(new Rect(180, 40, 50, 30), "-"))
        {
            operate = "-";
            str2 = str1;
            str1 = "";
            result += "-";
        }
        if (GUI.Button(new Rect(180, 80, 50, 30), "*"))
        {
            operate = "*";
            str2 = str1;
            str1 = "";
            result += "*";
        }
        if (GUI.Button(new Rect(180, 120, 50, 30), "/"))
        {
            operate = "/";
            str2 = str1;
            str1 = "";
            result += "/";
        }

        // calculate the result
        if (GUI.Button(new Rect(0, 120, 50, 30), "="))
        {
            if (operate == "+")
            {
                sum = float.Parse(str2) + float.Parse(str1);
            }
            else if (operate == "-")
            {
                sum = float.Parse(str2) - float.Parse(str1);
            }
            else if (operate == "*")
            {
                sum = float.Parse(str2) * float.Parse(str1);
            }
            else if (operate == "/")
            {
                sum = float.Parse(str2) / float.Parse(str1);
            }
            result = sum.ToString();
            str1 = result;
            str2 = "";
        }

        // celar all
        if (GUI.Button(new Rect(120, 120, 50, 30), "CE"))
        {
            str1 = "";
            str2 = "";
            result = "";
            sum = 0;
        }
    }
}
