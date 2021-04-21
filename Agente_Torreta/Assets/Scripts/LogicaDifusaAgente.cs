using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LogicaDifusaAgente : MonoBehaviour
{
    [Header("Gráfica para evaluar la motivación")]
    public AnimationCurve noMotivado;
    public AnimationCurve masOMenosMotivado;
    public AnimationCurve motivado;
    public AnimationCurve muyMotivado;

    float noMotivadoValue = 0f;
    float masOMenosMotivadoValue = 0f;
    float motivadoValue = 0f;
    float muyMotivadoValue = 0f;

    //El metodo evalua los puntos de motivacion del agente
    public float EvaluarMotivacion(int puntosMotivacion, float speed)
    {
        noMotivadoValue = noMotivado.Evaluate(puntosMotivacion);
        masOMenosMotivadoValue = masOMenosMotivado.Evaluate(puntosMotivacion);
        motivadoValue = motivado.Evaluate(puntosMotivacion);
        muyMotivadoValue = muyMotivado.Evaluate(puntosMotivacion);

        if(muyMotivadoValue > motivadoValue)
        {
            Debug.Log("Si tengo ganas de hacer las cosas con energía");
        }
        else if(motivadoValue > muyMotivadoValue 
            && masOMenosMotivadoValue < motivadoValue)
        {
            Debug.Log("Voy a hacer las cosas bien");
            speed -= 1;
        }
        else if(noMotivadoValue > masOMenosMotivadoValue)
        {
            Debug.Log("No quiero hacer las cosas!");
            speed = 0;
        }

        return speed;
    }

    private void Update()
    {
        /*if(Input.GetKeyDown(KeyCode.E))
        {
            EvaluarMotivacion();
            puntosMotivacion -= Random.Range(5, 16);
        }*/
    }
}
