# AIM Projesi

![image](https://github.com/enbiyagoral/Basic_AIM_Lab/assets/100806254/5cde0373-cc32-4d1d-9217-8a4f5889ed05)

Bu proje, Windows Forms kullanarak geliştirilen basit bir oyun uygulamasını içerir. Oyunda hedeflere tıklanarak puan kazanılırken, belirli bir süre içinde mümkün olduğunca çok puan kazanmaya çalışılır.

## Başlangıç

Projeyi yerel bilgisayarınıza klonlamak ve çalıştırmak için aşağıdaki adımları izleyebilirsiniz:

1. Bu projeyi GitHub'dan klonlayın veya ZIP dosyası olarak indirin.

2. Proje klasörüne gidin ve `AIM_PROJESI.sln` dosyasını çift tıklayarak Visual Studio veya Visual Studio Code ile açın.

3. Projeyi derleyin ve çalıştırın.

4. Oyunu oynamaya başlamak için form üzerindeki hedefe (pictureBox1) tıklayın. Oyuna başladığınızda zamanlayıcı başlayacak ve belirli bir süre içinde puan kazanmaya çalışacaksınız.

## Oyun Kuralları

- Başlangıçta 5 canınız vardır (`health`).
- Toplam puanınızı (`score`) görmek için etiketler üzerinden takip edebilirsiniz.
- Zamanlayıcı (`timer1`) başladığında, süre her saniye azalır ve ekrandaki süreyi gösteren etiket (`label4`) güncellenir.
- Zaman bittiğinde oyun sona erer ve kazandığınız veya kaybettiğiniz puanlar bir iletişim kutusu ile görüntülenir.
- Ekrandaki hedefe tıkladıkça puan kazanırsınız.
- Hedefe tıkladıkça yeni bir rastgele konuma taşınır.
- Oyun sırasında yeşil hedef dışına basarsanız canlarınız (`health`) azalır. Canlarınız tükendiğinde oyun sona erer ve puanlarınız görüntülenir.

## Katkıda Bulunma

Eğer projeye katkıda bulunmak veya hataları düzeltmek istiyorsanız, aşağıdaki adımları izleyebilirsiniz:

1. Bu repo'yu fork edin.
2. Yeni özellikler ekleyin veya hata düzeltmeleri yapın.
3. Değişikliklerinizi bir pull isteği (pull request) olarak gönderin.
4. İnceleme süreci başlayacaktır.
