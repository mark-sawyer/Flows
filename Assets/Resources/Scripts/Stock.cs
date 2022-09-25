using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[ExecuteInEditMode]
public class Stock : MonoBehaviour {
    [SerializeField] private float amount;
    [SerializeField] private Colour colour;

    public void Update() {
        amount = Mathf.Clamp(amount, 0, Constants.MAX_FILL);
    }

    public float getAmount() { return amount; }
    public Colour getColour() { return colour; }
}
