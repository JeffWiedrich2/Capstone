using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuUIController : MonoBehaviour
{
    [Header("Menu Screens")]
    public GameObject MainMenu;
    public GameObject LoadMenu;
    public GameObject CharacterCreation;
    public GameObject TraitsMenu;
    public GameObject PowersMenu;
    public GameObject ModelMenu;

    [Header("Character Creation Arrays")]
    public GameObject[] powers;
    public GameObject[] traits;
    public GameObject[] models;

    public void BackToMainMenuFromLoad()
    {
        MainMenu.SetActive(true);
        LoadMenu.SetActive(false);
    }
    public void ToLoad()
    {
        MainMenu.SetActive(false);
        LoadMenu.SetActive(true);
    }

    public void ToCharacterCreationFromMain()
    {
        MainMenu.SetActive(false);
        CharacterCreation.SetActive(true);
    }
    public void BackToMainMenuFromCharacterCreation()
    {
        MainMenu.SetActive(true);
        CharacterCreation.SetActive(false);
    }

    public void ToTraitsFromCharacterCreation()
    {
        CharacterCreation.SetActive(false);
        TraitsMenu.SetActive(true);
    }

    public void ToPowersFromCharacterCreation()
    {
        CharacterCreation.SetActive(false);
        PowersMenu.SetActive(true);
    }

    public void ToModelsFromCharacterCreation()
    {
        CharacterCreation.SetActive(false);
        ModelMenu.SetActive(true);
    }

    public void BackToCharacterCreationFromTraits()
    {
        CharacterCreation.SetActive(true);
        TraitsMenu.SetActive(false);
    }

    public void BackToCharacterCreationFromPowers()
    {
        CharacterCreation.SetActive(true);
        PowersMenu.SetActive(false);
    }

    public void BackToCharacterCreationFromModel()
    {
        CharacterCreation.SetActive(true);
        ModelMenu.SetActive(false);
    }

    public void ExitGame()
    {
        Application.Quit(1);
    }

    public void StartGame()
    {
        SceneManager.LoadScene("GameScene");
    }
}
