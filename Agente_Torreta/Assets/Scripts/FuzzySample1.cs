using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class FuzzySample1 : MonoBehaviour {
    
    
    
    public AnimationCurve critical;
    public AnimationCurve hurt;
    public AnimationCurve healthy;

    #region UI
    private const string labelText = "{0} true";
    public InputField healthInput;

    public Text healthyLabel;
    public Text hurtLabel;
    public Text criticalLabel;
    #endregion

    private float criticalValue = 0f;
    private float hurtValue = 0f;
    private float healthyValue = 0f;

    private void Start () {
        SetLabels();
    }

    /*
     * Evaluates all the curves and returns float values
     */
    public void EvaluateHealth() {
        #region UI
        if (string.IsNullOrEmpty(healthInput.text)) {
            return;
        }
        float inputValue = float.Parse(healthInput.text);
        #endregion
        
        healthyValue = healthy.Evaluate(inputValue);
        hurtValue = hurt.Evaluate(inputValue);
        criticalValue = critical.Evaluate(inputValue);

        //Poner las reglas

        SetLabels();
    }

    /*
     * Updates the GUI with the evluated values based
     * on the health percentage entered by the
     * user.
     */
    private void SetLabels() {
        healthyLabel.text = string.Format(labelText, healthyValue);
        hurtLabel.text = string.Format(labelText, hurtValue);
        criticalLabel.text = string.Format(labelText, criticalValue);        
    }
}
