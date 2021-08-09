using System.Collections;
using System.Collections.Generic;
using System.Data;
using UnityEditorInternal;
using UnityEngine;

public class TileManager : MonoBehaviour
{
    //public GameObject[] tilePrefabs;
    //public float zSpawn = 0;
    //public float tileLength = 495;
    //public int numberOfTiles = 5;
    //private List<GameObject> activeTiles = new List<GameObject>();
    //public Transform playerTransform;


    // void Start()
    //{

    //for (int i = 0;i<numberOfTiles;i++)
    //{
    // if (i == 0)
    //   spawnTile(0);
    //else
    //  spawnTile(Random.Range(1, tilePrefabs.Length));
    //}
    //}

    // Update is called once per frame
    //void Update()
    // {
    //    if(playerTransform.position.z  > zSpawn - (numberOfTiles * tileLength))
    //   {
    //  spawnTile(Random.Range(0, tilePrefabs.Length));
    // DeleteTile();
    // }
    //  }
    // public void spawnTile(int tileİndex)
    // {
    // GameObject go = Instantiate(tilePrefabs[tileİndex], transform.right * zSpawn, transform.rotation);
    //  activeTiles.Add(go);
    //  zSpawn += tileLength;
    // }
    // private void DeleteTile()
    // {
    //    Destroy(activeTiles[0]);
    // activeTiles.RemoveAt(0);
    //  }


    public GameObject[] tilePrefabs;
    private Transform playerTransform;
    private float spawnx = 0.0f;
    private float tileLength = 493.0f;
    private float tilesOnScreen = 1;
    private List<GameObject> activeTile ;
    private int lastPrefabİndex = 0;

    private void Start()
    {
        activeTile = new List<GameObject>();


        playerTransform = GameObject.FindGameObjectWithTag("Player").transform;
        for(int i =0; i<tilesOnScreen;i++)
        {
            if (1 < 2)
            {
                spawnTile(0);
            }
            else
            {
                spawnTile();
            }
        }
    }

    private void Update()
    {
       
            if (playerTransform.position.x > 282 )
            {
                spawnTile();
           
            }

    }

    private void spawnTile(int prefabİndex = -1)
    {
        GameObject go;

        if (prefabİndex == -1)
        {
            go = Instantiate(tilePrefabs[RandomPrefabİndex()]) as GameObject;
        }
        else
        {
            go = Instantiate(tilePrefabs[prefabİndex]) as GameObject;
        }
        go.transform.SetParent(transform);
        go.transform.position = Vector3.left * spawnx;
        spawnx += tileLength;
        activeTile.Add(go);
    }

   private int RandomPrefabİndex()
    {
        if (tilePrefabs.Length <= 1)
            return 0;
        int randomİndex = lastPrefabİndex;
        while(randomİndex == lastPrefabİndex)
        {
            randomİndex = Random.Range(0, tilePrefabs.Length);
        }
        lastPrefabİndex = randomİndex;
        return randomİndex;

    }

   



}
