using UnityEngine;

[CreateAssetMenu(menuName = "Collectibles")]
public class SoCollectibles : ScriptableObject
{
    [SerializeField] private string collectibleName;
    [SerializeField] private CollectibleType collectibleType;

    public string GetCollectible()
    {
        return collectibleName;
    }
    //[SerializeField] private collectibleType;
    ///[SerializeField] private Sprite sprite;
    //[SerializeField] private Sprite outlineSprite;
    //[SerializeField] private bool respawnable;
     
    //public Sprite GetSprite() => sprite;
    //public CollectibleType GetCollectibleType() => collectibleType;
    //public sprite GetOutlineSprite() => outlineSprite;
    //public bool GetRespawnable() => respawnable;

    // Start is called before the first frame update
    //private void Start()
    //{
   //     Debug.Log(CollectibleObject.GetCollectible());
   // }

    
}
