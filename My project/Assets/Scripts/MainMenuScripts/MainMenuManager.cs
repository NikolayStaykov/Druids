using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UIElements;

public class MainMenuManager : MonoBehaviour
{
    public GameObject MainMenuPanel;
    public GameObject OptionsMenuPanel;
    public AudioSource MainMenuMusic;
    public TextMeshProUGUI MusicVolumeLabel;
    public TextMeshProUGUI SoundEffectsVolumeLabel;

    private int _musicVolume;
    private int _soundEffectsVolume;
    void Start()
    {
        _musicVolume = PlayerPrefs.GetInt("MusicVolume", 5);
        _soundEffectsVolume = PlayerPrefs.GetInt("SoundEffectsVolume", 5);
        MainMenuMusic.volume = _musicVolume / 10f;
        MusicVolumeLabel.text = _musicVolume.ToString();
        SoundEffectsVolumeLabel.text = _soundEffectsVolume.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void QuitButtonClicked()
    {
        Application.Quit();
    }

    public void OptionsButtonClicked()
    {
        MainMenuPanel.SetActive(false);
        OptionsMenuPanel.SetActive(true);
    }
    public void BackButtonClicked()
    {
        OptionsMenuPanel.SetActive(false);
        MainMenuPanel.SetActive(true);
    }
    public void MusicLeftButtonClicked()
    {
        if(_musicVolume > 0)
        {
            PlayerPrefs.SetInt("MusicVolume", --_musicVolume);
            MusicVolumeLabel.text = _musicVolume.ToString();
            MainMenuMusic.volume = _musicVolume / 10f;
        }
    }
    public void MusicRightButtonClicked()
    {
        if (_musicVolume < 10)
        {
            PlayerPrefs.SetInt("MusicVolume", ++_musicVolume);
            MusicVolumeLabel.text = _musicVolume.ToString();
            MainMenuMusic.volume = _musicVolume / 10f;
        }
    }
    public void SoundEffectsLeftButtonClicked()
    {
        if (_soundEffectsVolume > 0)
        {
            PlayerPrefs.SetInt("SoundEffectsVolume", --_soundEffectsVolume);
            SoundEffectsVolumeLabel.text = _soundEffectsVolume.ToString();
        }
    }
    public void SoundEffectsRightButtonClicked()
    {
        if (_soundEffectsVolume < 10)
        {
            PlayerPrefs.SetInt("SoundEffectsVolume", ++_soundEffectsVolume);
            SoundEffectsVolumeLabel.text = _soundEffectsVolume.ToString();
        }
    }
    public void StartButtonClicked()
    {

    }
}
