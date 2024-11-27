//connecting with monobehaviour
using Leopotam.Ecs;
using UnityEngine;

public class Loader : MonoBehaviour
{
    EcsWorld world;
    EcsSystems systems;
    void Start()
    {
        world = new EcsWorld();
        systems = new EcsSystems(world);
        systems.Add(new GameInitSystem());
        systems.Add(new PlayerInputSystem());
        systems.Add(new MoveSystem());
        systems.Add(new FalldamageSystem());
        systems.Add(new FallingSystem());
        systems.Init();
    }

    // Update is called once per frame
    void Update()
    {
        systems.Run();
    }

    void OnDestroy(){
        systems.Destroy();
        world.Destroy();
    }
}
