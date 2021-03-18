using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EstadoAtacar : InstruccionesFSM
{
    float nextFire;
    float rateFire = 1f;

    public override void EnterState(TorretaEstatica torreta)
    {
        Debug.Log("Entro estado atacar!");
        torreta.currentState = AgentState.Attack;

    }

    public override void UpdateState(TorretaEstatica torreta)
    {
        if(torreta.playerDetected == true)
        {
            var lookRotation = Quaternion.LookRotation(torreta.playerTarget.transform.position - torreta.transform.position);
            torreta.transform.rotation = Quaternion.Slerp(torreta.transform.rotation, lookRotation, torreta.speedRotation * Time.deltaTime);

            //Disparar
        }
        else
        {
            torreta.TransitionToState(torreta.idleState);
        }
    }
}
