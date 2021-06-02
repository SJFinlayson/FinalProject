using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MediumDiff : MonoBehaviour
{
    public void makeMediumDungeon() {
        //Debug.Log("MEdium");
        GameObject dungeon = GameObject.FindGameObjectWithTag("Dungeon");
        DungeonGeneration dungeonGeneration = dungeon.GetComponent<DungeonGeneration>();
        dungeonGeneration.ResetDungeon();
        SceneManager.LoadScene("DungeonGame");
    }
}
