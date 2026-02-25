using UnityEngine;
using System.Collections.Generic;

public class LevelLoader : MonoBehaviour
{

    public List<GameObject> Levels;
    public Transform LevelParent;
    private GameObject CurrentLevelInstance;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        SpawnLevel(GameData.CurrentLevel);
    }

    public void SpawnLevel(int index){
        if (CurrentLevelInstance != null){
            Destroy(CurrentLevelInstance);
        }

        if (index < Levels.Count){
            CurrentLevelInstance = Instantiate(Levels[index], LevelParent);

            BaseLevel script = CurrentLevelInstance.GetComponent<BaseLevel>();
            script.OnLevelWin.AddListener(NextLevel);
            script.OnLevelLose.AddListener(RestartLevel);

        }

    }

    void NextLevel(){
        GameData.CurrentLevel++;
        SpawnLevel(GameData.CurrentLevel);
    }

    void RestartLevel(){
        SpawnLevel(GameData.CurrentLevel);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
