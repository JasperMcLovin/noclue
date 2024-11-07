using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    [Header("Music")]
    [SerializeField] AudioSource musicSource;

    [Header("Music Source")]
    public AudioClip background;

    static private AudioManager instance = null;
    private void Awake()
    {
        DontDestroyOnLoad(gameObject);
        if (instance != null) {
        Destroy(this);
        return;
        }
        instance = this;
    }
    // Start is called before the first frame update
    private void Start()
    {
        musicSource.clip = background;
        musicSource.Play();
    }

    // Update is called once per frame
    public void Update()
    {
        
    }
}
