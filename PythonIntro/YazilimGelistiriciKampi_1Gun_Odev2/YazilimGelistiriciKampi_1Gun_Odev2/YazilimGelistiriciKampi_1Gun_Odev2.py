#Site giriş sayfası ilk satır

def ilkSatiriListele():
    for satir in ilkSatir:
        print(satir)
def egitimleriListele():
    for egitim in egitimler:
        print(egitim)
def tamamlanmaListele():
    for tamamlanma in tamamlanmaOranlari:
        print(tamamlanma)

anaSite = "Kodlama.io"

ilkSatir = ["Kurslarım", "Tüm Kurslar", "Kampa Hazırlık", "Sık Sorulan Sorular", "Kullanıcı Girişi"]

egitimler = ["Yazılım Geliştirici Kampı", "Programlamaya Giriş İçin Temel Kurs"]

tamamlanmaOranlari = ["25", "100"]

kullaniciAdi = "MesutSoyumert"
parola = "parola"

girilenKullaniciAdi = "MesutSoyumert"
girilenParola = "parola"

#kullanici için kontrol

if kullaniciAdi == girilenKullaniciAdi and parola == girilenParola:
    print ("Kullanıcı girişi başarılı")
    print(anaSite)
    ilkSatiriListele()
    egitimleriListele()
    tamamlanmaListele()
else:
    print("Kullanıcı girişi başarısız")



