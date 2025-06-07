using UnityEngine;

public class EntityState
{
    protected StateMachine stateMachine;
    protected string stateName;

    public EntityState(StateMachine stateMachine,string stateName)
    {
        this.stateMachine = stateMachine;
        this.stateName = stateName;
    }

    public virtual void Enter()
    {
        //evertime start will be changed enter will be called
        Debug.Log("I enter " + stateName);
    }

    public virtual void Update()
    {

        //we going to runlogic of the state  here 
        Debug.Log("I run update of " + stateName);
    }

    public virtual void Exit()
    {
        //this will be called everytime we exit  state and change to a new one 
        Debug.Log("I exit" + stateName);
    }
}
   

