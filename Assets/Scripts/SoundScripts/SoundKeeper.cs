using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundKeeper : MonoBehaviour
{
    public List<AudioSource> Sounds = new();

    private void Awake()
    {
        DontDestroyOnLoad(this);
    }
}
