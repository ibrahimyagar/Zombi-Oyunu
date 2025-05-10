using UnityEngine;

public class RW2 : MonoBehaviour
{
    private Camera playerCamera;

    void Start()
    {
        Screen.lockCursor = false;
        // Player'ýn child'ýndaki kamerayý bul
        playerCamera = GetComponentInChildren<Camera>();
        if (playerCamera == null)
        {
            Debug.LogError("Child objelerde kamera bulunamadý!");
        }
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.Escape))
        {
            Screen.lockCursor = false;
        }
            if (Input.GetButtonDown("Fire1"))
            {
            Screen.lockCursor = false;
            Ray mouseRay = playerCamera.ViewportPointToRay(new Vector3(0.5f, 0.5f, 0));
            RaycastHit hitInfo;

            if (Physics.Raycast(mouseRay, out hitInfo, 100f))
            {
                Health1 enemyHealth = hitInfo.transform.GetComponent<Health1>();
                if (enemyHealth != null)
                {
                    enemyHealth.Damage(50);
                }
                //Debug.Log("Çarpýlan nesne: " + hitInfo.transform.name);
            }
        }
    }
}