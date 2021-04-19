using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectPowers : MonoBehaviour
{
    public PlayerStats playerStats;
    public UnityEngine.UI.Text powersPointsCounter;
    public UnityEngine.UI.Text traitsPointsCounter;

    [Header("Available Powers")]
    public GameObject strength1a;
    public GameObject strength2a;
    public GameObject strength3a;

    [Header("Equipped Powers")]
    public GameObject strength1e;
    public GameObject strength2e;
    public GameObject strength3e;

    [Header("Character Creation Powers")]
    public GameObject strength1C;
    public GameObject strength2C;
    public GameObject strength3C;

    private void Start()
    {
        playerStats.points = 20;
        traitsPointsCounter.text = "Points: " + playerStats.points.ToString();
        powersPointsCounter.text = "Points: " + playerStats.points.ToString();
    }

    public void strength1Selected()
    {
        strength1a.SetActive(false);
        strength1e.SetActive(true);
        strength1C.SetActive(true);
        playerStats.AddPowers(Power.strength1);
        playerStats.points -= 1;
        traitsPointsCounter.text = "Points: " + playerStats.points.ToString();
        powersPointsCounter.text = "Points: " + playerStats.points.ToString();
    }
    public void strength2Selected()
    {
        strength2a.SetActive(false);
        strength2e.SetActive(true);
        strength2C.SetActive(true);
        playerStats.AddPowers(Power.strength2);
        playerStats.points -= 2;
        traitsPointsCounter.text = "Points: " + playerStats.points.ToString();
        powersPointsCounter.text = "Points: " + playerStats.points.ToString();
    }
    public void strength3Selected()
    {
        strength3a.SetActive(false);
        strength3e.SetActive(true);
        strength3C.SetActive(true);
        playerStats.AddPowers(Power.strength3);
        playerStats.points -= 3;
        traitsPointsCounter.text = "Points: " + playerStats.points.ToString();
        powersPointsCounter.text = "Points: " + playerStats.points.ToString();
    }
    public void strength1Deselected()
    {
        strength1a.SetActive(true);
        strength1e.SetActive(false);
        strength1C.SetActive(false);
        playerStats.RemovePowers(Power.strength1);
        playerStats.points += 1;
        traitsPointsCounter.text = "Points: " + playerStats.points.ToString();
        powersPointsCounter.text = "Points: " + playerStats.points.ToString();
    }
    public void strength2Deselected()
    {
        strength2a.SetActive(true);
        strength2e.SetActive(false);
        strength2C.SetActive(false);
        playerStats.RemovePowers(Power.strength2);
        playerStats.points += 2;
        traitsPointsCounter.text = "Points: " + playerStats.points.ToString();
        powersPointsCounter.text = "Points: " + playerStats.points.ToString();
    }
    public void strength3Deselected()
    {
        strength3a.SetActive(true);
        strength3e.SetActive(false);
        strength3C.SetActive(false);
        playerStats.RemovePowers(Power.strength3);
        playerStats.points += 3;
        traitsPointsCounter.text = "Points: " + playerStats.points.ToString();
        powersPointsCounter.text = "Points: " + playerStats.points.ToString();
    }
}
