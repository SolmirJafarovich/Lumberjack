using UnityEngine;

[CreateAssetMenu(fileName = "GamePrefabs", menuName = "Game/Game Prefabs")]
public class GamePrefabsAsset : ScriptableObject
{
    public GameObject BlockPrefab;
    public GameObject[] GameObjectPrefabs;
}
