# Oyun Programlama Ödev 1 - Unity Etkileşim Projesi 🎮

Bu proje, Unity oyun motoru kullanılarak temel fizik kuralları, kamera takibi ve dinamik obje etkileşimlerini kavramak amacıyla geliştirilmiş bir 3D uygulamadır. 

Ana karakter (küre), sahnedeki farklı objelerle etkileşime girerek çeşitli reaksiyonları (renk değiştirme, ışınlanma ve skor artışı) tetikler. C# ile yazılan scriptler üzerinden Rigidbody fizikleri ve kullanıcı arayüzü (UI) yönetimi sağlanmıştır.

## 🚀 Projedeki Temel Mekanikler

* **Karakter Kontrolü:** `Rigidbody` ve `linearVelocity` kullanılarak yatay ve dikey eksende akıcı hareket.
* **Zıplama Özelliği:** Klavye (Space) girdisi ile anlık kuvvet (`AddForce`) uygulayarak dikey hareket.
* **Pürüzsüz Kamera Takibi:** `LateUpdate` fonksiyonu ile kameranın, karakterin fiziksel hareketlerini titremeden, akıcı bir şekilde izlemesi.
* **Dinamik Etkileşimler (OnTriggerEnter):**
  * **Renk Değişimi:** Özel küpe çarpıldığında `Random.ColorHSV()` ile objenin renginin rastgele değişmesi.
  * **Işınlanma ve Döngü:** Toplanabilir objeye (mavi küp) çarpıldığında, objenin yok olmak yerine sahnede rastgele yeni bir koordinata (`Random.Range`) ışınlanması.
* **Kullanıcı Arayüzü (UI):** Toplanabilir objeye her temas edildiğinde sağ üst köşedeki Skor metninin anlık olarak güncellenmesi.

## 📺 Oynanış ve Sunum Videosu

Projenin nasıl çalıştığını ve kodların açıklamalarını aşağıdaki videodan izleyebilirsiniz:

[![Oyun Sunum Videosu](https://img.youtube.com/vi/5oP6X3uCjbM/maxresdefault.jpg)](https://youtu.be/5oP6X3uCjbM)

*(Videoyu izlemek için görsele tıklayabilirsiniz)*

---
**Geliştirici:** Ahmet Selen
**Öğrenci No:** 132430070
**Bölüm:** Uludağ Üniversitesi - Yönetim Bilişim Sistemleri (YBS)
