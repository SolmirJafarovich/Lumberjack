using UnityEngine;
using Zenject;

public class GameFieldGenerator : MonoBehaviour
{
    private GameSettingsAsset _settings;
    private GamePrefabsAsset _prefabs;

    [Inject]
    public void Construct(GameSettingsAsset settings, GamePrefabsAsset prefabs)
    {
        _settings = settings;
        _prefabs = prefabs;
    }

    private void Start()
    {
        GenerateGrid();
    }

    private void GenerateGrid()
    {
        for (int x = 0; x < _settings.GridWidth; x++)
        {
            for (int y = 0; y < _settings.GridHeight; y++)
            {
                Vector3 position = new Vector3(x * _settings.Spacing, 0, y * _settings.Spacing);
                SpawnTile(position);
                TrySpawnGameObject(position);
            }
        }
    }

    private void SpawnTile(Vector3 position)
    {
        Instantiate(_prefabs.BlockPrefab, position, Quaternion.identity, transform);
    }

    private void TrySpawnGameObject(Vector3 tilePosition)
    {

        if (Random.value <= _settings.SpecialPrefabSpawnChance) 
        {
            GameObject prefab = _prefabs.GameObjectPrefabs[Random.Range(0, _prefabs.GameObjectPrefabs.Length)];
            Vector3 objectPosition = tilePosition + Vector3.up * 1f; 
            Instantiate(prefab, objectPosition, Quaternion.identity, transform);
        }
    }
}
