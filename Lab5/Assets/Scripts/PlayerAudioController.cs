using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAudioController : MonoBehaviour
{
    [SerializeField] private AudioSource audioSource;
    [SerializeField] private SoaudioClips walkAudioClips;
    [SerializeField] private SoaudioClips jumpAudioClips;
    [SerializeField] private SoaudioClips deathAudioClips;
    [SerializeField] private SoaudioClips winAudioClips;
    [SerializeField] private SoaudioClips sprungAudioClips;
    [SerializeField] private SoaudioClips collectedAudioClips;
    [SerializeField] private SoaudioClips respawnedAudioClips;


    public void PlayJumpSound()
    {
        audioSource.PlayOneShot(jumpAudioClips.GetAudioCilp(),0.5f);
    }

    public void PlayWalkSound()
    {
        audioSource.PlayOneShot(walkAudioClips.GetAudioCilp());
    }

    public void PlayDeathSound()
    {
        audioSource.PlayOneShot(deathAudioClips.GetAudioCilp(),0.3f);
    }

    public void PlayWinSound()
    {
        audioSource.PlayOneShot(winAudioClips.GetAudioCilp(),0.3f);
    }

    public void PlaySprungSound()
    {
        audioSource.PlayOneShot(sprungAudioClips.GetAudioCilp(),0.3f);
    }

    public void PlayCollectedSound()
    {
        audioSource.PlayOneShot(collectedAudioClips.GetAudioCilp(),0.3f);
    }

     public void PlayRespawnSound()
    {
        audioSource.PlayOneShot(respawnedAudioClips.GetAudioCilp(),0.3f);
    }


}
