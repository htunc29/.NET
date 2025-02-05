# OBJECT ORIANTED PROGRAMMING (OOP) NESNE TABANLI PROGRAMLAMA(NTP)
Kodun daha ölçeklenebilir,yeniden kullanılabilir ve daha yönetilebilir olmasını sağlar.4 adet prensibi vardır.
1. Encapsulation(Kapsülleme)
2. Inheritance(Kalıtım)
3. Polymorphism (Çok biçimcilik)
4. Abstraction (Soyutlama)

### Encapsulation (Kapsülleme)
Veriyi ve ana değişkenleri dışardan direkt olarak erişime kapatmak için (private) sadece gerekli işlemler tarafından kontrollü erişim sağlamaktır.Kodun güvenirliğini ve düzenliliğini arttırır
#### Örnek-1
```csharp
public Class Urun
{
    private decimal fiyat;

    // Kapsülleme
    public decimal GetFiyat()
    {
        return fiyat;
    }

    // 100 TL üzerinde ise ürüne %10 indirim yap
    public void Indırım()
    {
        if(fiyat>100) fiyat*=0.90;
    } 

}
```
#### Örnek-2
```csharp
public Class Musteri
{
    private string _ad;
    private string _soyad;

    public Person(string ad,string soyad)
    {
        _ad=ad;
        _soyad_=soyad;
    }
    public string ad
    {
        get { return _ad; }
        set { _ad = value; }
    }

    public string soyad
    {
        get { return _soyad; }
        set { _soyad = value; }
    }

}
```
### Inheritance (Kalıtım)
Bir sınıfın başka bir sınıftan özellik ve metotlarını miras almasını sağlamaktır genelde ortak özelliklere sahip olan sınıflarda kullanılır kod tekrarını önler ve genişletilebilir bir yapı sunar.
#### Örnek-1
```csharp
public Class Hayvan
{
    public string tur;
    
    public void YemekYe()
    {
        Console.WriteLine($"{tur} yemek yedi");       
    }
}

// Kalıtım ':' işareti ile belirtilir
public Class Kopek:Animal
{
    public void Havla()
    {
        Console.WriteLine($"{tur} havlıyor");
    }
}

//Kullanım
Kopek kopek=new Kopek();
kopek.tur="Boncuk";
kopek.YemekYe();
kopek.Havla();
```
### Polymorphism (Çok Biçimlilik)
Polymorphism, bir metodun farklı şekillerde kullanılabilmesini sağlar.İki türü vardır:
* Method Overriding (Geçersiz Kılma)  → Kalıtım ile ilgilidir
* Method Overloading (Aşırı Yükleme)  → Aynı isimli metodun farklı parametreler ile kullanılmasıdır.

#### Method Overriding Örnek
```csharp
public Class Hayvan
{
    // virtual sanal anlamına gelir child sınıfta override ile ezilebilir
    public virtual void SesCikar()
    {
        Console.WriteLine("hayvan ses çıkardı");
    }
}
public Class Kopek:Hayvan
{
    public override void SesCikar()
    {
        Console.WriteLine("köpek havladı");
    }
}
// kullanım
Hayvan benimHayvanım=new Dog();
benimHayvanım.SesCikar(); //Çıktı köpek havladı

```

#### Method Overloading Örnek
```csharp
public Class Araba
{
    public string _marka;
    public string _model;
    public short _modelYili;
    
    // oluşturucu method constructure
    public Araba(string marka,string model)
    {
        _marka=marka;
        _model=model;
    }
    public Araba(string marka,string model,short modelYili)
    {
        _marka=marka;
        _model=model;
        _mdeolYili=modelYili;
    }
}
```

### Abstraction (Soyutlama)
Gereksiz detayları gizleyerek sadece önemli olanı kullanmaktır.
Interfaceler devreye girer.

#### Örnek

```csharp
public abstract Class Sekil
{
    public abstract double AlanHesapla();
}
public class Daire:Sekil
{
    public double yaricap {get;set;}
    public override double AlanHesapla()
    {
        return Math.PI*yaricap*yaricap;
    }
}
```
### Sorular
1. OOP nedir ve avantajları nelerdir?
    - OOP (Object-Oriented Programming - Nesne Yönelimli Programlama), yazılım geliştirme sürecini nesneler ve bu nesneler arasındaki etkileşimler üzerine kuran bir programlama paradigmasıdır.

    #### ✅ OOP'nin Avantajları
    - ✔ Kodun Modülerliği → Sınıflar ve nesneler ile kod daha düzenli ve okunabilir olur.
    - ✔ Kod Tekrarının Azaltılması → Inheritance (kalıtım) ile tekrar eden kodlar minimize edilir.
    - ✔ Bakım ve Geliştirme Kolaylığı → Encapsulation (kapsülleme) ile değişiklikler tek bir yerde yapılabilir.
    - ✔ Esneklik ve Ölçeklenebilirlik → Polymorphism (çok biçimlilik) ile nesneler farklı şekillerde kullanılabilir.
    - ✔ Güvenlik → Encapsulation sayesinde veriler dışarıdan erişime kapatılabilir.
