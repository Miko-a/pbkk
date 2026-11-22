# Student Registration

Aplikasi desktop sederhana berbasis WPF untuk melihat data mahasiswa dan
program studinya. Data disimpan di SQL Server dan diakses langsung dengan
ADO.NET (`Microsoft.Data.SqlClient`), tanpa Entity Framework. Untuk saat ini
aplikasi baru mendukung operasi baca (read) beserta tombol refresh.

## Struktur folder

```
StudentRegistration/
├── Models/
│   ├── Program.cs
│   └── Student.cs
├── Repositories/
│   └── StudentRepository.cs
├── MainWindow.xaml
├── MainWindow.xaml.cs
└── script.sql 
```

Kode dipisah menjadi tiga bagian: **Models** untuk bentuk data,
**Repositories** untuk semua urusan database, dan **MainWindow** untuk
tampilan. Dengan begitu `MainWindow` tidak perlu tahu cara query dijalankan,
cukup meminta daftar mahasiswa ke repository.

## Cara menjalankan

1. Pastikan SQL Server sedang aktif. Cek dengan `Get-Service *sql*` di
   PowerShell, service `MSSQLSERVER` harus berstatus Running.
2. Buka SSMS atau Azure Data Studio, sambungkan ke `localhost`, lalu jalankan
   script SQL untuk membuat database, tabel `Programs` dan `Students`, serta
   mengisi data awalnya.
3. Cocokkan nama database di script dengan `Database=` pada connection string
   di `StudentRepository.cs`.
4. Pastikan paket NuGet `Microsoft.Data.SqlClient` sudah terpasang, lalu
   jalankan project dari Visual Studio.

## Cara kerja aplikasi

Begitu jendela utama dibuat, constructor `MainWindow` membuat objek
`StudentRepository` dan langsung memanggil `LoadStudents()`. Method ini meminta
`GetAll()` untuk membaca semua mahasiswa, lalu hasilnya dipasang ke
`StudentDataGrid`. Menekan tombol **Refresh** menjalankan `LoadStudents()`
sekali lagi sehingga tabel menampilkan data terbaru.

Kalau ada yang salah di tengah jalan, misalnya server tidak ditemukan,
exception ditangkap di `LoadStudents()` dan pesannya muncul dalam dialog
**Database Error**. Aplikasi tidak langsung tertutup.

## Penjelasan kode

### Models

`Student` merepresentasikan satu baris hasil query: `StudentId`, `NIM`, `Name`,
`ProgramId`, `ProgramName`, `BirthDate`, `Address`, `PhoneNumber`, `CreatedAt`,
dan `UpdatedAt`. `ProgramName` sebenarnya bukan kolom tabel `Students`, nilainya
datang dari tabel `Programs` lewat join. `BirthDate` dan `UpdatedAt` bertipe
`DateTime?` karena boleh kosong di database.

`Program` merepresentasikan tabel `Programs` (`ProgramId`, `ProgramCode`,
`ProgramName`, `IsActive`). Kelas ini disiapkan untuk fitur berikutnya dan
belum dipakai oleh tampilan.

Kedua kelas dideklarasikan `public`. Ini penting untuk `Student`, karena
tipenya muncul pada method `public` di repository.

### StudentRepository

Method `GetAll()` menjalankan query berikut:

```sql
SELECT s.StudentId, s.NIM, s.Name, s.ProgramId, p.ProgramName,
       s.BirthDate, s.Address, s.PhoneNumber, s.CreatedAt, s.UpdatedAt
FROM Students s
INNER JOIN Programs p ON s.ProgramId = p.ProgramId
ORDER BY s.StudentId;
```

`INNER JOIN` dipakai agar nama program studi ikut terbawa. Konsekuensinya,
mahasiswa yang `ProgramId`-nya tidak ada di `Programs` tidak akan tampil.

Setelah koneksi dibuka dan `ExecuteReader()` dijalankan, setiap baris dibaca
dan diubah menjadi objek `Student`:

- Kolom dibaca lewat `GetOrdinal("NamaKolom")`, jadi urutan kolom pada
  `SELECT` tidak memengaruhi hasil.
- Kolom yang bisa bernilai NULL dicek dulu dengan `IsDBNull`. Tanpa
  pengecekan ini, membaca NULL akan melempar exception. `BirthDate` dan
  `UpdatedAt` diisi `null`, sedangkan `Address` dan `PhoneNumber` diisi string
  kosong.
- `SqlConnection` dan `SqlCommand` dibuat dengan `using var`, sehingga
  otomatis dibersihkan setelah method selesai.

### MainWindow

`MainWindow.xaml` berisi judul, tombol Refresh, dan `DataGrid` dengan kolom
yang ditentukan manual (`AutoGenerateColumns="False"`): ID, NIM, Nama, Program
Studi, Tanggal Lahir, dan No. Telepon. Tabelnya bersifat read-only. Tiap kolom
di-bind ke properti pada kelas `Student`, dan tanggal lahir ditampilkan dengan
format `dd/MM/yyyy`.

## Tampilan aplikasi

<img width="895" height="495" alt="image" src="https://github.com/user-attachments/assets/b5708ae2-08c7-4257-98b5-dc3e44e35478" />
