//moving
using Leopotam.Ecs;
using UnityEngine;
using UnityEngine.EventSystems;

public class MoveSystem : IEcsRunSystem
{
    //_playerBody.velocity=_playerBody.transform.forward;
    EcsFilter<Movable,InputEvent> playerMoveFilter=null;
    public void Run(){
        
        foreach (var i in playerMoveFilter){
            
            var movableComponent = playerMoveFilter.Get1(i);

            var inputComponent = playerMoveFilter.Get2(i);
            
            Vector3 moveDirection=inputComponent.direction*movableComponent.moveSpeed;

            movableComponent.rb.velocity = new Vector3(moveDirection.x, movableComponent.rb.velocity.y,moveDirection.z);
            //Debug.Log(movableComponent.rb.velocity);

            if (inputComponent.direction.sqrMagnitude > 0.001f) {
        Quaternion targetRotation = Quaternion.LookRotation(inputComponent.direction, Vector3.up);
        movableComponent.transform.rotation = Quaternion.Slerp(
            movableComponent.transform.rotation,
            targetRotation,
            Time.deltaTime * 10f
        );
    }
           //
          // Debug.Log(movableComponent.rb.velocity.y); 
        }
    }
}
