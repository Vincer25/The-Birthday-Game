using UnityEngine;

public class AudioControll : MonoBehaviour
{
    AudioSource myAudio;

    public void PlayBeer()
    {
        myAudio = GetComponent<AudioSource>();
        myAudio.Play();
    }
}