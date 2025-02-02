using UnityEngine;

[CreateAssetMenu(fileName = "GameSettings", menuName = "Game/Game Settings")]
public class GameSettingsAsset : ScriptableObject
{
    [Range(1, 100)] public int GridWidth = 10;
    [Range(1, 100)] public int GridHeight = 10;
    public float Spacing = 1f;
    [Range(0f, 1f)] public float SpecialPrefabSpawnChance = 0.2f;
}
