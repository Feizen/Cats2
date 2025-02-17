﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Furniture : MonoBehaviour
{
    public GameObject TopHudHide;
    public GameObject BotHudHide;
    public static string zoomActive = "n";
    public static string partyDone = "n";
    public GameObject furniture;
    public GameObject backGround;
    public GameObject rewardWindow;
    public GameObject timer;


    public void openFurniture()
    {
        closeLockedRooms();
        TopHudHide.SetActive(false);
        BotHudHide.SetActive(false);
        furniture.SetActive(true);
        zoomActive = "y";
        backGround.SetActive(false);
    }

    public void closeFurniture()
    {
        TopHudHide.SetActive(true);
        BotHudHide.SetActive(true);
        furniture.SetActive(false);
        zoomActive = "n";
        backGround.SetActive(true);
    }

    public void startParty()
    {
        rewardWindow.SetActive(false);
        closeLockedRooms();
        TopHudHide.SetActive(false);
        BotHudHide.SetActive(false);
        zoomActive = "y";
        backGround.SetActive(false);
        timer.SetActive(true);
    }

    public void closeLockedRooms()
    {
        GameObject[] closedRoom;
        closedRoom = GameObject.FindGameObjectsWithTag("ClosedRoom");
        foreach (GameObject i in closedRoom)
        {
            i.SetActive(false);
        }
    }

    public void openLockedRooms()
    {
        GameObject[] closedRoom2;
        closedRoom2 = GameObject.FindGameObjectsWithTag("ClosedRoom");
        foreach (GameObject b in closedRoom2)
        {
            b.SetActive(true);
        }
    }

    public void RestartGame()
    {
        PlayerPrefs.DeleteAll();
        PartyStarted.partyDone = "n";
        SceneManager.LoadScene(0);
    }
}
