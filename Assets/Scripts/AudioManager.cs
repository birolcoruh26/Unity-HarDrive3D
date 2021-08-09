using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AudioManager: MonoBehaviour
{
    public sound[] sounds;
    void Start()
    {
        foreach (sound s in sounds)
        {
            s.source = gameObject.AddComponent<AudioSource>();
            s.source.clip = s.clip;
            s.source.loop = s.loop;
            s.source.volume = s.volume;
        }
        PlaySound("mainTheme");
        PlaySound("mainMenu");
    }
  
    public void PlaySound(string name)
    {
        foreach (sound s in sounds)
        {
          if(s.name == name)
            {
                s.source.Play();
            }
        }
    }
}