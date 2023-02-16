using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FadeInAudio : MonoBehaviour
{
    // Start is called before the first frame update
    public float fadeTime = 1;
    void Start()
    {
        StartCoroutine(FadeInMusicRoutine());
    }

    // Update is called once per frame
    IEnumerator FadeInMusicRoutine(){
        AudioSource audioSource = GetComponent<AudioSource>();
        float t = 0;
        float maxVolume = audioSource.volume;
        audioSource.volume = 0;
        audioSource.Play();
        while(t<fadeTime){
            t += Time.deltaTime;
            yield return null;
            audioSource.volume = Mathf.Lerp(0,maxVolume,t/fadeTime);
        }
        audioSource.volume = maxVolume;
        yield return null;
    }
}
