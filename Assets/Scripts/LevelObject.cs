using UnityEngine;

[CreateAssetMenu(fileName = "Level", menuName = "ScriptableObjects/LevelObject", order = 1)]
public class LevelObject : ScriptableObject
{
    public string prefabName;

    public Vector3[] spawnPoints;
}
