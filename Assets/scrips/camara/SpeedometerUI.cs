/*using UnityEngine;
using UnityEngine.UI;  // Para UI Text
// Si usas TextMeshPro, descomenta la línea de abajo:
// using TMPro;

public class SpeedometerUI : MonoBehaviour
{
    public Rigidbody carRigidbody;     // El Rigidbody del auto
    public Text speedText;             // UI Text para mostrar la velocidad
    // Si usas TextMeshPro, comenta la línea de arriba y descomenta la de abajo:
    // public TextMeshProUGUI speedText;

    void Update()
    {
        // Obtener velocidad en m/s
        float speed = carRigidbody.velocity.magnitude;

        // Convertir a km/h (opcional: multiplica por 3.6)
        float speedKmh = speed * 3.6f;

        // Mostrar en pantalla (redondeado)
        speedText.text = Mathf.RoundToInt(speedKmh) + " km/h";
    }
}
*/
using UnityEngine;
using TMPro;  // Asegúrate de tener esto

public class SpeedometerTMP : MonoBehaviour
{
    public Rigidbody carRigidbody;            // El Rigidbody del auto
    public TextMeshProUGUI speedText;         // Referencia al TextMeshPro en la UI

    void Update()
    {
        // Obtener velocidad en m/s
        float speed = carRigidbody.velocity.magnitude;

        // Convertir a km/h (multiplica por 3.6)
        float speedKmh = speed * 3.6f;

        // Mostrar en pantalla (redondeado)
        speedText.text = Mathf.RoundToInt(speedKmh) + " km/h";
    }
}
