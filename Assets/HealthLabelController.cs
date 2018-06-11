using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthLabelController : MonoBehaviour, IHealthListener {

    [SerializeField]
    Text label;
    // Use this for initialization
    void Start () {

        Contexts.sharedInstance.game.CreateEntity().AddHealthListener(this);
    }

    public void OnHealth(GameEntity entity, float value)
    {
        label.text = "Health " + value;
        Debug.Log("OnScore: " + value);
    }
}
