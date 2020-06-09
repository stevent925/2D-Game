/**
 * This controller connects the save state, character selection, and option menu view.
 *
 * @author Mark He
 * @LastUpdated: 06/08/2020
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Menu_Controller : MonoBehaviour {
    
    public Button LoadGameButton;
    public Button NewGameButton;
    public Button OptionButton;
    public Button ExitButton;

    public void loadGame(string playerName) {

        //string filePath = savePath + playerName + FILE_EXTENSION;

        //check if savePath & saveFile exist
        //load scene of savedScene if exist
        //SceneManager.LoadSceneAsync(gameData.savedScene, LoadScene.Single);
        //check if file does not exist
        //Debug.Log("Failed to load save file." + filePath);

        //SceneManager.LoadScene(3);
    }

    public void newGame() {

        SceneManager.LoadScene(1);

    }
    public void optionsMenu() {

        SceneManager.LoadScene(1);

    }

    public void exitGame() {

        Application.Quit();

    }
}
