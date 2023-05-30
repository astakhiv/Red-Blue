using UnityEngine.SceneManagement;
using UnityEngine;
using TMPro;
using UnityEngine.Audio;

public class SceneMenagment : MonoBehaviour
{
    [SerializeField] private AudioSource _buttonClick;
    [SerializeField] private AudioMixerGroup _mixerGroup;
    public GameObject TextOnOff;

    private string _levelToLoad;

    private Animator _animator;

    private void Start()
    {
        _animator = GetComponent<Animator>();
    }

    public void FadeToLevel(string LevelToLoad)
    {
        _buttonClick.Play();
        _animator.SetTrigger("fade");
        _levelToLoad = LevelToLoad;
    }

    public void OnFadeComplete()
    {
        SceneManager.LoadScene(_levelToLoad);
    }

    public void ShowUIPart(GameObject UI)
    {
        _buttonClick.Play();
        UI.SetActive(true);
    }

    public void QuiteAplication()
    {
        _buttonClick.Play();
        Application.Quit();
    }
}
