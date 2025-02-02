using UnityEngine;
using Zenject;

public class GameInstaller : MonoInstaller
{
    [SerializeField] private GameSettingsAsset gameSettings;
    [SerializeField] private GamePrefabsAsset gamePrefabs;

    public override void InstallBindings()
    {

        Container.BindInstance(gameSettings).AsSingle();
        Container.BindInstance(gamePrefabs).AsSingle();
    }


}
