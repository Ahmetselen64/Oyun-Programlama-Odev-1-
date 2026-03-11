using UnityEngine;
using UnityEngine.UI;

public class TopKontrol : MonoBehaviour
{
    public float hiz = 5f;
    public float ziplamaGucu = 5f; // Yeni ekledik

    public Text skorYazisi;
    private Rigidbody rb;

    private int skor = 0;

    void Start()
    {
        // Oyun baþladýðýnda kürenin Rigidbody bileþenini alýyoruz
        rb = GetComponent<Rigidbody>();
        SkoruGuncelle();
    }

    void FixedUpdate()
    {
        // Klavyeden (WASD veya Yön Tuþlarý) gelen girdileri alýyoruz
        float yatayHareket = Input.GetAxis("Horizontal");
        float dikeyHareket = Input.GetAxis("Vertical");

        // Girdilere göre bir hareket vektörü oluþturuyoruz (Y eksenindeki yerçekimini koruyarak)
        Vector3 hareket = new Vector3(yatayHareket * hiz, rb.linearVelocity.y, dikeyHareket * hiz);

        // Küreye güç uygulayarak hareket ettiriyoruz
        rb.linearVelocity = hareket;
    }

    // Küre, "Is Trigger" iþaretli bir objenin içine girdiðinde bu fonksiyon çalýþýr
    void OnTriggerEnter(Collider diger)
    {
        // 1. DURUM: "Toplanabilir" etiketli küp (Iþýnlanan küp)
        if (diger.gameObject.CompareTag("Toplanabilir"))
        {


            // SKOR ARTIRMA: Her çarptýðýnda 1 artýr
            skor = skor + 1;
            SkoruGuncelle();

            // Küpü yok etmek yerine rastgele yeni bir konuma gönderiyoruz
            // X ve Z deðerlerini zeminine (Plane) göre ayarlayabilirsin (Örn: -9 ile 9 arasý)
            float rastgeleX = Random.Range(-9f, 9f);
            float rastgeleZ = Random.Range(-9f, 9f);

            diger.gameObject.transform.position = new Vector3(rastgeleX, 0.5f, rastgeleZ);
        }

        // 2. DURUM: Eðer etiketi "RenkDegistiren" ise (Yeni Küp)
        if (diger.gameObject.CompareTag("RenkDegistiren"))
        {
            // Yok olmazlar, sadece renk deðiþtirirler
            diger.gameObject.GetComponent<Renderer>().material.color = Random.ColorHSV();
        }
    }

    void Update() // Zýplama gibi anlýk tuþ vuruþlarý Update içinde yakalanýr
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.AddForce(Vector3.up * ziplamaGucu, ForceMode.Impulse);
        }
    }
    void SkoruGuncelle()
    {
        skorYazisi.text = "Skor: " + skor.ToString();
    }






}
