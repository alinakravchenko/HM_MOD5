#region TASK2
//Shop store = new Shop("У Тома ", " Дружно жить 18 ", " Булочная ", " 8(928)111-22-33 ", " Tom_happyTom@gmail.com", 65);
//store.GetShopInfo();
//int newstoreroom = 31; store.Shoparea += newstoreroom;
//store.GetShopInfo();
//int storeroom = 22; store.Shoparea -= storeroom;
//store.GetShopInfo();
//Console.WriteLine(store);
//Shop shop3 = new Shop("", "", "", "", "", 0);
//shop3.AddShop(shop3);
//shop3.GetShopInfo();
//class Shop
//{
//    string _SHname;
//    string _SHaddress;
//    string _Buns;
//    string _SHgemail;
//    string _phoneNumber;
//    int _SHarea;
//    public string Name
//    {
//        get => _SHname; set => _SHname = value;
//    }
//    public string Address
//    {
//        get => _SHaddress; set => _SHaddress = value;
//    }
//    public string ProfShop
//    {
//        get => _Buns; set => _Buns = value;
//    }
//    public string PhoneNumb
//    {
//        get => _phoneNumber; set => _phoneNumber = value;
//    }
//    public string EmailShop
//    {
//        get => _SHgemail; set => _SHgemail = value;
//    }
//    public int Shoparea
//    {
//        get => _SHarea; set => _SHarea = value;
//    }
//    //Constructor
//    public Shop(string name, string address, string buns, string numphone, string gemail, int sharea)
//    {
//        _SHname = name;
//        _SHaddress = address;
//        _Buns = buns;
//        _phoneNumber = numphone;
//        _SHgemail= gemail;
//        _SHarea = sharea;
//    }
//    public static int operator +(Shop SHarea, int addshoparea)
//    {
//        SHarea._SHarea += addshoparea;
//        return SHarea._SHarea;
//    }
//    public static bool operator ==(Shop SHarea, Shop othersharea)
//    {
//        return SHarea._SHarea == othersharea._SHarea;
//    }
//    public static bool operator !=(Shop SHarea, Shop othersharea)
//    {
//        return SHarea._SHarea != othersharea._SHarea;
//    }
//    public static bool operator <(Shop SHarea, Shop othersharea)
//    {
//        return SHarea._SHarea < othersharea._SHarea;
//    }
//    public static bool operator >(Shop SHarea, Shop othersharea)
//    {
//        return SHarea._SHarea > othersharea._SHarea;
//    }
//    public static int operator -(Shop SHarea, int reduceshoparea)
//    {
//        SHarea._SHarea -= reduceshoparea;
//        return SHarea._SHarea;
//    }
//    public Shop AddShop(Shop shop)
//    {
//        Console.Write("Введите название магазина:"); string shname = Console.ReadLine();
//        Console.Write("Введите адресс магазина:"); string address = Console.ReadLine();
//        Console.Write("Введите профиль магазина:"); string buns = Console.ReadLine();
//        Console.Write("Введите номер телефона магазина:"); string phone = Console.ReadLine();
//        Console.Write("Введите эл.почту магазина:"); string gemail = Console.ReadLine();
//        Console.Write("Введите площадь магазина:"); int area = Int32.Parse(Console.ReadLine());
//        return shop;
//    }
//    public override string ToString()
//    {
//        return " Название магазина: " + Name + ";\n Адресс: " + Address + ";\n Специализация магазина: " + ProfShop + ";\n Контактный номер: " + PhoneNumb + ";\n Адресс электронной почты: " + EmailShop + ";\n Площадь: " + Shoparea.ToString() + " кв. метров";
//    }
//    public void GetShopInfo()
//    {
//        Console.WriteLine(ToString());
//    }
//}
#endregion


