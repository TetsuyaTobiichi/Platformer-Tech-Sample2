using System.Collections;
using System.Collections.Generic;
using Leopotam.Ecs;
using UnityEngine;

public class FallingSystem : IEcsRunSystem
{
    EcsFilter<Movable> fallingSystemFilter = null;
    public void Run(){
            foreach(var i in fallingSystemFilter){
                ref var movableComponent =ref fallingSystemFilter.Get1(i);
                if(movableComponent.rb.velocity.y<-10){
                    movableComponent.isFalling=true;
                }
                else movableComponent.isFalling=false;
            }


    }
}
