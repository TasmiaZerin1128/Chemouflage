using UnityEngine;

[RequireComponent(typeof(AudioSource))]
public class sound : MonoBehaviour
{
    // two clips, perhaps songs for the game
    public AudioClip voice;

    private AudioSource audioSource;
    static private bool paused;

    public Texture soundOn;
    public Texture soundOff;

    private Texture soundOn_Off;
    
    GUIStyle Style = new GUIStyle();

    // both songs are in paused state
    void Start()
    {
        Debug.Log("Hiii");
        audioSource = GetComponent<AudioSource>();
        audioSource.clip = voice;
        audioSource.Play();
        paused = false;
        soundOn_Off = soundOn;
        Style.normal.background = null;
    }

    void OnGUI()
    {
        if (paused)
        {
            audioSource.Pause();
        }
        else if (!paused)
        {
            audioSource.UnPause();
        }
        if (GUI.Button(new Rect(2000, 50, 120, 120),soundOn_Off,Style))
        {
            if (paused)    // play the voice
            {
                GUI.enabled = false;
                soundOn_Off = soundOn;
                GUI.enabled=true;
                audioSource.clip = voice;
                audioSource.UnPause();
                paused = false;
            }
            else if (!paused)   // pause the voice
            {
                GUI.enabled = false;
                soundOn_Off = soundOff;
                GUI.enabled = true;
                audioSource.Pause();
                paused = true;
            }
        }
    }
}