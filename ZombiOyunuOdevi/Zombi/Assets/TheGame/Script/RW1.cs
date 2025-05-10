using UnityEngine;

public class RW1 : MonoBehaviour 
{
    private Camera playerCamera; 

    void Start()
    {
        // Player'ın child'ındaki kamerayı bul
        playerCamera = GetComponentInChildren<Camera>();
        if (playerCamera == null)
        {
            Debug.LogError("Child objelerde kamera bulunamadı!");
        }
    }

    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
    
            Ray mouseRay = playerCamera.ViewportPointToRay(new Vector3(0.5f, 0.5f, 0));
            RaycastHit hitInfo;

            if (Physics.Raycast(mouseRay, out hitInfo, 100f))
            {
                Debug.Log("Çarpılan nesne: " + hitInfo.transform.name);
            }
    }
}
}