using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EstadoEspera : InstruccionesFSM
{
    public override void EnterState(TorretaEstatica torreta)
    {
        //Inicia el estado de espera
        Debug.Log("Inicio Estado de espera!");
    }

    public override void UpdateState(TorretaEstatica torreta)
    {
        //Ejecuci�n del estado espera
    }
}
