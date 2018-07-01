using EZCameraShake;
using UnityEngine;

public class ShakeTrigger : MonoBehaviour
{
    public KeyCode shakeKey;

    public CameraShaker cameraShaker;

    // Настройки. Атрибут Header просто помогает нам разделять
    // переменные на панеле Inspector
    [Header("Shake Settings")]
    public float magnitude = 1f;
    public float roughness = 1f;
    public float fadeInTime = 0.5f;
    public float fadeOutTime = 0.4f;

	void Update ()
	{
        // Если нажата указанная нами клавиша то воспроизводим эффект
        if (Input.GetKeyDown(shakeKey))
	    {
	        Shake();
	    }
	}

    
    private void Shake()
    {
        cameraShaker.ShakeOnce(
            magnitude, 
            roughness, 
            fadeInTime, 
            fadeOutTime);
    }
}
