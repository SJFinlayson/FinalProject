using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class EasyDiff : MonoBehaviour
{
    public void makeEasyDungeon() {
        //Debug.Log("Easy");
        GameObject dungeon = GameObject.FindGameObjectWithTag("Dungeon");
        DungeonGeneration dungeonGeneration = dungeon.GetComponent<DungeonGeneration>();
        if (dungeonGeneration.numberOfRooms >= 5) {
            dungeonGeneration.numberOfRooms -= 2;
        }
        if (dungeonGeneration.numberOfObstacles >= 2)
        {
            dungeonGeneration.numberOfObstacles -= 1;
        }
        if (dungeonGeneration.numberOfEnemies >= 2)
        {
            dungeonGeneration.numberOfEnemies -= 1;
        }
        dungeonGeneration.ResetDungeon();
        SceneManager.LoadScene("DungeonGame");
    }
}
