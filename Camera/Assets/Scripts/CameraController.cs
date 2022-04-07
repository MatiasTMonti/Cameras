using UnityEngine;

public class CameraController : MonoBehaviour
{
    [SerializeField] private Camera mainCamera;
    [SerializeField] private Camera thirdPCamera;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Tab) && mainCamera.gameObject.activeSelf)
        {
            mainCamera.gameObject.SetActive(false);
            thirdPCamera.gameObject.SetActive(true);
        }
        else if (Input.GetKeyDown(KeyCode.Tab) && thirdPCamera.gameObject.activeSelf)
        {
            thirdPCamera.gameObject.SetActive(false);
            mainCamera.gameObject.SetActive(true);
        }
    }
}
