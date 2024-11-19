using UnityEngine;

public class ButtonHandler : MonoBehaviour
{
    public GameObject player;
    private Vector3 initialPosition;
    private Quaternion initialRotation;

    private void Start()
    {
        if (player != null)
        {
            initialPosition = player.transform.position;
            initialRotation = player.transform.rotation;
        }
    }
    public void ResetPlayerPosition()
    {
        if (player != null)
        {
            player.transform.position = initialPosition;
            player.transform.rotation = initialRotation;
        }
    }
}
