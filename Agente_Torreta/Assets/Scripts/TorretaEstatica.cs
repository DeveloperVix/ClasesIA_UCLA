using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum AgentState { Idle, Rotation, Attack}

public class TorretaEstatica : MonoBehaviour
{
    public AgentState currentState;

    public InstruccionesFSM curState;

    [Header("Elementos del sensor")]
    public LayerMask playerMask;
    public float radiusDetection = 2f;
    public Transform sensorPosition;
    public bool playerDetected = false;

    //public readonly 

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
