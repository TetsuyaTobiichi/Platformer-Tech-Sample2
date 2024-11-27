

using UnityEngine;
[CreateAssetMenu]
public class PlayerInitData : ScriptableObject
{
   public GameObject playerPref;
   public float defaultMoveSpeed =2f;
   public float defaultJumpForce= 3f;
   public float defaultHealth = 100f;
   public float defaultSaveHeight =2f;
   public static PlayerInitData LoadFromAssets()=>Resources.Load("Data/PlayerInitData") as PlayerInitData;
   
}
