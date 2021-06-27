using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "PlayerData")]
public class PlayerData : ScriptableObject, ISerializationCallbackReceiver
{
    public int countCollectibles;

    public void ResetCollectibleCounter()
    {
        countCollectibles = 0;
    }

    public void OnAfterDeserialize()
    {
        ResetCollectibleCounter();
    }

    public void OnBeforeSerialize()
    {

    }
}

