<h1>Custom Collection Initalizers</h1>

<p>
  C#-da collection initializers, daha asan və oxunaqlı bir şəkildə başlatmaq üçün istifadə edilən bir özəllikdir. Bu özəllik sayəsində collection class-lara element əlavə etmə zamanı daha     oxunaqlı və qısa bir syntax ilə edilə bilər.
</p>
<div style = "width:100%; margin:20px" >
  <img style = "width: 600px"  src= "https://github.com/user-attachments/assets/47e14f43-c50c-43ff-b438-65f981363f23" />
</div>
<p>
  Yuxarıdakı kodun məzh özü bir collection initializer-dir.
</p>

<div style = "width:100%; margin:20px" >
  <img style = "width: 600px"  src= "https://github.com/user-attachments/assets/519fa68a-2ece-4cb0-a31d-80630b8b253f" />
</div>

<p>
  Bizim yuxarıdakı kimi data əlavə edə bilməyimiz collection initializers durumurdur.
</p>
<br>
Okay əla, gözəl biz bu özəlliyi istifadə edərik. Sual yaranır ki... br
<strong>Bəs bizlər bu özəlliyi öz class-larımıza necə tətbiq edə bilərik?</srtong>

<div style = "width:100%; margin:20px" >
  <img style = "width: 600px"  src= "https://github.com/user-attachments/assets/b91f674d-0e15-46fb-ba03-3216851823a4" />
</div>
<p>
  Bu şəkildə kod yazdıqda bu object initializer durumudur.
</p>
<p>
  Mən isə bir class-ın collection davranışı eləməsini istəyirəm. <br>
Özəl yaradılan class-lara collection initializer özəlliyini qazandıra bilmək üçün aşağıdakı kimi bir çalışma edilməlidir. Bir class-a collection initializer özəlliyi qazandırıla bilməsi üçün həmən class-a collection collectible bir class olmalıdır. Bir class-ın da collectible class ola bilməsi üçün IEnumerable interfeysindən implement edilməsi lazımdır.

</p>

<div style = "width:100%; margin:20px" >
  <img style = "width: 600px"  src= "https://github.com/user-attachments/assets/9bb4ff21-cdc2-44fa-a5c2-d9e7881c79d8" />
</div>

<p>
  Bizlər bir class-ı IEnumerable class-ından implement etsək belə yenə də bu bir collection initializer olmayacaqdır.<strong> Bu class-ın collectible özəllik qazana bilməsi üçün class-ın içərisində geriyə dəyər döndürməyən və adı “Add” olan metod yazılmalıdır.</strong>
</p>

<div style = "width:100%; margin:20px" >
  <img style = "width: 600px"  src= "https://github.com/user-attachments/assets/e4b732a6-1574-47bf-a9b8-c95c83b82542" />
</div>

<p>
  Burada “Add” metodunun parametrinə göndərdiyimiz tip, class yaranarkən yaranacaq <br>
  collection-un tipini müəyyən edir. 
</p>

<div style = "width:100%; margin:20px" >
  <img style = "width: 600px"  src= "https://github.com/user-attachments/assets/2b945bbe-6043-4a4b-9892-644ba275ee41" />
</div>

Bu şəkildə kod yazdıqda iki dəyər də bəyan edə bilərik.


