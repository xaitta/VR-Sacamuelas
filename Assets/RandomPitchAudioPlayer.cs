using UnityEngine;

public class RandomPitchAudioPlayer : MonoBehaviour
{
    public AudioSource audioSource;  // Reference to the AudioSource component
    public AudioClip audioClip;  // The audio clip to play
    public float minInterval = 30.0f;  // Minimum random interval in seconds
    public float maxInterval = 10.0f;  // Maximum random interval in seconds
    public float minPitch = 0.5f;  // Minimum pitch
    public float maxPitch = 1.5f;  // Maximum pitch

    private float nextPlayTime;  // The next time the audio will play

    void Start()
    {
        // Set the initial next play time
        ScheduleNextPlay();
    }

    void Update()
    {
        // Check if it's time to play the audio
        if (Time.time >= nextPlayTime)
        {
            PlayAudioWithRandomPitch();
            ScheduleNextPlay();
        }
    }

    // Method to schedule the next play time
    void ScheduleNextPlay()
    {
        float interval = Random.Range(minInterval, maxInterval);
        nextPlayTime = Time.time + interval;
    }

    // Method to play the audio with a random pitch
    void PlayAudioWithRandomPitch()
    {
        audioSource.clip = audioClip;
        audioSource.pitch = Random.Range(minPitch, maxPitch);
        audioSource.Play();
    }
}
