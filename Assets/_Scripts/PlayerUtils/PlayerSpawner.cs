using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSpawner : MonoBehaviour {

    private PlayerInit playerInit;

    [SerializeField]
    private GameObject playerPrefab;

    private void Awake()
    {
        playerInit = this.gameObject.GetComponent<PlayerInit>();

    }

    private void Start()
    {
        playerPrefab = playerInit.getPrefabPlayer();
        SpawnPlayer();
        
    }

    private void SpawnPlayer()
    {
        GameObject playerInstantiated = Instantiate(playerPrefab) as GameObject;

        playerInstantiated.transform.rotation = this.transform.rotation;
        playerInstantiated.transform.position = this.transform.position;
        playerInstantiated.SetActive(true);

    }

}
