using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ReachGoal : MonoBehaviour {
    

	void OnTriggerEnter2D(Collider2D col) {
		if (col.gameObject.tag == "Player") {
			GameObject[] enemies = GameObject.FindGameObjectsWithTag("Enemy");
			if (enemies.Length == 0) {
				GameObject dungeon = GameObject.FindGameObjectWithTag("Dungeon");
                DungeonGeneration dungeonGeneration = dungeon.GetComponent<DungeonGeneration>();
				dungeonGeneration.activateCanvas();
                //SceneManager.LoadScene ("DungeonGame");
            }
        }
	}
}
