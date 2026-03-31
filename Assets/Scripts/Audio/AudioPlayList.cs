using UnityEngine;

[CreateAssetMenu(fileName = "AudioPlayList", menuName = "Scriptable Objects/AudioPlayList")]
public class AudioPlayList : ScriptableObject
{
    [Header("Music Tracks")]
    public AudioClip menuTheme;
    public AudioClip levelTheme;

    [Header("Sound Effects")]
    public AudioClip jump;
    public AudioClip checkpoint;
    public AudioClip kill;
    public AudioClip collect;
    public AudioClip dead;
    public AudioClip hurt;
}
