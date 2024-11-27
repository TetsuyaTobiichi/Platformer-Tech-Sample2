
//input cheking
using Leopotam.Ecs;
using UnityEngine;


public class PlayerInputSystem : IEcsRunSystem
{
    EcsFilter<InputEvent> inputEventsFilter=null;

    public void Run(){

        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        foreach(var i in inputEventsFilter){
                
                inputEventsFilter.Get1(i).direction = new Vector3(x,0,z);     
                //Debug.Log(inputEventsFilter.Get1(i).direction+"  a,j,f");   
           }  
        

    }
}
