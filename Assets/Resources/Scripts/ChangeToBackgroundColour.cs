using UnityEngine;

[ExecuteInEditMode]
public class ChangeToBackgroundColour : MonoBehaviour {
    private void Start() {
        Camera camera = Camera.main;
        Color backgroundColour = camera.backgroundColor;
        backgroundColour.a = 1;
        SpriteRenderer spriteRenderer = GetComponent<SpriteRenderer>();
        spriteRenderer.color = backgroundColour;
    }
}
