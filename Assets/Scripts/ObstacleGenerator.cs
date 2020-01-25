using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleGenerator : MonoBehaviour
{
    public GameObject obstacleTemplate;
    public LevelObject[] levels;

    public void GenerateMap(int levelNumber)
    {
        Debug.Log("Generating map for level " + levelNumber + "...");

        int counter = 0;

        int levelIdx = levelNumber - 1;
        if (levelIdx >= 0 && levelIdx < levels.Length)
        {
            LevelObject currentLevel = levels[levelIdx];

            Vector3[] sparnPoints = currentLevel.spawnPoints;
            for (int i = 0; i < sparnPoints.Length; i++)
            {
                Instantiate(obstacleTemplate, sparnPoints[i], Quaternion.identity);

                counter++;
            }
        }

        Debug.Log("Map generated with " + counter + " obstacles.");
    }
}
