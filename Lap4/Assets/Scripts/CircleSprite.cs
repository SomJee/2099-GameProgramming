using UnityEngine;

public class CircleSprite : MonoBehaviour
{
    private void Start()
    {
        GetComponent<SpriteRenderer>().enabled = false;
    }
}
