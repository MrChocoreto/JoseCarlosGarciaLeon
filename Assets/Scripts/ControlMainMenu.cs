using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ControlMainMenu : MonoBehaviour
{

    #region Variables
    [SerializeField] Animator Ani;
    [SerializeField] GameObject Game_Selector;
    [SerializeField] GameObject Button_Start;
    [SerializeField] bool Scene_Select = false;

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
        Ani.SetInteger("SOG", 2);
        //Game_Selector.SetActive(true);
        //Button_Start.SetActive(false);
    }

    public void LoadGame()
    {
        Ani.SetInteger("SOG", 1);
        Scene_Select = true;

    }

    public void CreateGame()
    {
        Ani.SetInteger("SOG", 1);
    }

    public void Exit()
    {
        Application.Quit();
        Debug.Log("Game_Closed");
    }

    public void LoadScene()
    {
        SceneManager.LoadScene("Game");
        if (Scene_Select)
        {
            Debug.Log("Game_Loaded");
        }
        else
        {
            Debug.Log("New_Game_Created");
        }
    }

    #endregion


}
