using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public static AudioManager Instance;

    [Header("PlayList")]
    [SerializeField] private AudioPlayList playlist;

    [Header("Music")]
    [SerializeField] private AudioSource musicSource;

    [Header("SFX")]
    [SerializeField] private AudioSource SFXSource;
    private void Awake()
    {
        if(Instance == null)
        {
            Instance = this;

            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    private void OnEnable()
    {
        if (playlist != null && playlist.menuTheme != null)
        {
            PlayMenuMusic();
        }
        
    }
    public void PlayMenuMusic()
    {
        PlayMusic(playlist.menuTheme);
    }
    public void PlayLevelMusic()
    {
        PlayMusic(playlist.levelTheme);
    }
    public void PlayJumpSFX()
    {
        SFXSource.PlayOneShot(playlist.jump);
    }

    public void PlayMusic(AudioClip clip)
    {
        if (musicSource.clip == clip)
        {
            return;
        }
        musicSource.clip = clip;

        musicSource.Play();
    }
    public void PlaySFX(AudioClip clip)
    {
        SFXSource.PlayOneShot(clip);
    }
}
