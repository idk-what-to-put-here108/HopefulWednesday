using UnityEngine;

[CreateAssetMenu(fileName = "AudioPlayList", menuName = "Scriptable Objects/AudioPlayList")]
public class AudioPlayList : ScriptableObject
{
    [Header("Music Tracks")]
    public AudioClip menuTheme;
    public AudioClip levelTheme;

    [Header("Sound Effects")]
    public AudioClip jump;
}
