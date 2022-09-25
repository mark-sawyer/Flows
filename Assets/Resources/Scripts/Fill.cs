using UnityEngine;

[ExecuteInEditMode]
public class Fill : MonoBehaviour {
    [SerializeField] Stock stock;
    private Transform liquid_wave;
    private Transform liquid;
    private float amount;
    private float amountToPixelScalar;
    private float waveHeightScalar;

    void Start() {
        amountToPixelScalar = (Constants.WINDOW_PIXELS + Constants.WAVE_HEIGHT) / Constants.MAX_FILL;
        waveHeightScalar = (Constants.WINDOW_PIXELS + Constants.WAVE_HEIGHT) / (Constants.MAX_FILL * Constants.PIXELS_PER_UNIT);
        liquid_wave = transform.GetChild(0);
        liquid = transform.GetChild(1);
        setColour();
    }
    private void Update() {
        updateSprites();
    }


    private void updateSprites() {
        amount = stock.getAmount();
        updateWaveHeight(amount);
        updateLiquidScale(amount);
    }
    private void updateWaveHeight(float amount) {
        Vector3 pos = liquid_wave.localPosition;
        pos.y = (-Constants.WINDOW_PIXELS / (2 * Constants.PIXELS_PER_UNIT)) + (waveHeightScalar * amount);
        liquid_wave.localPosition = pos;
    }
    private void updateLiquidScale(float amount) {
        Vector3 scale = liquid.localScale;
        scale.y = amount * amountToPixelScalar;
        liquid.localScale = scale;
    }



    private void setColour() {
        Colour enumColour = stock.getColour();
        Color colour = EnumToColour.convert(enumColour);
        liquid.GetComponent<SpriteRenderer>().color = colour;
        liquid_wave.GetComponent<SpriteRenderer>().color = colour;
    }
}
