using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    public Dadu dadu;

    int activePlayer, angkaDadu;
    public GameObject rollDiceButton1, rollDiceButton2, rollDiceButton3, rollDiceButton4;

    [System.Serializable]
    public class Player
    {
        public PlayerMovement playerMovement;

        public string namaPlayer;
        public enum TipePlayer
            {
                Player1,
                Player2,
                Player3,
                Player4,
                CPU
            }
        public TipePlayer tipePlayer;
    }
    public List<Player> playerList = new List<Player>();

    public enum States 
    {
        WAITING,
        ROLL_DICE,
        JAWAB_QUIZ,
        SWITCH_Player
    }
    public States state;

    void Awake()
    {
        instance = this;
    }
    void Start()
    {
        Button1Active(false);
        Button2Active(false);
        Button3Active(false);
        Button4Active(false);
    }

    void Update()
    {
        if (playerList[activePlayer].tipePlayer == Player.TipePlayer.CPU)
        {
            switch (state)
            {
                case States.WAITING:
                    //ga ngapa-ngapain
                    break;
                case States.ROLL_DICE:
                    StartCoroutine(TungguRoll());
                    print("CPU maju :"+angkaDadu);
                    state = States.WAITING;
                    break;
                case States.JAWAB_QUIZ:
                    state = States.JAWAB_QUIZ;
                    break;
                case States.SWITCH_Player:
                    activePlayer++;
                    activePlayer %= playerList.Count;
                    state = States.ROLL_DICE;
                    break;
            }
        }
        if (playerList[activePlayer].tipePlayer == Player.TipePlayer.Player1) 
        {
            switch (state)
            {
                case States.WAITING:
                    //ga ngapa-ngapain
                    break;
                case States.ROLL_DICE:
                    Button1Active(true);
                    state = States.WAITING;
                    break;
                case States.JAWAB_QUIZ:
                    Button1Active(false);
                    state = States.JAWAB_QUIZ;
                    break;
                case States.SWITCH_Player:
                    activePlayer++;
                    activePlayer %= playerList.Count;
                    state = States.ROLL_DICE;
                    break;
            }
        }
        if (playerList[activePlayer].tipePlayer == Player.TipePlayer.Player2)
        {
            switch (state)
            {
                case States.WAITING:
                    //ga ngapa-ngapain
                    break;
                case States.ROLL_DICE:
                    Button2Active(true);
                    state = States.WAITING;
                    break;
                case States.JAWAB_QUIZ:
                    Button2Active(false);
                    state = States.JAWAB_QUIZ;
                    break;
                case States.SWITCH_Player:
                    activePlayer++;
                    activePlayer %= playerList.Count;
                    state = States.ROLL_DICE;
                    break;
            }
        }
        if (playerList[activePlayer].tipePlayer == Player.TipePlayer.Player3)
        {
            switch (state)
            {
                case States.WAITING:
                    //ga ngapa-ngapain
                    break;
                case States.ROLL_DICE:
                    Button3Active(true);
                    state = States.WAITING;
                    break;
                case States.JAWAB_QUIZ:
                    Button3Active(false);
                    state = States.JAWAB_QUIZ;
                    break;
                case States.SWITCH_Player:
                    activePlayer++;
                    activePlayer %= playerList.Count;
                    state = States.ROLL_DICE;
                    break;
            }
        }
        if (playerList[activePlayer].tipePlayer == Player.TipePlayer.Player4)
        {
            switch (state)
            {
                case States.WAITING:
                    //ga ngapa-ngapain
                    break;
                case States.ROLL_DICE:
                    Button4Active(true);
                    state = States.WAITING;
                    break;
                case States.JAWAB_QUIZ:
                    Button4Active(false);
                    state = States.JAWAB_QUIZ;
                    break;
                case States.SWITCH_Player:
                    activePlayer++;
                    activePlayer %= playerList.Count;
                    state = States.ROLL_DICE;
                    break;
            }
        }
    }
    IEnumerator TungguRoll()
    {
        yield return new WaitForSeconds(3);
        dadu.RollDadu();
    }
    public void RollAngka(int diceNumber)
    {
        
        angkaDadu = diceNumber;
        Debug.Log("angka dadu : "+angkaDadu);
        //Ganti Giliran
        playerList[activePlayer].playerMovement.Giliran(angkaDadu);
    }

    void Button1Active(bool on)
    {
        rollDiceButton1.SetActive(on);
    }
    void Button2Active(bool on)
    {
        rollDiceButton2.SetActive(on);
    }
    void Button3Active(bool on)
    {
        rollDiceButton3.SetActive(on);
    }
    void Button4Active(bool on)
    {
        rollDiceButton4.SetActive(on);
    }

    public void Manual1RollDice()
    {
        Button1Active(false);
        StartCoroutine(TungguRoll());
    }
    public void Manual2RollDice()
    {
        Button2Active(false);
        StartCoroutine(TungguRoll());
    }
    public void Manual3RollDice()
    {
        Button3Active(false);
        StartCoroutine(TungguRoll());
    }
    public void Manual4RollDice()
    {
        Button4Active(false);
        StartCoroutine(TungguRoll());
    }
}
