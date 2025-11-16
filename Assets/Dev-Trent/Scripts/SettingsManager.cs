using TMPro;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class SettingsManager : MonoBehaviour
{
    [Header("Settings Panel")]
    public bool openSettings;
    public GameObject SettingsPanel;
    [Header("Audio")]
    public AudioMixer AudioManager;
    [Header("Graphic")]
    public TMP_Dropdown GraphicDropdown;

    void Awake()
    {
        // Prevent this GameObject from being destroyed when loading a new scene
        DontDestroyOnLoad(gameObject);
    }
    public void Start()
    {
        GraphicDropdown.value = PlayerPrefs.GetInt("GraphicsSettings", 1);
    }
    public void ToggleSettings()
    {
        if (openSettings) { SettingsPanel.SetActive(false); openSettings = false; }else { SettingsPanel.SetActive(true); openSettings = true; }
    }

    public void SetMaterVolume(float volumeSlider) 
    { 
        AudioManager.SetFloat("MasterVol",Mathf.Log10(volumeSlider) * 20);
    }

    public void FullscreenControls()
    {
        Screen.fullScreen = !Screen.fullScreen;
    }

    public void ChangeGraphics(int graphicIndex)
    {
        QualitySettings.SetQualityLevel(graphicIndex);
        PlayerPrefs.SetInt("GraphicSettings", graphicIndex);
    }
}
