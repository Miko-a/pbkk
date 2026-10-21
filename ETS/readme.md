Nama: Farrel Jatmiko Aji

NRP: 5025241193

# Pertanyaan ETS

## 1. Jelaskan deskripsi dan ruang lingkup fitur aplikasi Desktop Rich UI yang dibuat.

**KasKita** merupakan aplikasi desktop berbasis Windows yang dirancang untuk membantu pengelolaan keuangan organisasi mahasiswa secara digital, terstruktur, dan transparan. Aplikasi ini dikembangkan menggunakan bahasa pemrograman **C# dengan framework .NET 8 dan Windows Presentation Foundation (WPF)** untuk menghasilkan antarmuka Rich UI yang modern, interaktif, dan mudah digunakan. KasKita juga menggunakan SQLite sebagai basis data untuk menyimpan informasi keuangan organisasi.

Ruang lingkup fitur aplikasi KasKita meliputi:

1. **Login dan Manajemen Pengguna:** Mengatur akses aplikasi berdasarkan tiga peran, yaitu Bendahara, Ketua, dan Anggota.
2. **Dashboard Keuangan:** Menampilkan informasi saldo kas, pemasukan, pengeluaran, tunggakan iuran, serta grafik perkembangan keuangan organisasi.
3. **Manajemen Transaksi Kas:** Mencatat pemasukan dan pengeluaran, mengelompokkan kategori transaksi, serta mendukung proses persetujuan pengeluaran tertentu.
4. **Pengelolaan Iuran Anggota:** Mencatat pembayaran iuran dan memantau status anggota yang sudah membayar maupun yang masih menunggak.
5. **Manajemen Anggaran Kegiatan:** Mengatur rencana anggaran dan memantau realisasi pengeluaran untuk setiap kegiatan organisasi.
6. **Laporan Keuangan:** Menyajikan rekapitulasi transaksi dan memungkinkan ekspor laporan ke format PDF maupun Excel.
7. **Pengelolaan Data dan Backup:** Mengelola data anggota, periode kepengurusan, kategori transaksi, serta melakukan pencadangan dan pemulihan data.

Dengan fitur-fitur tersebut, KasKita tidak hanya berfungsi sebagai aplikasi pencatatan keuangan, tetapi juga sebagai sistem informasi yang membantu pengurus organisasi dalam memantau, mengelola, dan mengevaluasi kondisi keuangan secara lebih efektif.

## 2. Apa latar belakang dan Manfaat aplikasi tersebut di buat.

**Latar Belakang**

Aplikasi KasKita dibuat berdasarkan permasalahan pengelolaan keuangan yang sering terjadi pada organisasi mahasiswa. Pencatatan keuangan masih banyak dilakukan secara manual menggunakan buku kas, spreadsheet, atau pesan dalam grup komunikasi. Cara tersebut dapat menyebabkan data transaksi tidak terorganisasi, kesalahan pencatatan, kesulitan memantau pembayaran iuran anggota, serta kurangnya transparansi dalam penggunaan dana organisasi.

Selain itu, pembuatan laporan keuangan secara manual membutuhkan waktu dan menyulitkan pengurus ketika melakukan evaluasi anggaran kegiatan. Oleh karena itu, dikembangkan aplikasi KasKita sebagai solusi digital yang dapat mengintegrasikan seluruh proses pengelolaan keuangan organisasi dalam satu sistem berbasis desktop.

**Manfaat Aplikasi**

1. **Meningkatkan efisiensi administrasi**, karena pencatatan transaksi dan pembuatan laporan dapat dilakukan secara lebih cepat dan terstruktur.
2. **Meningkatkan transparansi dan akuntabilitas**, sehingga pemasukan dan pengeluaran organisasi dapat dipantau serta dipertanggungjawabkan.
3. **Mempermudah pemantauan kas dan iuran**, melalui dashboard yang menampilkan kondisi keuangan dan status pembayaran anggota.
4. **Mengurangi risiko kesalahan pencatatan**, karena data tersimpan secara terpusat dalam basis data.
5. **Mendukung pengambilan keputusan**, dengan menyediakan laporan serta visualisasi data keuangan yang mudah dipahami.
6. **Mempermudah pengelolaan anggaran kegiatan**, sehingga penggunaan dana dapat disesuaikan dengan perencanaan.

Dengan adanya KasKita, diharapkan organisasi mahasiswa dapat mengelola keuangannya secara lebih **efisien, transparan, akurat, dan profesional**, sekaligus memanfaatkan teknologi untuk meningkatkan kualitas administrasi organisasi.

## 3. Buat Poster Infografis aplikasi yang telah dibuat dalam 1 halaman.

<img width="1600" height="2300" alt="Poster_Infografis_KasKita_Revisi" src="https://github.com/user-attachments/assets/e4e3ab0e-cf68-4bf0-ab02-9813c0a6a9b5" />


<img width="240" height="320" alt="image" src="https://github.com/user-attachments/assets/0b9e3134-4ec8-4707-ba1c-fa936343ff86" />



# Laporan Personal ETS: Aplikasi KasKita

## 1. Deskripsi Singkat

KasKita merupakan aplikasi desktop yang dikembangkan untuk membantu pengelolaan keuangan organisasi mahasiswa. Dalam sebuah organisasi, pencatatan pemasukan, pengeluaran, iuran anggota, dan anggaran kegiatan perlu dilakukan secara teratur agar kondisi keuangan dapat diketahui dengan jelas. Apabila pencatatan hanya dilakukan secara manual, risiko kesalahan perhitungan, kehilangan catatan, dan kesulitan dalam menyusun laporan dapat meningkat.

KasKita dibuat untuk membantu proses tersebut melalui satu aplikasi yang mengintegrasikan pencatatan transaksi, pengelolaan iuran, pengajuan anggaran, dan pembuatan laporan keuangan. Aplikasi ini juga menerapkan pembagian hak akses agar setiap pengguna dapat menjalankan tugas sesuai dengan perannya.

Aplikasi dikembangkan menggunakan **C# dan WPF** dengan .NET 8. Arsitektur MVVM digunakan untuk memisahkan tampilan, pengelolaan data tampilan, dan logika aplikasi. Sementara itu, SQLite digunakan sebagai basis data lokal dengan bantuan Entity Framework Core.

Fitur utama KasKita meliputi:
- **Dashboard:** menampilkan ringkasan kondisi keuangan organisasi.
- **Transaksi:** mencatat pemasukan dan pengeluaran beserta informasi pendukungnya.
- **Iuran anggota:** membantu pengelolaan pembayaran iuran anggota.
- **Anggaran kegiatan:** mengelola anggaran kegiatan dan proses persetujuannya.
- **Laporan keuangan:** menyajikan rekapitulasi keuangan bulanan yang dapat diekspor ke PDF atau Excel.
- **Hak akses pengguna:** membedakan akses Bendahara, Ketua, dan Anggota.

Dengan fitur-fitur tersebut, KasKita diharapkan dapat membuat pengelolaan keuangan organisasi menjadi lebih terstruktur, mudah ditelusuri, dan transparan.

- Link Repository: https://github.com/Miko-a/KasKita
- Link Demo: https://youtu.be/mV4gYxfGaKI
- Link PRD: https://docs.google.com/document/d/104-ydLPS9vUFL73pSE94ZDUV3hY2efUM/edit?usp=sharing&ouid=112422738255319447217&rtpof=true&sd=true

## 2. Kontribusi Personal

Kami mengerjakan proyek ini bersama-sama.

## 3. Tampilan Aplikasi

Bagian ini memperlihatkan antarmuka KasKita dan menjelaskan fungsi setiap halaman. Ganti setiap penanda gambar dengan screenshot asli aplikasi. Simpan gambar dalam folder `screenshots` di direktori yang sama dengan README.

### 3.1. Halaman Login

<!-- SCREENSHOT: Halaman Login -->

<img width="425" height="595" alt="image" src="https://github.com/user-attachments/assets/be6ef75b-ec28-4ffb-b723-fbfa4dd454e1" />


Halaman login merupakan titik awal penggunaan aplikasi. Pengguna memasukkan kredensial untuk mengakses sistem. Setelah proses autentikasi berhasil, aplikasi dapat menentukan halaman dan fitur yang sesuai dengan peran pengguna.

Pemisahan akses diperlukan karena tidak semua pengguna memiliki tanggung jawab yang sama. Sebagai contoh, Bendahara bertanggung jawab terhadap pencatatan keuangan, sedangkan Ketua memiliki peran dalam proses persetujuan tertentu.

### 3.2. Dashboard

<!-- SCREENSHOT: Dashboard KasKita -->

<img width="1307" height="772" alt="image" src="https://github.com/user-attachments/assets/f7993274-c322-4194-9aab-3c7e584e1b65" />

> Dashboard Ketua

<img width="1312" height="777" alt="image" src="https://github.com/user-attachments/assets/67a7cc63-5fd7-42b8-85dc-10762d995e2a" />

> Dashboard Bendahara

<img width="1306" height="772" alt="image" src="https://github.com/user-attachments/assets/68450a2e-2c02-471e-9a6f-24a623d71fd5" />

> Dashboard Anggota

Dashboard berfungsi sebagai ringkasan kondisi keuangan organisasi. Informasi yang ditampilkan membantu pengguna memahami keadaan keuangan tanpa harus membuka setiap catatan transaksi satu per satu.

Dashboard juga menjadi titik awal navigasi ke fitur lainnya. Dengan adanya ringkasan ini, pengguna dapat memperoleh gambaran awal mengenai pemasukan, pengeluaran, dan saldo sebelum melakukan pemeriksaan yang lebih terperinci.

### 3.3. Transaksi dan Iuran

<!-- SCREENSHOT: Halaman Transaksi -->

<img width="1633" height="967" alt="image" src="https://github.com/user-attachments/assets/5197170d-d222-4d3e-b0ad-5074d1f5c638" />

> Tab Transaksi pada akun Bendahara


Halaman transaksi digunakan untuk mencatat aktivitas keuangan organisasi, baik berupa pemasukan maupun pengeluaran. Pencatatan transaksi secara terstruktur penting karena laporan keuangan nantinya bergantung pada data transaksi yang tersimpan.

Setiap transaksi perlu memiliki informasi yang memadai agar pengguna dapat memahami tujuan dan nilai transaksi tersebut. Dengan demikian, catatan keuangan tidak hanya berisi angka, tetapi juga dapat digunakan untuk menelusuri aktivitas keuangan yang terjadi.

<!-- SCREENSHOT: Halaman Iuran Anggota -->

<img width="1633" height="967" alt="image" src="https://github.com/user-attachments/assets/c5628afe-8d40-45f3-8510-ef442250a035" />

> Tab Iuran pada akun Bendahara

Halaman iuran digunakan untuk membantu pengelolaan kewajiban pembayaran anggota. Pencatatan iuran memudahkan organisasi dalam memantau pembayaran dan mengurangi ketergantungan pada catatan manual yang terpisah.

### 3.4. Anggaran Kegiatan

<!-- SCREENSHOT: Halaman Anggaran -->

<img width="1309" height="777" alt="image" src="https://github.com/user-attachments/assets/aa56d2ee-7d46-41f6-92a8-00da161d4bfa" />

> Tab Anggaran sebagai Bendahara

Halaman anggaran digunakan untuk mengelola kebutuhan dana kegiatan. Salah satu mekanisme yang diterapkan adalah persetujuan untuk pengeluaran dengan nilai minimal Rp500.000. Pengeluaran yang memenuhi ketentuan tersebut memerlukan persetujuan Ketua sebelum dapat diperlakukan sebagai transaksi yang disetujui.

Mekanisme ini membantu menjaga pengawasan terhadap pengeluaran dalam jumlah besar. Status persetujuan juga penting karena pengajuan yang masih menunggu keputusan tidak seharusnya langsung dianggap sebagai pengeluaran yang telah disahkan.

### 3.5. Laporan Keuangan

<!-- SCREENSHOT: Halaman Laporan Keuangan -->

<img width="1308" height="780" alt="image" src="https://github.com/user-attachments/assets/d9a633e1-d526-442b-8857-05c14e711300" />

> Tab laporan keuangan sebagai bendahara

Halaman laporan digunakan untuk melihat rekapitulasi keuangan berdasarkan periode tertentu. Laporan bulanan merangkum saldo awal, total pemasukan, total pengeluaran, saldo akhir, dan mutasi keuangan.

Secara umum, saldo akhir diperoleh dengan menambahkan pemasukan pada saldo awal, kemudian mengurangi pengeluaran yang diperhitungkan dalam laporan. Agar hasilnya konsisten, data yang digunakan harus mengikuti status transaksi yang berlaku. Pada KasKita, laporan menggunakan transaksi yang telah disetujui.

Laporan juga dapat diekspor ke PDF atau Excel sehingga hasil rekapitulasi lebih mudah disimpan, dibagikan, dan digunakan sebagai dokumentasi organisasi.

## 4. Hasil Pengujian

Pengujian dilakukan untuk memeriksa apakah fitur aplikasi berjalan sesuai dengan tujuan dan aturan yang telah ditentukan. Setiap skenario perlu dijalankan pada aplikasi, kemudian hasil aktualnya dibandingkan dengan hasil yang diharapkan.

| No. | Skenario Pengujian | Hasil yang Diharapkan | Hasil Aktual |
|---|---|---|---|
| 1 | Login dengan kredensial yang benar | Pengguna berhasil masuk ke aplikasi. | <img width="1306" height="772" alt="image" src="https://github.com/user-attachments/assets/68450a2e-2c02-471e-9a6f-24a623d71fd5" /> |
| 2 | Login dengan kredensial yang salah | Akses ditolak dan pengguna memperoleh informasi kegagalan login. | <img width="432" height="598" alt="image" src="https://github.com/user-attachments/assets/ea3ff718-49e7-4fee-bd80-fbfa880a007b" /> |
| 3 | Menambahkan transaksi | Data transaksi tersimpan dan ditampilkan sesuai implementasi aplikasi. | <img width="1311" height="779" alt="image" src="https://github.com/user-attachments/assets/87019725-ad63-4ae9-90f2-3d4ab072a848" /> |
| 4 | Mengajukan pengeluaran minimal Rp500.000 | Pengeluaran mengikuti mekanisme persetujuan Ketua. | <img width="1313" height="771" alt="image" src="https://github.com/user-attachments/assets/d0c4317b-88c0-462b-84d7-1d225aafcfec" /> |
| 5 | Melihat laporan keuangan | Rekapitulasi ditampilkan berdasarkan transaksi yang memenuhi ketentuan laporan. | <img width="1308" height="775" alt="image" src="https://github.com/user-attachments/assets/29dabefd-0885-44cb-99ba-bab201d81e45" /> |
| 6 | Mengekspor laporan | Laporan berhasil dibuat dalam format yang dipilih. | <img width="840" height="526" alt="image" src="https://github.com/user-attachments/assets/81190133-96f8-4819-9ee7-c982ee65b1f3" />

 <img width="837" height="527" alt="image" src="https://github.com/user-attachments/assets/d8e4cb8e-2a97-4899-92e9-13749b8a0dd4" />
|

## 5. Jawaban Refleksi

### 5.1. Mengapa menggunakan arsitektur MVVM?

MVVM (*Model-View-ViewModel*) digunakan untuk memisahkan tanggung jawab setiap bagian aplikasi. Model merepresentasikan data dan struktur yang digunakan, View menangani tampilan antarmuka, sedangkan ViewModel menghubungkan data dengan kebutuhan tampilan serta mengelola interaksi pengguna.

Pemisahan tersebut membantu menjaga kode agar tidak seluruhnya menumpuk pada halaman antarmuka. Ketika logika aplikasi perlu diperbaiki, pengembang dapat berfokus pada bagian yang relevan tanpa harus selalu mengubah seluruh tampilan. Pendekatan ini juga membuat struktur program lebih mudah dipahami dan dikembangkan.

### 5.2. Bagaimana aplikasi menyimpan data?

KasKita menggunakan SQLite sebagai basis data lokal dan Entity Framework Core untuk membantu interaksi antara program dengan basis data. Data seperti pengguna, anggota, transaksi, iuran, kegiatan, dan anggaran direpresentasikan melalui model.

Penggunaan basis data memungkinkan data disimpan secara terstruktur dan digunakan kembali ketika aplikasi dibuka. Hal ini berbeda dengan hanya menyimpan informasi di variabel sementara, yang umumnya tidak bertahan setelah aplikasi ditutup.

Basis data lokal juga membuat aplikasi tidak harus bergantung pada server basis data terpisah untuk penggunaan dasarnya. Namun, penyimpanan lokal memiliki keterbatasan jika beberapa pengguna membutuhkan data bersama dari perangkat yang berbeda.

### 5.3. Bagaimana pembagian hak akses diterapkan?

KasKita memiliki tiga peran utama, yaitu Bendahara, Ketua, dan Anggota. Pembagian peran bertujuan menyesuaikan akses dengan tanggung jawab masing-masing pengguna.

Bendahara berfokus pada pengelolaan keuangan, Ketua berperan dalam persetujuan yang memerlukan otorisasi, sedangkan Anggota menggunakan fitur yang relevan dengan kebutuhannya. Dengan pembagian ini, aplikasi dapat mengurangi risiko tindakan yang tidak sesuai dengan tanggung jawab pengguna.

Penting untuk memastikan bahwa pembatasan akses tidak hanya dilakukan dengan menyembunyikan tombol pada antarmuka, tetapi juga diterapkan pada logika yang menjalankan tindakan tersebut.

### 5.4. Bagaimana mekanisme persetujuan pengeluaran bekerja?

Mekanisme persetujuan digunakan untuk memberikan pengawasan tambahan terhadap pengeluaran bernilai besar. Pada KasKita, pengeluaran minimal Rp500.000 memerlukan persetujuan Ketua.

Secara konseptual, sistem memeriksa nilai pengeluaran dan menentukan apakah transaksi dapat diproses sesuai alur biasa atau harus menunggu persetujuan. Jika memerlukan persetujuan, transaksi ditempatkan pada status menunggu keputusan. Setelah keputusan diberikan, statusnya menjadi dasar bagi proses selanjutnya.

Pemisahan status ini penting karena pengajuan pengeluaran tidak selalu berarti pengeluaran tersebut sudah disetujui. Jika keduanya dianggap sama, laporan keuangan berpotensi mencatat pengeluaran yang belum memperoleh otorisasi.

### 5.5. Bagaimana laporan keuangan dihitung?

Laporan keuangan menyusun data transaksi menjadi ringkasan yang lebih mudah dibaca. Saldo awal menunjukkan kondisi keuangan pada awal periode, sedangkan pemasukan dan pengeluaran menunjukkan perubahan yang terjadi selama periode tersebut.

Perhitungan dasarnya adalah:

**Saldo akhir = Saldo awal + Total pemasukan − Total pengeluaran**

Sebagai contoh, jika saldo awal sebesar Rp1.000.000, pemasukan sebesar Rp500.000, dan pengeluaran yang disetujui sebesar Rp200.000, saldo akhirnya adalah Rp1.300.000.

Contoh tersebut menjelaskan prinsip perhitungannya. Dalam aplikasi, ketepatan laporan juga bergantung pada pemilihan periode, klasifikasi transaksi, dan aturan mengenai transaksi yang boleh dihitung. Karena itu, transaksi yang masih menunggu persetujuan perlu dibedakan dari transaksi yang sudah disetujui.

## 6. Kesimpulan

KasKita dikembangkan sebagai aplikasi desktop untuk membantu pengelolaan keuangan organisasi mahasiswa melalui pencatatan transaksi, pengelolaan iuran, pengajuan anggaran, dan penyusunan laporan keuangan.

Penggunaan C#, WPF, MVVM, SQLite, dan Entity Framework Core mendukung pemisahan tanggung jawab kode serta penyimpanan data yang terstruktur. Selain itu, pembagian hak akses dan mekanisme persetujuan pengeluaran membantu mendukung proses pengelolaan keuangan yang lebih tertib.

Melalui pengembangan aplikasi ini, penerapan konsep pemrograman desktop, pengelolaan basis data, pemisahan logika aplikasi, dan pengujian perangkat lunak dapat dipelajari dalam satu proyek yang memiliki kebutuhan nyata.

## Lampiran A. Struktur Proyek

Struktur utama proyek KasKita terdiri atas beberapa bagian berikut:

| Folder | Fungsi |
|---|---|
| `Data` | Mengatur konteks dan akses basis data. |
| `Models` | Menyimpan representasi data yang digunakan aplikasi. |
| `Resources` | Menyimpan sumber daya pendukung antarmuka. |
| `Services` | Menangani layanan dan logika tertentu yang digunakan oleh aplikasi. |
| `ViewModels` | Menghubungkan data dan logika aplikasi dengan tampilan melalui pola MVVM. |
| `Views` | Menyimpan halaman serta komponen antarmuka pengguna. |

Pembagian folder tersebut membantu memisahkan komponen berdasarkan tanggung jawabnya. Dengan struktur yang jelas, pengembang dapat lebih mudah mencari kode yang perlu diperiksa atau diperbaiki.

## Lampiran B. Cara Menjalankan Aplikasi

### Persyaratan

- Windows 10 atau Windows 11.
- .NET 8 SDK.
- Visual Studio 2022 dengan workload **.NET desktop development**, atau .NET CLI.

### Langkah menjalankan

1. Clone repositori KasKita dan buka direktori proyek.
2. Pulihkan dependensi menggunakan perintah:

   ```bash
   dotnet restore .\KasKita\KasKita.csproj
   ```

3. Jalankan aplikasi menggunakan perintah:

   ```bash
   dotnet run --project .\KasKita\KasKita.csproj
   ```

Saat pertama kali dijalankan, aplikasi menyiapkan basis data dan data awal apabila belum tersedia pengguna. Basis data lokal disimpan pada direktori `%LOCALAPPDATA%\KasKita\kaskita.db`.

### Akun Demo

| Peran | Username | Password |
|---|---|---|
| Bendahara | `bendahara` | `bendahara123` |
| Ketua | `ketua` | `ketua123` |
| Anggota | `anggota` | `anggota123` |

Akun di atas merupakan kredensial demo yang tercantum dalam dokumentasi proyek. Gunakan akun tersebut untuk mencoba fitur berdasarkan peran masing-masing, dan jangan menggunakan kredensial demo sebagai kata sandi untuk akun pribadi.

---
