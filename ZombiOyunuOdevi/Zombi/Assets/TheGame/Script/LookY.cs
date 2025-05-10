using UnityEngine;
using System.Collections;

public class LookY : MonoBehaviour
{
    [SerializeField] private float _mouseSensitivity = 500f;
    [SerializeField] float _alt = -30f;
    [SerializeField] float _ust = 60f;
    private float _rot = 0f; // Dikey a��y� takip etmek i�in

    void Update()
    {
        float mouseY = Input.GetAxis("Mouse Y") * _mouseSensitivity * Time.deltaTime;

        // Dikey rotasyonu g�ncelle
        _rot -= mouseY; // "-" i�areti ��nk� Mouse Y ters �al���yor
        _rot = Mathf.Clamp(_rot, _alt, _ust); // -60 ile +60 aras�nda s�n�rla

        // Transformun rotasyonunu s�f�rdan ba�layarak ayarla
        transform.localEulerAngles = new Vector3(_rot, 0f, 0f);
    }
}