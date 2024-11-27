using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Leopotam.Ecs;
using UnityEngine;

public class FalldamageSystem : IEcsRunSystem
{ 
    EcsFilter<Movable,PlayerComponent> fallDamageEventFilter = null;
    public void Run(){
            
            
            foreach (var i in fallDamageEventFilter){
        
                var movableComponent = fallDamageEventFilter.Get1(i);
                ref bool isFalling = ref movableComponent.isFalling;
                ref var playerComponent = ref fallDamageEventFilter.Get2(i);
                if(isFalling & movableComponent.rb.velocity.y==0){
                    playerComponent.health=playerComponent.health-20;  
                    isFalling=false;
                }
                Debug.Log("хп падает в полете"+playerComponent.health);
             }
    }
}
