using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class AudioManager : MonoBehaviour
{
    public static AudioManager instance;

    public Musica[] music;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(this.gameObject);
        }
        else
        {
            Destroy(this.gameObject);
        }
    }
    private void Start()
    {
        for (int i = 0; i < music.Length; i++)
        {
            music[i].source = gameObject.AddComponent<AudioSource>();
            music[i].source.clip = music[i].clip;
            music[i].source.volume = music[i].volume;
            music[i].source.loop = music[i].loop;
        }
    }
    public void Play(string nombre)
    {
        for (int i = 0; i < music.Length; i++)
        {
            if (nombre == music[i].nombre)
            {
                music[i].source.Play();
                return;
            }
        }
    }

    public void Stop(string nombre)
    {
        for (int i = 0; i < music.Length; i++)
        {
            if (nombre == music[i].nombre)
            {
                music[i].source.Stop();
                return;
            }
        }

        Debug.Log("No se encontro la cancion");
    }
}
