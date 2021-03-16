using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EstadoRotacion : InstruccionesFSM
{
    public override void EnterState(TorretaEstatica torreta)
    {
        Debug.Log("Entro a estado de rotación");
    }

    public override void UpdateState(TorretaEstatica torreta)
    {
        
    }
}
