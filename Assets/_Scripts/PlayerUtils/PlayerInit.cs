using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInit : MonoBehaviour {

    private readonly string prefabPlayerPath = "prefabs/Player";

    [SerializeField]
    GameObject prefabPlayer;

    private void Awake()
    {
        prefabPlayer = Resources.Load(prefabPlayerPath) as GameObject;

    }

    public GameObject getPrefabPlayer()
    {
        if (prefabPlayer != null)
        {
            return prefabPlayer;
        } else
        {
            prefabPlayer = Resources.Load(prefabPlayerPath) as GameObject;
            return prefabPlayer;
        }
    }

}
