using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ModMenu2 : MonoBehaviour {
    public static Rect MoveMenu = new Rect(10, 10, 10, 10);
    public static float MenuResize = 4;
    public static float ButtonResize = 0;
    public static float ButtonResizeAssistHeightRowOne = 0;
    public static float ButtonResizeAssistHeightRowTwo = 0;
    public static float ButtonResizeAssistHeightRowThree = 0;
    public static float ButtonResizeAssistHeightRowFour = 0;
    public static float ButtonResizeAssistHeightRowFive = 0;
    public static float BoxResizeAssistWidth = 0;
    public static float BoxResizeAssistHeight = 0;
    public static float BoxPositionAssistY = 0;
    public static bool MenuResizex1 = false;
    public static float MenuResizex1ButtonX = 0;
    public static bool MenuResizex2 = false;
    public static float MenuResizex2ButtonX = 0;
    public static bool MenuResizex3 = false;
    public static float MenuResizex3ButtonX = 0;
    public static float MenuResizex1x2x3ButtonY = 0;
    public static bool MenuResizeDefault = false;
    public static float MenuResizeDefaultButton = 0;
    public static bool IsOpen = false;
    public static string IsOpenText = "<color=white><size=" + MenuResize + 1 + ">OPEN</size></color>";
    public static bool Hack1Enabled = false;
    public static string Hack1Text = "<size=" + MenuResize + 1 + ">HackOne <color=red>OFF</color></size>";
    public static bool Hack2Enabled = false;
    public static string Hack2Text = "<size=" + MenuResize + 1 + ">HackTwo <color=red>OFF</color></size>";
    public static bool Hack3Enabled = false;
    public static string Hack3Text = "<size=" + MenuResize + 1 + ">HackThree <color=red>OFF</color></size>";
    public static bool Hack4Enabled = false;
    public static string Hack4Text = "<size=" + MenuResize + 1 + ">HackFour <color=red>OFF</color></size>";
    public static bool Hack5Enabled = false;
    public static string Hack5Text = "<size=" + MenuResize + 1 + ">HackFive <color=red>OFF</color></size>";
    public static bool Hack6Enabled = false;
    public static string Hack6Text = "<size=" + MenuResize + 1 + ">HackSix <color=red>OFF</color></size>";
    public static bool Hack7Enabled = false;
    public static string Hack7Text = "<size=" + MenuResize + 1 + ">HackSeven <color=red>OFF</color></size>";
    public static bool Hack8Enabled = false;
    public static string Hack8Text = "<size=" + MenuResize + 1 + ">HackEight <color=red>OFF</color></size>";
    public static bool Hack9Enabled = false;
    public static string Hack9Text = "<size=" + MenuResize + 1 + ">HackNine <color=red>OFF</color></size>";
    public static bool Hack10Enabled = false;
    public static string Hack10Text = "<size=" + MenuResize + 1 + ">HackTen <color=red>OFF</color></size>";

    private static void ModMenu()
    {
        GUI.backgroundColor = Color.black;
        if (GUI.Button(new Rect(40, 41 + MenuResizex1x2x3ButtonY, MenuResize + 216 - ButtonResize, MenuResize + 95 - ButtonResize), IsOpenText))
        {
            IsOpen = !IsOpen;
            if (IsOpen == true) { IsOpenText = "<color=white><size=" + MenuResize + 1 + ">CLOSE</size></color>"; }
            if (IsOpen == false) { IsOpenText = "<color=white><size=" + MenuResize + 1 + ">OPEN</size></color>"; }
        }
        if (IsOpen)
        {
            //Three of them to make bacground darker
            GUI.backgroundColor = Color.black;
            GUI.Box(new Rect(40, 140 - BoxPositionAssistY, 700 - BoxResizeAssistWidth, 600 - BoxResizeAssistHeight), "");
            GUI.Box(new Rect(40, 140 - BoxPositionAssistY, 700 - BoxResizeAssistWidth, 600 - BoxResizeAssistHeight), "<size=" + MenuResize + 0.5f + "><color=cyan>Made With <3 By @ITS_N1GH7OWL\nCreated For IOSGODS.COM</color></size>");
            /*All Buttons Below*/
            if (GUI.Button(new Rect(40, 240 - ButtonResizeAssistHeightRowOne, MenuResize + 346 - ButtonResize, MenuResize + 96 - ButtonResize), Hack1Text))
            {
                Hack1Enabled = !Hack1Enabled;
            }
            if (GUI.Button(new Rect(390 - ButtonResize, 240 - ButtonResizeAssistHeightRowOne, MenuResize + 346 - ButtonResize, MenuResize + 96 - ButtonResize), Hack2Text))
            {
                Hack2Enabled = !Hack2Enabled;
            }
            if (GUI.Button(new Rect(40, 340 - ButtonResizeAssistHeightRowTwo, MenuResize + 346 - ButtonResize, MenuResize + 96 - ButtonResize), Hack3Text))
            {
                Hack3Enabled = !Hack3Enabled;
            }
            if (GUI.Button(new Rect(390 - ButtonResize, 340 - ButtonResizeAssistHeightRowTwo, MenuResize + 346 - ButtonResize, MenuResize + 96 - ButtonResize), Hack4Text))
            {
                Hack4Enabled = !Hack4Enabled;
            }
            if (GUI.Button(new Rect(40, 440 - ButtonResizeAssistHeightRowThree, MenuResize + 346 - ButtonResize, MenuResize + 96 - ButtonResize), Hack5Text))
            {
                Hack5Enabled = !Hack5Enabled;
            }
            if (GUI.Button(new Rect(390 - ButtonResize, 440 - ButtonResizeAssistHeightRowThree, MenuResize + 346 - ButtonResize, MenuResize + 96 - ButtonResize), Hack6Text))
            {
                Hack6Enabled = !Hack6Enabled;
            }
            if (GUI.Button(new Rect(40, 540 - ButtonResizeAssistHeightRowFour, MenuResize + 346 - ButtonResize, MenuResize + 96 - ButtonResize), Hack7Text))
            {
                Hack7Enabled = !Hack7Enabled;
            }
            if (GUI.Button(new Rect(390 - ButtonResize, 540 - ButtonResizeAssistHeightRowFour, MenuResize + 346 - ButtonResize, MenuResize + 96 - ButtonResize), Hack8Text))
            {
                Hack8Enabled = !Hack8Enabled;
            }
            if (GUI.Button(new Rect(40, 640 - ButtonResizeAssistHeightRowFive, MenuResize + 346 - ButtonResize, MenuResize + 96 - ButtonResize), Hack9Text))
            {
                Hack9Enabled = !Hack9Enabled;
            }
            if (GUI.Button(new Rect(390 - ButtonResize, 640 - ButtonResizeAssistHeightRowFive, MenuResize + 346 - ButtonResize, MenuResize + 96 - ButtonResize), Hack10Text))
            {
                Hack10Enabled = !Hack10Enabled;
            }
            /*All Resizing Components Are Here*/
            if (GUI.Button(new Rect(260 - MenuResizex1ButtonX, 40 + MenuResizex1x2x3ButtonY, MenuResize + 96 - ButtonResize, MenuResize + 96 - ButtonResize), "<color=white><size=" + MenuResize + 0 + ">x1</size></color>"))
            {
                MenuResize = 1;
                ButtonResize = 50;
                ButtonResizeAssistHeightRowOne = 115;
                ButtonResizeAssistHeightRowTwo = 170;
                ButtonResizeAssistHeightRowThree = 225;
                ButtonResizeAssistHeightRowFour = 280;
                ButtonResizeAssistHeightRowFive = 335;
                BoxResizeAssistWidth = 103;
                BoxResizeAssistHeight = 332.5f;
                MenuResizex1ButtonX = 54f;
                MenuResizex2ButtonX = 108f;
                MenuResizex3ButtonX = 162;
                MenuResizex1x2x3ButtonY = 0;
                MenuResizeDefaultButton = 216f;
                BoxPositionAssistY = 55;
            }
            if (GUI.Button(new Rect(360 - MenuResizex2ButtonX, 40 + MenuResizex1x2x3ButtonY, MenuResize + 96 - ButtonResize, MenuResize + 96 - ButtonResize), "<color=white><size=" + MenuResize + 0 + ">x2</size></color>"))
            {
                MenuResize = 2;
                ButtonResize = 37.5f;
                ButtonResizeAssistHeightRowOne = 80;
                ButtonResizeAssistHeightRowTwo = 120;
                ButtonResizeAssistHeightRowThree = 160;
                ButtonResizeAssistHeightRowFour = 200;
                ButtonResizeAssistHeightRowFive = 240;
                BoxResizeAssistWidth = 76;
                BoxResizeAssistHeight = 240;
                MenuResizex1ButtonX = 40f;
                MenuResizex2ButtonX = 80f;
                MenuResizex3ButtonX = 120f;
                MenuResizex1x2x3ButtonY = 0;
                MenuResizeDefaultButton = 160f;
                BoxPositionAssistY = 40;
            }
            if (GUI.Button(new Rect(460 - MenuResizex3ButtonX, 40 + MenuResizex1x2x3ButtonY, MenuResize + 96 - ButtonResize, MenuResize + 96 - ButtonResize), "<color=white><size=" + MenuResize + 0 + ">x3</size></color>"))
            {
                MenuResize = 3;
                ButtonResize = 25;
                ButtonResizeAssistHeightRowOne = 47;
                ButtonResizeAssistHeightRowTwo = 75;
                ButtonResizeAssistHeightRowThree = 101;
                ButtonResizeAssistHeightRowFour = 127;
                ButtonResizeAssistHeightRowFive = 155;
                BoxResizeAssistWidth = 50;
                BoxResizeAssistHeight = 155f;
                MenuResizex1ButtonX = 26f;
                MenuResizex2ButtonX = 52f;
                MenuResizex3ButtonX = 78f;
                MenuResizex1x2x3ButtonY = 0;
                MenuResizeDefaultButton = 104f;
                BoxPositionAssistY = 26;
            }
            if (GUI.Button(new Rect(560 - MenuResizeDefaultButton, 40 + MenuResizex1x2x3ButtonY, MenuResize + 176 - ButtonResize, MenuResize + 96 - ButtonResize), "<color=white><size=" + MenuResize + 0 + ">Default</size></color>"))
            {
                MenuResize = 4;
                ButtonResize = 0;
                ButtonResizeAssistHeightRowOne = 0;
                ButtonResizeAssistHeightRowTwo = 0;
                ButtonResizeAssistHeightRowThree = 0;
                ButtonResizeAssistHeightRowFour = 0;
                ButtonResizeAssistHeightRowFive = 0;
                BoxResizeAssistWidth = 0;
                BoxResizeAssistHeight = 0;
                MenuResizex1ButtonX = 0f;
                MenuResizex2ButtonX = 0f;
                MenuResizex3ButtonX = 0f;
                MenuResizex1x2x3ButtonY = 0;
                MenuResizeDefaultButton = 0f;
                BoxPositionAssistY = 0;
            }
        }
        if (Hack1Enabled) { Hack1Text = "<size=" + MenuResize + 0.5f + ">HackOne <color=green>ON</color></size>"; }
        if (!Hack1Enabled) { Hack1Text = "<size=" + MenuResize + 0.5f + ">HackOne <color=red>OFF</color></size>"; }
        if (Hack2Enabled) { Hack2Text = "<size=" + MenuResize + 0.5f + ">HackTwo <color=green>ON</color></size>"; }
        if (!Hack2Enabled) { Hack2Text = "<size=" + MenuResize + 0.5f + ">HackTwo <color=red>OFF</color></size>"; }
        if (Hack3Enabled) { Hack3Text = "<size=" + MenuResize + 0.5f + ">HackThree <color=green>ON</color></size>"; }
        if (!Hack3Enabled) { Hack3Text = "<size=" + MenuResize + 0.5f + ">HackThree <color=red>OFF</color></size>"; }
        if (Hack4Enabled) { Hack4Text = "<size=" + MenuResize + 0.5f + ">HackFour <color=green>ON</color></size>"; }
        if (!Hack4Enabled) { Hack4Text = "<size=" + MenuResize + 0.5f + ">HackFour <color=red>OFF</color></size>"; }
        if (Hack5Enabled) { Hack5Text = "<size=" + MenuResize + 0.5f + ">HackFive <color=green>ON</color></size>"; }
        if (!Hack5Enabled) { Hack5Text = "<size=" + MenuResize + 0.5f + ">HackFive <color=red>OFF</color></size>"; }
        if (Hack6Enabled) { Hack6Text = "<size=" + MenuResize + 0.5f + ">HackSix <color=green>ON</color></size>"; }
        if (!Hack6Enabled) { Hack6Text = "<size=" + MenuResize + 0.5f + ">HackSix <color=red>OFF</color></size>"; }
        if (Hack7Enabled) { Hack7Text = "<size=" + MenuResize + 0.5f + ">HackSeven <color=green>ON</color></size>"; }
        if (!Hack7Enabled) { Hack7Text = "<size=" + MenuResize + 0.5f + ">HackSeven <color=red>OFF</color></size>"; }
        if (Hack8Enabled) { Hack8Text = "<size=" + MenuResize + 0.5f + ">HackEight <color=green>ON</color></size>"; }
        if (!Hack8Enabled) { Hack8Text = "<size=" + MenuResize + 0.5f + ">HackEight <color=red>OFF</color></size>"; }
        if (Hack9Enabled) { Hack9Text = "<size=" + MenuResize + 0.5f + ">HackNine <color=green>ON</color></size>"; }
        if (!Hack9Enabled) { Hack9Text = "<size=" + MenuResize + 0.5f + ">HackNine <color=red>OFF</color></size>"; }
        if (Hack10Enabled) { Hack10Text = "<size=" + MenuResize + 0.5f + ">HackTen <color=green>ON</color></size>"; }
        if (!Hack10Enabled) { Hack10Text = "<size=" + MenuResize + 0.5f + ">HackTen <color=red>OFF</color></size>"; }
    }
    private void OnGUI()
    {
        ModMenu();
    }
}
