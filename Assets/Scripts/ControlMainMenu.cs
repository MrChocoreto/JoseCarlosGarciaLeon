using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ControlMainMenu : MonoBehaviour
{

    #region Variables

    [SerializeField] GameObject Game_Selector;
    [SerializeField] GameObject Button_Start;

    #endregion



    #region Unity_Methods

    private void Awake()
    {
        Game_Selector.SetActive(false);
    }

    #endregion



    #region My_Methods


    public void Load_GameSelector()
    {
        Game_Selector.SetActive(true);
        Button_Start.SetActive(false);
    }

    public void LoadGame()
    {
        SceneManager.LoadScene("Game");
        Debug.Log("Game_Loaded");

    }

    public void CreateGame()
    {
        SceneManager.LoadScene("Game");
        Debug.Log("New_Game_Created");
    }

    public void Exit()
    {
        Application.Quit();
        Debug.Log("Game_Closed");
    }

    #endregion


}
