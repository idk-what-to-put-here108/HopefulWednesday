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
    //--------Music---------//
    public void PlayMenuMusic()
    {
        PlayMusic(playlist.menuTheme);
    }
    public void PlayLevelMusic()
    {
        PlayMusic(playlist.levelTheme);
    }

    //--------SFX----------//
    public void PlayJumpSFX()
    {
        SFXSource.PlayOneShot(playlist.jump);
    }
    public void PlaySaveSFX()
    {
        SFXSource.PlayOneShot(playlist.checkpoint);
    }
    public void PlayKillSFX()
    {
        SFXSource.PlayOneShot(playlist.kill);
    }
    public void PlayDeadSFX()
    {
        SFXSource.PlayOneShot(playlist.dead);
    }
    public void PlayCollectSFX()
    {
        SFXSource.PlayOneShot(playlist.collect);
    }
    public void PlayHurtSFX()
    {
        SFXSource.PlayOneShot(playlist.hurt);
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
