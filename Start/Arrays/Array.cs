List<string> fruitList = new List<string>();

        fruitList.Add("apple");
        string[] fruits = { "orange", "banana", "melon" };
        fruitList.AddRange(fruits);
        Console.WriteLine(fruitList);