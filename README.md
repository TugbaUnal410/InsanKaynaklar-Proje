# INSANKAYNAKLARI-PROJE

## Proje Amacı

##### Bu projenin amacı, bir kurumda kullanıcıların rollerine göre yetkilendirilmiş bir personel yönetim sistemi geliştirmektir. Kullanıcılar sisteme giriş yaptıktan sonra yalnızca yetkili oldukları işlemlere erişebilir. Personel kullanıcıları sadece izin talebinde bulunabilirken, insan kaynakları personeli performans, departman, personel ile maaş işlemlerini yönetebilir ve izin talebinde de bulunma erişimi vardır. Yönetici olan kullanıcılar ise izin onay/red işlemleri ve raporlama dahil olmak üzere sistemdeki tüm ekranlara ve işlemlere tam erişime sahiptir.


## Proje Özellikleri:

### Rol bazlı yetkilendirme sistemi:
#### Giriş yapan kullanıcının rolüne göre ana menüde sunulan seçenekler dinamik olarak belirlenir.

### Personel yetkileri:
#### Sadece izin talebinde bulunabilir
#### Kendi izin taleplerinin durumunu görüntüleyebilir

### İnsan Kaynakları (İK) yetkileri:
#### Personel performans işlemleri (ekleme, silme, güncelleme, listeleme)
#### Departman işlemleri (ekleme, silme, güncelleme)
#### Personel maaş işlemleri (ekleme, silme, güncelleme)
#### Personel yönetimi işlemleri
#### İzin talebinde bulunabilir

### Yönetici yetkileri:
#### Beklemede olan izin taleplerini görüntüleme
#### İzin taleplerini onaylama veya reddetme
#### Raporlama ekranına erişim
#### Sistem üzerindeki tüm işlemlere erişim

### 📂 Kullanılan Teknolojiler
#### * C# (.NET Framework)
#### * Windows Forms (Masaüstü uygulama tasarımı)
#### MySQL (Veritabanı)
#### Varlık Katmanı : Katmanlı mimari (Domain,DAL, BLL,UI)


# 📸 Ekran Görüntüleri

### 🔐 Giriş Ekranı

<img width="777" height="452" alt="giris" src="https://github.com/user-attachments/assets/4791836a-b596-4015-a36a-5c104643554c" />

 #### Kullanıcıların ilk girdiklerinde karşılaştıkları ekrandır. Kullnıcılar kendilerine verilen kullanıcı adı ve şifre ile giriş yapar.

### 🏠 Ana Menü
<img width="1051" height="581" alt="anamenu" src="https://github.com/user-attachments/assets/7ea729fc-df4e-4add-940a-2e6ba75cabe0" />

####  Kullanıcı görevine göre yeksi olup olmadığına göre erişime izin veren uygulamada yapılabilecek işlem seçeneklerinin bulunduğu ekrandır.

### 🏢 Departman Yonetimi
<img width="1342" height="738" alt="departman" src="https://github.com/user-attachments/assets/993ee56d-3247-4f71-9f60-22706d8868df" />

 #### İK veya yöneticinin erişimine izin verlidiği departman yönetiminin yapıldığı ekrandır.


### 📈 Performans Yonetimi
<img width="1330" height="719" alt="performans" src="https://github.com/user-attachments/assets/92628d2e-daa6-4aa4-bab4-f38d747fc36d" />

#### İK veya yöneticinin erişimine izin verlidiği performans yönetiminin yapıldığı ekrandır.

### 👥 Personel Yonetimi
<img width="1324" height="728" alt="personel" src="https://github.com/user-attachments/assets/15c43690-3ebc-4b58-93fa-bb3883ad3372" />
 #### İK veya yöneticinin erişimine izin verlidiği personel yönetiminin yapıldığı ekrandır.

### 💵 Maas Yonetimi
<img width="1286" height="697" alt="maas" src="https://github.com/user-attachments/assets/91e54894-45af-4153-95e1-f5a868c5efe1" />

#### İK veya yöneticinin erişimine izin verlidiği maaş yönetiminin yapıldığı ekrandır.

### 📝 İzin Talep
<img width="1337" height="725" alt="izintalep" src="https://github.com/user-attachments/assets/cddffd0c-176e-45c2-87fa-383043e8ef59" />

 #### Personelinde erişiminin izin verildiği yöneticiye izin talebinde bulunulan ve talepte bulunulan izinlerin durumunun görülgüğü ekrandır.

### ✅ İzin Onay
<img width="1333" height="709" alt="izinonay" src="https://github.com/user-attachments/assets/420f2790-f2ac-4c9a-bc28-911012289dff" />

 #### Sadece yoneticinin erişim izninin olduğu personellerin izin taleplerinin görülgüğü ve bu izinlerin onay ve reddedildiği ekrandır.

### 📄 Rapor Ekrani
<img width="1339" height="735" alt="rapor" src="https://github.com/user-attachments/assets/680135ea-1c49-4e56-a5c1-24b270ccd084" />

#### Sadece yöneticinin erişebildiği bir diğer ekrandır. Yönetici bu ekranda butonlara basarak işletme hakkında bilgi topladığı projenin en önemli bölümü diyebiliriz çünkü bir işletmenin stratejik kararlarını bu ekarndan yaralanılarak verilir.

### 💰Departman Maas Yükü
<img width="1295" height="676" alt="departmanperformans" src="https://github.com/user-attachments/assets/ec568d69-68f3-481d-9e9a-d4006974c941" />

#### Raporlama ekranındaki departmanların maaş yükü olan butona basarak ulaştığımız form ekranır.Yönetici bu ekranda istediği tarihler arasında her bir departmana ödeme yaptığını filtreler.

### 📊 Departman Performans
<img width="1336" height="734" alt="departman_performan" src="https://github.com/user-attachments/assets/e61e4f3d-e027-4082-89a0-be596a9a6d2f" />

#### Raporlama ekranındaki departmanların performansı olan butona basarak ulaştığımız form ekranır.Yönetici bu ekranda istediği tarihler arasında her bir performansını grafikler üzerinde inceler.

### 🏆 En Yüksek Performanslı Beş Personel

<img width="1323" height="694" alt="enyuksekperformanlılar" src="https://github.com/user-attachments/assets/ea35211f-e09c-49b3-9868-b3456d5befd4" />

 #### Raporlama ekranındaki en yuksek performanslıolan beş personel olan butona basarak ulaştığımız form ekranır.Yönetici bu ekranda işletme bünyesinde en çok performans puanına sahip 5 personeli görüntüler.



### 💰 En Yüksek Maaşlı Beş Personel
<img width="1341" height="743" alt="enyuksekbespersormanlılar" src="https://github.com/user-attachments/assets/cb77d84a-4437-4959-883d-d01b9d974fd4" />

 #### Raporlama ekranındaki en yuksek maaş alan personeller olan butona basarak ulaştığımız form ekranır.Yönetici bu ekranda işletme bünyesinde seçilen ay ve yıl bazında en yüksek maaş alan personeller filtrelenir.



### 🔍 Maaş Filtreleme

<img width="1336" height="740" alt="maasfiltrele" src="https://github.com/user-attachments/assets/3c4a830e-10ed-4d07-b04f-23e4e12ffc2f" />

#### Raporlama ekranındaki maaş raporla butona basarak ulaştığımız form ekranır.Yönetici bu ekranda işletme bünyesinde seçilen ay ve yıl bazında personeller ödenen maaşları görüntüler.


 ### Proje Yapısı
#### 
#### DAL (Veri Erişim Katmanı) : Veritabanı işlemleri.
#### BLL (İş Mantığı Katmanı) : İş mantığı.
#### UI (Kullanıcı Arayüzü) : Windows Forms kullanıcı arayüzü.
#### MySQL : Veritabanı bağlayıcı ve sorguları.





