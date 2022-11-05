using System.Collections;
using Systen,Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{
    public GameObject itemfreefab;
    private transform player;
    public string Itemname;

    // start is called before the first grame update
    void Start()
    {
        player = GameObject.FindGmaeObjecttwitchag("Player").transform;

    }

    public void SpawnDroppedItem()
    {
        vecotr3_playerposition = new Vector3(player.position.x, player.position.y, player.position.z + 4);
        instantiate(itemPrefab, playerposition, Quaternion.idendtity);
    }



}