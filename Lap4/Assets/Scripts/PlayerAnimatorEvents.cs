using UnityEngine;

public class PlayerAnimatorEvents : MonoBehaviour
{
    [SerializeField]private PlayerAudio audioController;

    public void PlayWalkSound()
    {
        audioController.PlayWalkSound();
    }
}
