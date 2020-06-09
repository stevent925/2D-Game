/**
 * This controller connects connects main menu view to key bindings and other settings in this view.
 *
 * @author Mark He
 * @LastUpdated: 06/08/2020
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Option_Controller : MonoBehaviour {

    public AudioMixer mixerTest;
    public Button BackToMenuButton;
    public Dropdown resolutionDropdown;
    Resolution[] resolutions;

    private void Start() {

        resolutions = Screen.resolutions;
        resolutionDropdown.ClearOptions();

        List<string> options = new List<string>();

        int currentResolution = 0;

        for(int i = 0; i < resolutions.Length; i++) {

            string option = resolutions[i].width + "x" + resolutions[i].height;
            options.Add(option);

            if (resolutions[i].width == Screen.currentResolution.width && 
                resolutions[i].height == Screen.currentResolution.height) {

                currentResolution = i;

            }
        }

        resolutionDropdown.AddOptions(options);
        resolutionDropdown.value = currentResolution;
        resolutionDropdown.RefreshShownValue();

    }

    public void SetResolution (int resolutionIndex) {

        Resolution resolution = resolutions[resolutionIndex];
        Screen.SetResolution(resolution.width, resolution.height, Screen.fullScreen);

    }

    public void SetMusicVolumeLevel(float musicVol) {

        mixerTest.SetFloat("ExposedParamTest", Mathf.Log10(musicVol) * 20);

    }


    public void SetSFXVolumeLevel(float sfxVol) {

        mixerTest.SetFloat("ExposedParamTest", Mathf.Log10(sfxVol) * 20);

     }
 

    public void SetQualityLevel(int qualityIndex) {

        QualitySettings.SetQualityLevel(qualityIndex);

    }

    public void SetFullScreen(bool isFullScreen) {

        Screen.fullScreen = isFullScreen;

    }
}
