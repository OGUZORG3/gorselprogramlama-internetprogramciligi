<html>
    <head>
    </head>
    <body>
    <?php
   echo min (10,21,5);
   echo"<br>";
   echo max (10,21,5);
   echo"<br>";  
   echo abs(-5);
   echo "<br>";
   echo round (0.43);
   echo"<br>";
   echo rand(10,20);
   $a =10;
   $a +=20;
   echo"<br>";
   echo $a;
   echo"<br>";
   if ($a ==$b=30)
   {
    echo "+";
   }
   else
   {
    echo "-";
   }
   echo "<br>";
   echo($a <=> $b);
   echo "<br>";
   echo "<br>";
   echo "<br>";
   $sehirlers =["balikesir","kutahya","eskisehir"];
   print_r ($sehirlers);
   $sehirler=["Adana", "Adıyaman", "Afyon", "Ağrı", "Amasya", "Ankara", "Antalya", "Artvin", "Aydın", "Balıkesir", "Bilecik", "Bingöl", "Bitlis", "Bolu", "Burdur", "Bursa", "Çanakkale", "Çankırı", "Çorum", "Denizli", 
   "Diyarbakır", "Edirne", "Elazığ", "Erzincan", "Erzurum", "Eskişehir", "Gaziantep", "Giresun", "Gümüşhane", "Hakkari", "Hatay", "Isparta", "İçel (Mersin)", "İstanbul", "İzmir", "Kars", "Kastamonu", "Kayseri", "Kırklareli",
    "Kırşehir", "Kocaeli", "Konya", "Kütahya", "Malatya", "Manisa", "Kahramanmaraş", "Mardin", "Muğla", "Muş", "Nevşehir", "Niğde", "Ordu", "Rize", "Sakarya", "Samsun", "Siirt", "Sinop", "Sivas", "Tekirdağ", "Tokat", "Trabzon", 
    "Tunceli", "Şanlıurfa", "Uşak", "Van", "Yozgat", "Zonguldak", "Aksaray", "Bayburt", "Karaman", "Kırıkkale", "Batman", "Şırnak", "Bartın", "Ardahan", "Iğdır", "Yalova", "Karabük", "Kilis", "Osmaniye", "Düzce"];
   foreach ($sehirler as $key => $value) {
    
    echo "$key: $value <br/>";
   }
   echo "foreach";
   echo"<br>";
   $i=0;
   do {
    echo "$sehirler[$i] $i <br>";
    $i++;
   } while ($i < 81);
   echo "Do While";
   echo"<br>";
   echo"<br>";
   $c=0;
   while ($c < 80) {
       echo "$sehirler[$c] $c <br>";
       $c++;
   }
   echo "While";
   echo"<br>";
   echo"<br>";
   for ($i=0; $i < 80; $i++) { 
    echo "$sehirler[$i] $i <br> ";
   }
    ?>
</body>
</html>    