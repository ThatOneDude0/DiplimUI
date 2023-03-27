using System;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public enum ButtonSettingsType
{
    Sound,
}
public enum ButtonSettingsTypeTwo
{
    Inaction,
    SoundOff,
    MusicOff
}

public class MySettings : MonoBehaviour, IPointerClickHandler
{
    public event Action ButtonCliked;
    public ButtonSettingsType buttonSettingsType;
    public ButtonSettingsTypeTwo buttonSettingsTypeTwo;

    private IButtonSettings buttonSettings;

    private Image _buttonImage;

    [SerializeField] private SoundKeeper _soundKeeper;

    private void Start()
    {
        _buttonImage = GetComponent<Image>();
        

        switch (buttonSettingsType)
        {
            case ButtonSettingsType.Sound:
                {
                    buttonSettings = new SoundKeeperAction(_soundKeeper);
                    break;
                }            
        }

        switch (buttonSettingsTypeTwo)
        {
            case ButtonSettingsTypeTwo.Inaction:
                {                  
                    break;
                }
            case ButtonSettingsTypeTwo.SoundOff:
                {
                    buttonSettings = new SoundOff(_soundKeeper);
                    break;
                }
            case ButtonSettingsTypeTwo.MusicOff:
                {
                    buttonSettings = new MusicOff(_soundKeeper);
                    break;
                }
        }
    }

    public void ButtonSoundOff(AudioSource audioSource)
    {
        if (_soundKeeper.Sounds[0].mute == false)
        {
            _soundKeeper.Sounds[0].mute = true;
            _buttonImage.color = Color.red;
        }
        else if (_soundKeeper.Sounds[0].mute == true)
        {
            _soundKeeper.Sounds[0].mute = false;
            _buttonImage.color = Color.green;
        }
    }

    public void ButtonMusicOff(AudioSource audioSource)
    {
        if (_soundKeeper.Sounds[1].isPlaying)
        {
            _soundKeeper.Sounds[1].Pause();
            _buttonImage.color = Color.red;
        }
        else if (!_soundKeeper.Sounds[1].isPlaying)
        {
            _soundKeeper.Sounds[1].Play();
            _buttonImage.color = Color.green;
        }
    }

    public void PlayButtonSound(AudioSource audioSource)
    {
        _soundKeeper.Sounds[0].Play();
    }
    
    public void OnPointerClick(PointerEventData eventData)
    {
        buttonSettings.OnButtonSettingClick(this);
        ButtonCliked?.Invoke();
        Debug.Log("отпустил");
    }
}