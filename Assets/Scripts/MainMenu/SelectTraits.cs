using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectTraits : MonoBehaviour
{
    public PlayerStats playerStats;
    public UnityEngine.UI.Text traitsPointsCounter;
    public UnityEngine.UI.Text powersPointsCounter;

    [Header("Available Traits")]
    public GameObject strongWilledA;
    public GameObject weakWilledA;
    public GameObject insaneA;

    [Header("Equipped Traits")]
    public GameObject strongWilledE;
    public GameObject WeakWilledE;
    public GameObject insaneE;

    [Header("Character Creation Screen")]
    public GameObject strongWilledC;
    public GameObject WeakWilledC;
    public GameObject insaneC;

    private void Start()
    {
        playerStats.points = 20;
        traitsPointsCounter.text = "Points: " + playerStats.points.ToString();
        powersPointsCounter.text = "Points: " + playerStats.points.ToString();
    }

    public void strongWilledSelected()
    {
        strongWilledA.SetActive(false);
        strongWilledE.SetActive(true);
        strongWilledC.SetActive(true);
        playerStats.AddTraits(Trait.strongWilled);
        playerStats.points -= 1;
        traitsPointsCounter.text = "Points: " + playerStats.points.ToString();
        powersPointsCounter.text = "Points: " + playerStats.points.ToString();
    }
    public void weakWilledSelected()
    {
        weakWilledA.SetActive(false);
        WeakWilledE.SetActive(true);
        WeakWilledC.SetActive(true);
        playerStats.AddTraits(Trait.weakWilled);
        playerStats.points += 1;
        traitsPointsCounter.text = "Points: " + playerStats.points.ToString();
        powersPointsCounter.text = "Points: " + playerStats.points.ToString();
    }
    public void insaneSelected()
    {
        insaneA.SetActive(false);
        insaneE.SetActive(true);
        insaneC.SetActive(true);
        playerStats.AddTraits(Trait.insane);
        playerStats.points -= 3;
        traitsPointsCounter.text = "Points: " + playerStats.points.ToString();
        powersPointsCounter.text = "Points: " + playerStats.points.ToString();
    }
    public void strongWilledDeselected()
    {
        strongWilledA.SetActive(true);
        strongWilledE.SetActive(false);
        strongWilledC.SetActive(false);
        playerStats.RemoveTraits(Trait.strongWilled);
        playerStats.points += 1;
        traitsPointsCounter.text = "Points: " + playerStats.points.ToString();
        powersPointsCounter.text = "Points: " + playerStats.points.ToString();
    }
    public void weakWilledDeselected()
    {
        weakWilledA.SetActive(true);
        WeakWilledE.SetActive(false);
        WeakWilledC.SetActive(false);
        playerStats.RemoveTraits(Trait.weakWilled);
        playerStats.points -= 1;
        traitsPointsCounter.text = "Points: " + playerStats.points.ToString();
        powersPointsCounter.text = "Points: " + playerStats.points.ToString();
    }
    public void insaneDeselected()
    {
        insaneA.SetActive(true);
        insaneE.SetActive(false);
        insaneC.SetActive(false);
        playerStats.RemoveTraits(Trait.insane);
        playerStats.points += 3;
        traitsPointsCounter.text = "Points: " + playerStats.points.ToString();
        powersPointsCounter.text = "Points: " + playerStats.points.ToString();
    }
}
