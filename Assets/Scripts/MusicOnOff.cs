using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class MusicOnOff : MonoBehaviour
{
    [SerializeField] private GameObject _buttonImage;
    [SerializeField] private Sprite _oldImage;
    [SerializeField] private Sprite _newImage;
    [SerializeField] private AudioMixerGroup _mixerGroup;

    private int _musicStatus = 1;

    public void _musicOnOff()
    {
        Sprite _Image = _buttonImage.GetComponent<Image>().sprite;

        if (_Image == _oldImage)
        {
            _buttonImage.GetComponent<Image>().sprite = _newImage;
            _mixerGroup.audioMixer.SetFloat("MusicOnOff", -80.0f);
            _musicStatus = 0;
            PlayerPrefs.SetInt("MusicStatus", _musicStatus);
        }
        else
        {
            _buttonImage.GetComponent<Image>().sprite = _oldImage;
            _mixerGroup.audioMixer.SetFloat("MusicOnOff", 0.0f);
            _musicStatus = 1;
            PlayerPrefs.SetInt("MusicStatus", _musicStatus);
        }
    }

    private void Awake()
    {
        if(PlayerPrefs.GetInt("MusicStatus") == 1)
        {
            _buttonImage.GetComponent<Image>().sprite = _oldImage;
        }
        else
        {
            _buttonImage.GetComponent<Image>().sprite = _newImage;
        }
    }
}
