using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class HardDiff : MonoBehaviour
{
    public void makeHardDungeon() {
        //Debug.Log("Hard");
        GameObject dungeon = GameObject.FindGameObjectWithTag("Dungeon");
        DungeonGeneration dungeonGeneration = dungeon.GetComponent<DungeonGeneration>();
        if (dungeonGeneration.numberOfRooms <= 20)
        {
            dungeonGeneration.numberOfRooms += 2;
        }
        if (dungeonGeneration.numberOfObstacles <= 10)
        {
            dungeonGeneration.numberOfObstacles += 1;
        }
        if (dungeonGeneration.numberOfEnemies <= 10)
        {
            dungeonGeneration.numberOfEnemies += 1;
        }
        dungeonGeneration.ResetDungeon();
        SceneManager.LoadScene("DungeonGame");
    }
}
