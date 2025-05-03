/*using UnityEngine;

public class CarControllerGyro : MonoBehaviour
{
    public float speed = 10f;            // Velocidad del auto
    public float turnSpeed = 5f;         // Sensibilidad al girar
    private float calibrationOffset = 0; // Offset para calibración

    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();

        // Calibrar el centro (acelerómetro en X)
        calibrationOffset = Input.acceleration.x;
    }

    void Update()
    {
        // Leer inclinación del dispositivo, ajustado al offset
        float tilt = Input.acceleration.x - calibrationOffset;

        // Girar el auto
        transform.Rotate(0, tilt * turnSpeed, 0);

        // Mover hacia adelante constantemente
        rb.MovePosition(transform.position + transform.forward * speed * Time.deltaTime);
    }
}
*/
using UnityEngine;

public class CarControllerGyro : MonoBehaviour
{
    public float maxSpeed = 10f;           // Velocidad máxima del auto
    public float acceleration = 5f;        // Cuánto acelera cuando no se toca
    public float deceleration = 10f;       // Cuánto desacelera cuando se toca
    public float turnSpeed = 5f;           // Sensibilidad al girar
    private float calibrationOffset = 0;   // Offset para calibración

    private Rigidbody rb;
    private float currentSpeed = 0f;

    void Start()
    {
        rb = GetComponent<Rigidbody>();

        // Calibrar el centro (acelerómetro en X)
        calibrationOffset = Input.acceleration.x;
    }

    void Update()
    {
        // Leer inclinación del dispositivo, ajustado al offset
        float tilt = Input.acceleration.x - calibrationOffset;

        // Girar el auto
        transform.Rotate(0, tilt * turnSpeed, 0);

        // Detectar si se toca la pantalla (en móvil) o click izquierdo (en editor)
        bool isTouching = Input.touchCount > 0 || Input.GetMouseButton(0);

        if (isTouching)
        {
            // Desacelerar hasta frenar
            currentSpeed = Mathf.MoveTowards(currentSpeed, 0, deceleration * Time.deltaTime);
        }
        else
        {
            // Acelerar hasta velocidad máxima
            currentSpeed = Mathf.MoveTowards(currentSpeed, maxSpeed, acceleration * Time.deltaTime);
        }
    }

    void FixedUpdate()
    {
        // Mover hacia adelante según la velocidad actual
        rb.MovePosition(transform.position + transform.forward * currentSpeed * Time.fixedDeltaTime);
    }
}
