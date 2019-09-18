# cekSB
cekSB - proses smartbilling client agar tidak terputus dari server

cara pakai bisa dijalankan file debugnya (file ada di cekSB/CekSB/obj/Debug/) atau bisa dengan cara lain terserah anda seperti menjalankan program windows biasa. dan lebih baik jalankan di startup windowsnya


cara kerja program ini adalah mengecek proses SmartBillingClient selama 5 menit , 
jika tidak ada proses SmartBillingClient maka smartstarter.exe dijalankan otomatis, jika proses SmartBillingClient ada maka tidak melakukan apa apa dan menunggu 5 menit untuk pengecekan selanjutnya.

pastikan folder smartbilling_client ada di drive C: ya 

terima kasih
