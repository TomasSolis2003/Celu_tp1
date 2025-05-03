/*using UnityEngine;

public class ZoneSlowdown : MonoBehaviour
{
    [Range(0f, 1f)]
    public float slowdownFactor = 0.7f; // 70% de la velocidad original = 30% menos

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("AUTO"))
        {
            CarControllerGyro car = other.GetComponent<CarControllerGyro>();
            if (car != null)
            {
                car.ApplySlowdown(slowdownFactor);
            }
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("AUTO"))
        {
            CarControllerGyro car = other.GetComponent<CarControllerGyro>();
            if (car != null)
            {
                car.ResetSpeed();
            }
        }
    }
}
*/
using UnityEngine;

public class ZoneSlowdown : MonoBehaviour
{
    public float slowdownFactor = 0.7f; // Reduce al 70% de la velocidad original

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("AUTO"))
        {
            CarControllerGyro car = other.GetComponent<CarControllerGyro>();
            if (car != null)
            {
                car.ApplySlowdown(slowdownFactor);
            }
        }
    }
}
