using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameSetting : MonoBehaviour
{
    public Toggle HeroPlayer1, HeroPlayer2, HeroPlayer3, HeroPlayer4, HeroCPU;
    public Toggle BarbarianPlayer1, BarbarianPlayer2, BarbarianPlayer3, BarbarianPlayer4, BarbarianCPU;
    public Toggle WizardPlayer1, WizardPlayer2, WizardPlayer3, WizardPlayer4, WizardCPU;
    public Toggle KnightPlayer1, KnightPlayer2, KnightPlayer3, KnightPlayer4, KnightCPU;

    public void ReadToggle() 
    {
        //Hero
        if (HeroPlayer1.isOn)
        {
            SaveSetting.tipeplayer[0] = "Player1";
            BarbarianPlayer1.enabled = false;
            WizardPlayer1.enabled = false;
            KnightPlayer1.enabled = false;
        }
        else if (HeroPlayer2.isOn)
        {
            SaveSetting.tipeplayer[0] = "Player2";
            BarbarianPlayer2.enabled = false;
            WizardPlayer2.enabled = false;
            KnightPlayer2.enabled = false;
        }
        else if (HeroPlayer3.isOn)
        {
            SaveSetting.tipeplayer[0] = "Player3";
            BarbarianPlayer3.enabled = false;
            WizardPlayer3.enabled = false;
            KnightPlayer3.enabled = false;
        }
        else if (HeroPlayer4.isOn)
        {
            SaveSetting.tipeplayer[0] = "Player4";
            BarbarianPlayer4.enabled = false;
            WizardPlayer4.enabled = false;
            KnightPlayer4.enabled = false;
        }
        else if (HeroCPU.isOn) 
        {
            SaveSetting.tipeplayer[0] = "CPU";
        }

        //Knight
        if (KnightPlayer1.isOn)
        {
            SaveSetting.tipeplayer[1] = "Player1";
            BarbarianPlayer1.enabled = false;
            WizardPlayer1.enabled = false;
            HeroPlayer1.enabled = false;
        }
        else if (KnightPlayer2.isOn) 
        {
            SaveSetting.tipeplayer[1] = "Player2";
            BarbarianPlayer2.enabled = false;
            WizardPlayer2.enabled = false;
            HeroPlayer2.enabled = false;
        }
        else if (KnightPlayer3.isOn)
        {
            SaveSetting.tipeplayer[1] = "Player3";
            BarbarianPlayer3.enabled = false;
            WizardPlayer3.enabled = false;
            HeroPlayer3.enabled = false;
        }
        else if (KnightPlayer4.isOn)
        {
            SaveSetting.tipeplayer[1] = "Player4";
            BarbarianPlayer4.enabled = false;
            WizardPlayer4.enabled = false;
            HeroPlayer4.enabled = false;
        }
        else if (KnightCPU.isOn)
        {
            SaveSetting.tipeplayer[1] = "CPU";
        }
        //Wizard
        if (WizardPlayer1.isOn)
        {
            SaveSetting.tipeplayer[2] = "Player1";
            BarbarianPlayer1.enabled = false;
            KnightPlayer1.enabled = false;
            HeroPlayer1.enabled = false;
        }
        else if (WizardPlayer2.isOn)
        {
            SaveSetting.tipeplayer[2] = "Player2";
            BarbarianPlayer2.enabled = false;
            WizardPlayer2.enabled = false;
            HeroPlayer2.enabled = false;
        }
        else if (WizardPlayer3.isOn)
        {
            SaveSetting.tipeplayer[2] = "Player3";
            BarbarianPlayer3.enabled = false;
            KnightPlayer3.enabled = false;
            HeroPlayer3.enabled = false;
        }
        else if (WizardPlayer4.isOn)
        {
            SaveSetting.tipeplayer[2] = "Player4";
            BarbarianPlayer4.enabled = false;
            KnightPlayer4.enabled = false;
            HeroPlayer4.enabled = false;
        }
        else if (WizardCPU.isOn)
        {
            SaveSetting.tipeplayer[2] = "CPU";
        }
        //Barbarian
        if (BarbarianPlayer1.isOn)
        {
            SaveSetting.tipeplayer[3] = "Player1";
            BarbarianPlayer1.enabled = false;
            WizardPlayer1.enabled = false;
            HeroPlayer1.enabled = false;
        }
        else if (BarbarianPlayer2.isOn)
        {
            SaveSetting.tipeplayer[3] = "Player2";
            KnightPlayer2.enabled = false;
            WizardPlayer2.enabled = false;
            HeroPlayer2.enabled = false;
        }
        else if ( BarbarianPlayer3.isOn)
        {
            SaveSetting.tipeplayer[3] = "Player3";
           KnightPlayer3.enabled = false;
            WizardPlayer3.enabled = false;
            HeroPlayer3.enabled = false;
        }
        else if (BarbarianPlayer4.isOn)
        {
            SaveSetting.tipeplayer[3] = "Player4";
            KnightPlayer4.enabled = false;
            WizardPlayer4.enabled = false;
            HeroPlayer4.enabled = false;
        }
        else if (KnightCPU.isOn)
        {
            SaveSetting.tipeplayer[3] = "CPU";
        }
    }
    public void StartGame() 
    {
        ReadToggle();
        SceneLoad.Load(SceneLoad.Scene.Game1);
    }
}
public static class SaveSetting 
{
    public static string[] tipeplayer = new string[4];
    
}
