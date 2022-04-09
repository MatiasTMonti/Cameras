using UnityEngine;

public class CameraController : MonoBehaviour
{
    [SerializeField] private Camera mainCamera;
    [SerializeField] private Camera thirdPCamera;

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

        RaycastHit hit;
        if (Physics.Raycast(thirdPCamera.transform.position, thirdPCamera.transform.forward, out hit, 10f, LayerMask.GetMask("Interactable")))
        {
            //Debug.DrawRay(thirdPCamera.transform.position, thirdPCamera.transform.forward * 10f, Color.red);
            //Debug.Log(name);

            hit.transform.GetComponent<Interactable>().Interact();
        }
    }
}
