using UnityEngine.Audio;
using System;
using UnityEngine;

/**
 * Disclaimer: The audio logic is adapted from this Youtube Video:
 * https://www.youtube.com/watch?v=6OT43pvUyfY
 */

public class Audiomanager : MonoBehaviour
{

	public static Audiomanager instance;

	public Sound[] sounds;

	public bool isPlaying;
	void Awake()
	{
		if (instance != null)
		{
			Destroy(gameObject);
		}
		else
		{
			instance = this;
			DontDestroyOnLoad(gameObject);
		}

		foreach (Sound s in sounds)
		{
			s.source = gameObject.AddComponent<AudioSource>();

			s.source.clip = s.clip;
			s.source.loop = s.loop;
			s.source.volume = s.volume;
		}
	}

	
	// play sound
	public void Play(string sound)
	{
		Sound s = Array.Find(sounds, item => item.name == sound);
		if (s == null)
		{
			Debug.LogWarning("Sound: " + sound + " not found!");
			return;
		}

		// s.source.volume = s.volume; //* (1f + UnityEngine.Random.Range(-s.volumeVariance / 2f, s.volumeVariance / 2f));
		// s.source.pitch = s.pitch; //* (1f + UnityEngine.Random.Range(-s.pitchVariance / 2f, s.pitchVariance / 2f));

		Debug.Log("s: " + s.source.volume);
		s.source.Play();
	}
	// play sound at volume x (between 0 and 1)
	public void Play(string sound, float volume)
	{
		Sound s = Array.Find(sounds, item => item.name == sound);
		if (s == null)
		{
			Debug.LogWarning("Sound: " + sound + " not found!");
			return;
		}

		s.source.volume = volume;
		s.source.Play();
		
	}

	public void Stop(string sound)
	{
		Sound s = Array.Find(sounds, item => item.name == sound);
		if (s == null)
		{
			Debug.LogWarning("Sound: " + sound + " not found!");
			return;
		}

		// s.source.volume = s.volume; //* (1f + UnityEngine.Random.Range(-s.volumeVariance / 2f, s.volumeVariance / 2f));
		// s.source.pitch = s.pitch; //* (1f + UnityEngine.Random.Range(-s.pitchVariance / 2f, s.pitchVariance / 2f));

		Debug.Log("s: " + s.source.volume);
		s.source.Stop();
	}
	
	public void StopAll()
	{
		foreach (Sound s in sounds)
		{
			s.source.Stop();
		}
	}

	public void Pause(string sound)
	{
		Sound s = Array.Find(sounds, item => item.name == sound);
		if (s == null)
		{
			Debug.LogWarning("Sound: " + sound + " not found!");
			return;
		}

		// s.source.volume = s.volume; //* (1f + UnityEngine.Random.Range(-s.volumeVariance / 2f, s.volumeVariance / 2f));
		// s.source.pitch = s.pitch; //* (1f + UnityEngine.Random.Range(-s.pitchVariance / 2f, s.pitchVariance / 2f));

		Debug.Log("s: " + s.source.volume);
		s.source.Pause();
	}

	public void UnPause(string sound)
	{
		Sound s = Array.Find(sounds, item => item.name == sound);
		if (s == null)
		{
			Debug.LogWarning("Sound: " + sound + " not found!");
			return;
		}

		// s.source.volume = s.volume; //* (1f + UnityEngine.Random.Range(-s.volumeVariance / 2f, s.volumeVariance / 2f));
		// s.source.pitch = s.pitch; //* (1f + UnityEngine.Random.Range(-s.pitchVariance / 2f, s.pitchVariance / 2f));

		Debug.Log("s: " + s.source.volume);
		s.source.UnPause();
	}
}
