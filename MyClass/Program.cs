using MyClass;

Book book = new Book("Толстой Л.Н.", "Война и мир", "Наука", 823, 2013, 101, true);

//book.Info();

//book.TakeItem();

//book.Info();


Magazine magazine = new Magazine("О природе", 5, "Земля и мы",
2014, 1235, true);

//magazine.Info();


Console.WriteLine("Тестирование полиморфизма");

Item item;

item = book;

item.TakeItem();
item.Return();
item.Info();

item = magazine;

item.TakeItem();
item.Return();
item.Info();

//Book.SetPrice(13);

//book.PriceBook(5);

//Console.WriteLine(book.PriceBook(5));


//Item item = new Item();

//item.Info();