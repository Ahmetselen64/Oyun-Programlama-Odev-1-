using UnityEngine;

public class KameraTakip : MonoBehaviour
{


    public GameObject takipEdilecekObje; // Bizim durumumuzda Sphere
    private Vector3 mesafe; // Kamera ile top arasýndaki sabit fark
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // Oyun baþýnda kamera ile top arasýndaki mesafeyi hesapla ve kaydet
        mesafe = transform.position - takipEdilecekObje.transform.position;
    }

    // Update is called once per frame
    void LateUpdate()
    {
        // Kameranýn yeni pozisyonu = Topun anlýk yeri + baþtaki sabit mesafe
        transform.position = takipEdilecekObje.transform.position + mesafe;
    }
}
