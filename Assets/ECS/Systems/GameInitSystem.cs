using Leopotam.Ecs;
using UnityEngine;


public class GameInitSystem : IEcsInitSystem
{
    EcsWorld _world=null;
    public void Init(){

        EcsEntity player = _world.NewEntity();

        ref var move = ref player.Get<Movable>();
        ref var inputEvent = ref player.Get<InputEvent>();
        ref var playerComponent = ref player.Get<PlayerComponent>();
        

        var spawnedPlayer = GameObject.Instantiate(PlayerInitData.LoadFromAssets().playerPref,Vector3.zero,Quaternion.identity);


        move.moveSpeed=PlayerInitData.LoadFromAssets().defaultMoveSpeed;
        move.jumpForce = PlayerInitData.LoadFromAssets().defaultJumpForce;
        move.rb = spawnedPlayer.GetComponent<Rigidbody>();
        move.transform = spawnedPlayer.transform;
        inputEvent.direction = Vector3.up;
   

        playerComponent.health= PlayerInitData.LoadFromAssets().defaultHealth;
        playerComponent.saveHeight= PlayerInitData.LoadFromAssets().defaultSaveHeight;
       // Debug.Log(player.GetComponentsCount());
    }
}
