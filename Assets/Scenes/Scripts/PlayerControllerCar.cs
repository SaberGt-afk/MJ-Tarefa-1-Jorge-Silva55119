using UnityEngine;
using TMPro;

public class PlayerControllerCar : MonoBehaviour
{
    [Header("Movimento")]
    public float speed = 5.0f;
    public float turnSpeed = 100f;
    public float acceleration = 10f;

    [Header("UI - Textos TMP")]
    public TMP_Text rpmText;
    public TMP_Text speedText;

    private float horizontalInput;
    private float forwardInput;

    private float currentSpeed = 0f;
    private float targetSpeed = 0f;
    private float rpm = 0f;

    void FixedUpdate()
    {
        // Entrada do jogador
        horizontalInput = Input.GetAxis("Horizontal");
        forwardInput = Input.GetAxis("Vertical");

        // Movimento do carro
        transform.Translate(Vector3.forward * Time.deltaTime * speed * forwardInput);
        transform.Rotate(Vector3.up, turnSpeed * horizontalInput * Time.deltaTime);

        // Calcula velocidade alvo (baseada na entrada)
        targetSpeed = Mathf.Abs(forwardInput) * speed * 20f;

        // Suaviza a aceleração/desaceleração
        currentSpeed = Mathf.Lerp(currentSpeed, targetSpeed, Time.deltaTime * acceleration);

        // Simula RPM com base na velocidade atual
        rpm = currentSpeed * 50f;

        // Atualiza UI
        if (speedText != null)
            speedText.text = "Speed: " + currentSpeed.ToString("F0") + " km/h";

        if (rpmText != null)
            rpmText.text = "RPM: " + rpm.ToString("F0");
    }
}
