using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
	GameManager gameManager;

	public AudioClip[] collisionSfx;
	public AudioClip[] dieSfx;

	private AudioSource audioSource;

	private void Start()
	{
		gameManager = FindObjectOfType<GameManager>();
		audioSource = FindObjectOfType<AudioSource>();
	}

	private void OnCollisionEnter(Collision collision)
	{

		if (collision.gameObject.tag == "Obstacle")
		{
			Debug.Log("Collision");
			Debug.Log(audioSource);

			if (audioSource)
			{
				Debug.Log("Playing Hit SFX");

				audioSource.PlayOneShot(collisionSfx[Random.Range(0, collisionSfx.Length)]);
			}
		}

		if (collision.gameObject.tag == "DeathPit")
		{
			Debug.Log("Death by falling");
			Debug.Log(audioSource);

			if (audioSource)
			{
				Debug.Log("Playing Hit SFX");

				audioSource.PlayOneShot(dieSfx[Random.Range(0, dieSfx.Length)]);

				gameManager.EndGame();
			}
		}

		if (collision.gameObject.tag == "Finish")
		{
			gameManager.LevelComplete();
		}
	}
}
