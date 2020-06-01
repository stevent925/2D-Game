/**
 * This controller connects the character selection and option menu view.
 *
 * @author Mark He
 * @LastUpdated: 05/31/2020
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Menu_Controller : MonoBehaviour {
    public Button PlayButton;
    public Button OptionsButton;
    public Button ExitButton;

    public void playGame() {
        SceneManager.LoadScene(1);
    }
    public void optionsMenu() {
        SceneManager.LoadScene(2);
    }

    public void quitGame() {
        Application.Quit();
    }
}
