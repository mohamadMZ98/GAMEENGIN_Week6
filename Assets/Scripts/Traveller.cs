using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System;


public class Traveller : MonoBehaviour
{

    public string LastSpawnName
    {
        get;
        set;

    } = "";

    // Start is called before the first frame update
    void Start()
    {
#if UNITY_EDITOR
        DestroySelfIfNotOriginal();
#endif
        DontDestroyOnLoad(gameObject);

        SceneManager.sceneLoaded += OnSceneLoadAction;

    }

    private void DestroySelfIfNotOriginal()
    {
        if(SpawnPoint.Player != this)
        {
            Destroy(gameObject);
        }
    }

    // Update is called once per frame


    void OnSceneLoadAction(Scene scene, LoadSceneMode loadMode)
    {
        //if (LastSpawnName != "")
        //{
        //    SpawnPoint[] spawnPoints = FindObjectOfType<SpawnPoint>();
        //    foreach (SpawnPoint spawn in spawnPoints)
        //    {
        //        if (spawn.name == LastSpawnName)
        //        {
        //            transform.position = spawn.transform.position;
        //        }
        //    }
        //}
    }

    private void OnDestroy()
    {
        SceneManager.sceneLoaded -= OnSceneLoadAction;
        Debug.Log("Geoff is dead");
    }
}
