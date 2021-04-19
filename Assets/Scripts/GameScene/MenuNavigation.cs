using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MenuNavigation : MonoBehaviour
{
    public GameObject gameScreen;
    public GameObject previousTurnResults;
    public GameObject gameStats;
    public GameObject gameDecisions;
    public GameObject gameOptions;
    public GameObject diplomacy;
    public GameObject saveGameGame;
    public GameObject loadGameGame;
    public GameObject provinceScreen;
    public GameObject provinceStats;
    public GameObject provinceDecisions;
    public GameObject provinceDefense;
    public GameObject provinceOptions;
    public GameObject loadProvince;
    public GameObject saveProvince;
    public GameObject garrison;
    public GameObject recruitment;
    //public GameObject movement;

    [Header("Edited Values")]
    public Transform mainCamera;
    public Text gameStatsText;
    //public Text provinceStatsText;
    public CheckStatistics playerInfo;

    public void GameToDiplomacy()
    {
        gameScreen.SetActive(false);
        diplomacy.SetActive(true);
    }

    public void GameToDecisions()
    {
        gameScreen.SetActive(false);
        gameDecisions.SetActive(true);
    }

    public void GameTStats()
    {
        gameScreen.SetActive(false);
        gameStats.SetActive(true);
        Debug.Log("Swapping the actives works fine");

        gameStatsText.text = "Player stats: \n";
        Debug.Log("Grabbing the text works fine");

        /*if (PlayerStats.powers.Length > 0)
        {
            Debug.Log("Grabbing the static variables works fine");
            gameStatsText.text += "    Powers:\n";
            for (int i = 0; i < PlayerStats.powers.Length; i++)
            {
                gameStatsText.text += PlayerStats.powers[i] + "\n";
            }
        }
        if (PlayerStats.traits.Length > 0)
        {
            gameStatsText.text += "    Traits:\n";
            for (int i = 0; i < PlayerStats.traits.Length; i++)
            {
                gameStatsText.text += PlayerStats.traits[i] + "\n";
            }
        }*/
        gameStatsText.text += "\nEconomy:\n     Money: " + playerInfo.money + 
            "\n     Income: " + playerInfo.income +
            "\n     Infamy: " + playerInfo.infamy;
    }

    public void GameToTurnResults()
    {
        gameScreen.SetActive(false);
        previousTurnResults.SetActive(true);
    }

    public void GameToOptions()
    {
        gameScreen.SetActive(false);
        gameOptions.SetActive(true);
    }

    public void ResultsToGame()
    {
        previousTurnResults.SetActive(false);
        gameScreen.SetActive(true);
    }

    public void OptionsToGame()
    {
        gameOptions.SetActive(false);
        gameScreen.SetActive(true);
    }

    public void OptionsToLoadGame()
    {
        gameOptions.SetActive(false);
        loadGameGame.SetActive(true);
    }

    public void LoadGameToOptions()
    {
        gameOptions.SetActive(true);
        loadGameGame.SetActive(false);
    }

    public void OptionsToSaveGame()
    {
        gameOptions.SetActive(false);
        saveGameGame.SetActive(true);
    }

    public void SaveGameToOptions()
    {
        gameOptions.SetActive(true);
        saveGameGame.SetActive(false);
    }

    public void StatsToGame()
    {
        gameStats.SetActive(false);
        gameScreen.SetActive(true);
    }

    public void DecisionsToGame()
    {
        gameDecisions.SetActive(false);
        gameScreen.SetActive(true);
    }

    public void DiplomacyToGame()
    {
        diplomacy.SetActive(false);
        gameScreen.SetActive(true);
    }

    public void ProvinceToGame()
    {
        provinceScreen.SetActive(false);
        gameScreen.SetActive(true);
        mainCamera.position = new Vector3(0f, 0f, -10f);
    }

    public void ProvinceToDefenses()
    {
        provinceScreen.SetActive(false);
        provinceDefense.SetActive(true);
    }

    public void ProvinceToStats()
    {
        provinceScreen.SetActive(false);
        provinceStats.SetActive(true);
    }

    public void ProvinceToDecisions()
    {
        provinceScreen.SetActive(false);
        provinceOptions.SetActive(true);
    }

    public void ProvinceToOptions()
    {
        provinceScreen.SetActive(false);
        provinceOptions.SetActive(true);
    }

    public void OptionsToProvince()
    {
        provinceOptions.SetActive(false);
        provinceScreen.SetActive(true);
    }

    public void OptionsToLoadProvince()
    {
        provinceOptions.SetActive(false);
        loadProvince.SetActive(true);
    }

    public void LoadProvinceToOptions()
    {
        provinceOptions.SetActive(true);
        loadProvince.SetActive(false);
    }

    public void OptionsToSaveProvince()
    {
        provinceOptions.SetActive(false);
        saveProvince.SetActive(true);
    }

    public void SaveProvinceToOptions()
    {
        provinceOptions.SetActive(true);
        saveProvince.SetActive(false);
    }

    public void StatsToProvince()
    {
        provinceStats.SetActive(false);
        provinceScreen.SetActive(true);
    }

    public void DecisionToProvince()
    {
        provinceDecisions.SetActive(false);
        provinceScreen.SetActive(true);
    }

    public void DefenseToProvince()
    {
        provinceDefense.SetActive(false);
        provinceScreen.SetActive(true);
    }

    public void ProvinceToGarrison()
    {
        provinceScreen.SetActive(false);
        garrison.SetActive(true);
    }

    public void GarrisonToProvince()
    {
        provinceScreen.SetActive(true);
        garrison.SetActive(false);
    }

    public void RecruitmentToGarrison()
    {
        garrison.SetActive(true);
        recruitment.SetActive(false);
    }

    public void GarrisonToRecruitment()
    {
        garrison.SetActive(false);
        recruitment.SetActive(true);
    }

    public void ExitGame()
    {
        Application.Quit(1);
    }

    public void MainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
