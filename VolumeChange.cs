using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VolumeChange : MonoBehaviour
{
    private AudioSource source;

    private float musicVolume = 1f;

    // Start is called before the first frame update
    void Start()
    {
        source = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        source.volume = musicVolume;
    }


    public void Volume(float vol)
    {
        musicVolume = vol;
    }

    public void SoundMute()
    {
        musicVolume = 0f;
    }

    public void SoundOn()
    {
        musicVolume = 1f;
    }

    
}
