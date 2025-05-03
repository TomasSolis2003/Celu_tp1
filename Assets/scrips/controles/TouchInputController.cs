using UnityEngine;

public class TouchInputController : MonoBehaviour
{
    public CarControllerGyro carController;

    void Update()
    {
        bool accelerating = false;
        bool braking = false;

        foreach (Touch touch in Input.touches)
        {
            if (touch.position.x > Screen.width / 2)
            {
                // Lado derecho = acelerar
                accelerating = true;
            }
            else if (touch.position.x < Screen.width / 2)
            {
                // Lado izquierdo = frenar
                braking = true;
            }
        }

        carController.SetInput(accelerating, braking);
    }
}
