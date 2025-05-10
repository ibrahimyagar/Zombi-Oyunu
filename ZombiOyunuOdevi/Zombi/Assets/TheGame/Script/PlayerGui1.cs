using UnityEngine;
using System.Collections;
public class PlayerGui1 : MonoBehaviour
 {
 
 [SerializeField] Texture2D _crosshair;
 
 void OnGUI()
 
 {
    float x = (Screen.width - _crosshair.width) / 2;
    float y = (Screen.height - _crosshair.height) / 2;
    GUI.DrawTexture(new Rect(x, y, 32, 32), _crosshair);
}
}