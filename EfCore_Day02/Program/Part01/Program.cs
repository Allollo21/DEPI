// Top - Level statement to save some space 
// Tip: Uncomment region code to test and then comment it back

#region InputAndValidate Function
using day10_G01;

static T InputAndValidate<T>(string prompt, bool allowEmpty = false, T? defaultValue = default)
{
    while (true)
    {
        Console.Write(prompt);
        string? input = Console.ReadLine()!;

        if (allowEmpty && String.IsNullOrWhiteSpace(input))
        {
            return defaultValue!;
        }

        if (typeof(T) == typeof(int))
        {
            if (int.TryParse(input, out int result) && !String.IsNullOrWhiteSpace(input))
            {
                return (T)(object)result;
            }
        }
        else if (typeof(T) == typeof(double))
        {
            if (double.TryParse(input, out double result) && !String.IsNullOrWhiteSpace(input))
            {
                return (T)(object)result;
            }
        }
        else if (typeof(T) == typeof(string))
        {
            if (!String.IsNullOrWhiteSpace(input))
            {
                return (T)(object)input;
            }
        }
        else
        {
            Console.Write("Invalid Data Type. Not Allowed!: ");
            return defaultValue!;
        }
    }
}
#endregion

#region LINQ - Restriction Operators

#region 1. Find all products that are out of stock. 

//var outOfStockProducts = ListGenerators.ProductList
//    .Where(p => p.UnitsInStock == 0);

//foreach (var product in outOfStockProducts)
//{
//    Console.WriteLine(product.ToString());
//}

#endregion

#region 2. Find all products that are in stock and cost more than 3.00 per unit.

//var inStockExpensiveProducts = ListGenerators.ProductList
//    .Where(p => p.UnitsInStock > 0 && p.UnitPrice > 3.00M);

//foreach (var product in inStockExpensiveProducts)
//{
//    Console.WriteLine(product.ToString());
//}

#endregion

#region 3. Returns digits whose name is shorter than their value. 

//string[] Arr = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };

//var NamedDigits = Arr
//    .Select((name, index) => new { Name = name, Value = index })
//    .Where(x => x.Name.Length < x.Value)
//    .Select(x => x.Name);

//foreach (var digit in NamedDigits)
//{
//    Console.WriteLine(digit);
//}

#endregion

#region
#endregion

#endregion

#region LINQ - Element Operators 

#region 1. Get first Product out of Stock

//var firstOutOfStock = ListGenerators.ProductList
//    .First(p => p.UnitsInStock == 0);
//Console.WriteLine("First product out of stock:");
//Console.WriteLine(firstOutOfStock?.ToString() ?? "NA");

#endregion

#region 2. Return the first product whose Price > 1000, unless there is no match, in which case null is returned

//var expensiveProduct = ListGenerators.ProductList
//    .FirstOrDefault(p => p.UnitPrice > 1000);
//Console.WriteLine("\nFirst product with price > 1000:");
//Console.WriteLine(expensiveProduct?.ToString() ?? "NA");

#endregion

#region 3. Retrieve the second number greater than 5

//int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
//var secondNumberGreaterThan5 = Arr
//    .Where(n => n > 5)
//    .Skip(1)
//    .FirstOrDefault();
//Console.WriteLine("\nSecond number greater than 5:");
//Console.WriteLine(secondNumberGreaterThan5);

#endregion

#endregion

#region LINQ - Aggregate Operators

#region 1. Uses Count to get the number of odd numbers in the array

//int[] arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
//var oddCount = arr.Count(n => n % 2 != 0);
//Console.WriteLine($"Number of odd numbers: {oddCount}");

#endregion

#region 2. Return a list of customers and how many orders each has.

//var customerOrders = ListGenerators.CustomerList
//    .Select(c => new { c.Name, OrderCount = c.Orders.Count(o => o != null) })
//    .ToList();
//Console.WriteLine("\nCustomers and their order counts:");
//customerOrders.ForEach(co => Console.WriteLine($"{co.Name}: {co.OrderCount} orders"));

#endregion

#region 3. Return a list of categories and how many products each has

//var categoryCounts = ListGenerators.ProductList
//    .GroupBy(p => p.Category)
//    .Select(g => new { Category = g.Key, ProductCount = g.Count() })
//    .ToList();
//Console.WriteLine("\nCategories and their product counts:");
//categoryCounts.ForEach(cc => Console.WriteLine($"{cc.Category}: {cc.ProductCount} products"));

#endregion

#region 4. Get the total of the numbers in an array.

//int[] arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
//var totalSum = arr.Sum();
//Console.WriteLine($"Total sum of numbers: {totalSum}");

#endregion

#region 5. Get the total number of characters of all words in dictionary_english.txt (Read dictionary_english.txt into Array of String First).

/*
Hello
Bad
Good
Fun
Where
Me
*/

//string[] words = File.ReadAllLines(@"dictionary_english.txt");
//var totalChars = words.Sum(w => w.Length);
//Console.WriteLine($"Total characters in dictionary: {totalChars}");

#endregion

#region 6. Get the total units in stock for each product category.

//var unitsInStockByCategory = ListGenerators.ProductList
//    .GroupBy(p => p.Category)
//    .Select(g => new { Category = g.Key, TotalUnits = g.Sum(p => p.UnitsInStock) })
//    .ToList();
//Console.WriteLine("Total units in stock by category:");
//unitsInStockByCategory.ForEach(u => Console.WriteLine($"{u.Category}: {u.TotalUnits} units"));

#endregion

#region 7. Get the length of the shortest word in dictionary_english.txt (Read dictionary_english.txt into Array of String First).

/*
Hello
Bad
Good
Fun
Where
Me
*/

//string[] words = File.ReadAllLines("dictionary_english.txt");
//var shortestWordLength = words.Min(w => w.Length);
//Console.WriteLine($"Shortest word length: {shortestWordLength}");

#endregion

#region 8. Get the cheapest price among each category's products

//var cheapestPriceByCategory = ListGenerators.ProductList
//    .GroupBy(p => p.Category)
//    .Select(g => new { Category = g.Key, CheapestPrice = g.Min(p => p.UnitPrice) })
//    .ToList();
//Console.WriteLine("Cheapest price by category:\n");
//cheapestPriceByCategory.ForEach(cp => Console.WriteLine($"{cp.Category}: {cp.CheapestPrice:C}"));

#endregion

#region 9. Get the products with the cheapest price in each category (Use Let)

//var cheapestProducts = from p in ListGenerators.ProductList
//                       group p by p.Category into g
//                       let minPrice = g.Min(p => p.UnitPrice)
//                       from p in g
//                       where p.UnitPrice == minPrice
//                       select new { p.Category, p.ProductName, p.UnitPrice };
//Console.WriteLine("Cheapest products by category:\n");
//cheapestProducts.ToList().ForEach(cp => Console.WriteLine($"{cp.Category}: {cp.ProductName} ({cp.UnitPrice:C})"));

#endregion

#region 10. Get the length of the longest word in dictionary_english.txt (Read dictionary_english.txt into Array of String First).

/*
Hello
Bad
Good
Fun
Where
Me
*/

//string[] words = File.ReadAllLines("dictionary_english.txt");
//var longestWordLength = words.Max(w => w.Length);
//Console.WriteLine($"Longest word length: {longestWordLength}");

#endregion

#region 11. Get the most expensive price among each category's products.

//var mostExpensivePriceByCategory = ListGenerators.ProductList
//    .GroupBy(p => p.Category)
//    .Select(g => new { Category = g.Key, MostExpensivePrice = g.Max(p => p.UnitPrice) })
//    .ToList();
//Console.WriteLine("Most expensive price by category:\n");
//mostExpensivePriceByCategory.ForEach(ep => Console.WriteLine($"{ep.Category}: {ep.MostExpensivePrice:C}"));

#endregion

#region 12. Get the products with the most expensive price in each category.

//var mostExpensiveProducts = ListGenerators.ProductList
//    .GroupBy(p => p.Category)
//    .SelectMany(g => g.Where(p => p.UnitPrice == g.Max(p2 => p2.UnitPrice)))
//    .Select(p => new { p.Category, p.ProductName, p.UnitPrice })
//    .ToList();
//Console.WriteLine("Most expensive products by category: \n");
//mostExpensiveProducts.ForEach(ep => Console.WriteLine($"{ep.Category}: {ep.ProductName} ({ep.UnitPrice:C})"));

#endregion

#region 13. Get the average length of the words in dictionary_english.txt (Read dictionary_english.txt into Array of String First).

/*
Hello
Bad
Good
Fun
Where
Me
*/

//string[] words = File.ReadAllLines("dictionary_english.txt");
//var averageWordLength = words.Average(w => w.Length);
//Console.WriteLine($"Average word length: {averageWordLength:F2}");

#endregion

#region 14. Get the average price of each category's products.

//var averagePriceByCategory = ListGenerators.ProductList
//    .GroupBy(p => p.Category)
//    .Select(g => new { Category = g.Key, AveragePrice = g.Average(p => p.UnitPrice) })
//    .ToList();
//Console.WriteLine("\nAverage price by category:");
//averagePriceByCategory.ForEach(ap => Console.WriteLine($"{ap.Category}: {ap.AveragePrice:C}"));

#endregion

#endregion

#region LINQ - Ordering Operators

#region 1. Sort a list of products by name

//var sortedProductsByName = ListGenerators.ProductList
//    .OrderBy(p => p.ProductName)
//    .ToList();
//Console.WriteLine("Products sorted by name: \n");
//sortedProductsByName.ForEach(Console.WriteLine);

#endregion

#region 2. Uses a custom comparer to do a case-insensitive sort of the words in an array.

//string[] Arr = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };
//var sortedWordsCaseInsensitive = Arr
//    .OrderBy(w => w, StringComparer.OrdinalIgnoreCase)
//    .ToArray();
//Console.WriteLine("Case-insensitive sorted words:\n");
//Console.WriteLine(string.Join(", ", sortedWordsCaseInsensitive));

#endregion

#region 3. Sort a list of products by units in stock from highest to lowest.

//var sortedProductsByStock = ListGenerators.ProductList
//    .OrderByDescending(p => p.UnitsInStock)
//    .ToList();
//Console.WriteLine("Products sorted by units in stock (highest to lowest): \n");
//sortedProductsByStock.ForEach(Console.WriteLine);

#endregion

#region 4. Sort a list of digits, first by length of their name, and then alphabetically by the name itself.

//string[] digits = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
//var sortedDigits = digits
//    .OrderBy(d => d.Length)
//    .ThenBy(d => d)
//    .ToArray();
//Console.WriteLine("Digits sorted by name length then alphabetically:");
//Console.WriteLine(string.Join(", ", sortedDigits));

#endregion

#region 5. Sort first by word length and then by a case-insensitive sort of the words in an array.

//string[] words = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };
//var sortedWordsByLengthThenCaseInsensitive = words
//    .OrderBy(w => w.Length)
//    .ThenBy(w => w, StringComparer.OrdinalIgnoreCase)
//    .ToArray();
//Console.WriteLine("Words sorted by length then case-insensitive:");
//Console.WriteLine(string.Join(", ", sortedWordsByLengthThenCaseInsensitive));

#endregion

#region 6. Sort a list of products, first by category, and then by unit price, from highest to lowest.

//var sortedProductsByCategoryAndPrice = ListGenerators.ProductList
//    .OrderBy(p => p.Category)
//    .ThenByDescending(p => p.UnitPrice)
//    .ToList();
//Console.WriteLine("Products sorted by category then unit price (highest to lowest):");
//sortedProductsByCategoryAndPrice.ForEach(Console.WriteLine);

#endregion

#region 7. Sort first by word length and then by a case-insensitive descending sort of the words in an array.

//string[] Arr = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };
//var sortedWordsByLengthThenCaseInsensitiveDesc = Arr
//    .OrderBy(w => w.Length)
//    .ThenByDescending(w => w, StringComparer.OrdinalIgnoreCase)
//    .ToArray();
//Console.WriteLine("\nWords sorted by length then case-insensitive descending:");
//Console.WriteLine(string.Join(", ", sortedWordsByLengthThenCaseInsensitiveDesc));

#endregion

#region 8. Create a list of all digits in the array whose second letter is 'i' that is reversed from the order in the original array.

//string[] Arr = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight","nine" };
//var digitsWithSecondLetterIReversed = Arr
//    .Where(d => d.Length > 1 && d[1] == 'i')
//    .Reverse()
//    .ToArray();
//Console.WriteLine("Digits with second letter 'i' in reverse order:");
//Console.WriteLine(string.Join(", ", digitsWithSecondLetterIReversed));

#endregion

#endregion

#region LINQ - Transformation Operators

#region 1. Return a sequence of just the names of a list of products.

//var productNames = ListGenerators.ProductList
//    .Select(p => p.ProductName)
//    .ToList();
//Console.WriteLine("Product names:\n");
//productNames.ForEach(Console.WriteLine);

#endregion

#region 2. Produce a sequence of the uppercase and lowercase versions of each word in the original array (Anonymous Types).

//string[] words = { "aPPLE", "BlUeBeRrY", "cHeRry" };
//var wordCases = words
//    .Select(w => new { Upper = w.ToUpper(), Lower = w.ToLower() })
//    .ToList();
//Console.WriteLine("Uppercase and lowercase versions of words:\n");
//wordCases.ForEach(w => Console.WriteLine($"Upper: {w.Upper}, Lower: {w.Lower}"));

#endregion

#region 3. Produce a sequence containing some properties of Products, including UnitPrice which is renamed to Price in the resulting type.

//var productProperties = ListGenerators.ProductList
//    .Select(p => new { p.ProductID, p.ProductName, Price = p.UnitPrice })
//    .ToList();
//Console.WriteLine("Selected product properties with UnitPrice renamed to Price:\n");
//productProperties.ForEach(p => Console.WriteLine($"ID: {p.ProductID}, Name: {p.ProductName}, Price: {p.Price:C}"));

#endregion

#region 4. Determine if the value of ints in an array match their position in the array.

//int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
//var numberPositions = Arr
//    .Select((n, index) => new { Number = n, InPlace = n == index })
//    .ToList();
//Console.WriteLine("\nNumber: In-place?");
//numberPositions.ForEach(np => Console.WriteLine($"{np.Number}: {np.InPlace}"));

#endregion

#region 5. Returns all pairs of numbers from both arrays such that the number from numbersA is less than the number from numbersB.

//int[] numbersA = { 0, 2, 4, 5, 6, 8, 9 };
//int[] numbersB = { 1, 3, 5, 7, 8 };
//var pairs = from a in numbersA
//            from b in numbersB
//            where a < b
//            select new { A = a, B = b };
//Console.WriteLine("Pairs where a < b:\n");
//pairs.ToList().ForEach(p => Console.WriteLine($"{p.A} is less than {p.B}"));

#endregion

#region 6. Select all orders where the order total is less than 500.00.

//var lowValueOrders = ListGenerators.CustomerList
//    .SelectMany(c => c.Orders)
//    .Where(o => o != null && o.Total < 500.00)
//    .ToList();
//Console.WriteLine("Orders with total less than 500.00:\n");
//lowValueOrders.ForEach(Console.WriteLine);

#endregion

#region 7. Select all orders where the order was made in 1998 or later.

//var recentOrders = ListGenerators.CustomerList
//    .SelectMany(c => c.Orders)
//    .Where(o => o != null && o.OrderDate.Year >= 1998)
//    .ToList();
//Console.WriteLine("Orders from 1998 or later:\n");
//recentOrders.ForEach(Console.WriteLine);

#endregion

#endregion

#region LINQ - Partitioning Operators

#region 1. Get the first 3 orders from customers in Washington

//var firstThreeOrdersWashington = ListGenerators.CustomerList
//    .Where(c => c.City.ToLower().Contains("Washington", StringComparison.OrdinalIgnoreCase)
//    || c.Country.ToLower().Contains("washington", StringComparison.OrdinalIgnoreCase))
//    .SelectMany(c => c.Orders)
//    .Where(o => o != null)
//    .Take(3)
//    .ToList();
//Console.WriteLine("First 3 orders from customers in Washington: \n");
//firstThreeOrdersWashington.ForEach(Console.WriteLine);
//if (!firstThreeOrdersWashington.Any())
//    Console.WriteLine("No orders found for customers in Washington!");

#endregion

#region 2. Get all but the first 2 orders from customers in Washington.

//var allButFirstTwoOrdersWashington = ListGenerators.CustomerList
//    .Where(c => c.City.ToLower().Contains("Washington", StringComparison.OrdinalIgnoreCase)
//    || c.Country.ToLower().Contains("washington", StringComparison.OrdinalIgnoreCase))
//    .SelectMany(c => c.Orders)
//    .Where(o => o != null)
//    .Skip(2)
//    .ToList();
//Console.WriteLine("All but the first 2 orders from customers in Washington:\n");
//allButFirstTwoOrdersWashington.ForEach(o => Console.WriteLine(o.ToString()));
//if (!allButFirstTwoOrdersWashington.Any())
//    Console.WriteLine("No orders found for customers in Washington after skipping the first 2!");

#endregion

#region 3. Return elements starting from the beginning of the array until a number is hit that is less than its position in the array.

//int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
//var takeUntilLessThanPosition = numbers
//    .TakeWhile((n, index) => n >= index)
//    .ToArray();
//Console.WriteLine("elements until a number is less than its position:");
//Console.WriteLine(string.Join(", ", takeUntilLessThanPosition));

#endregion

#region 4. Get the elements of the array starting from the first element divisible by 3.

//int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
//var takeFromDivisibleByThree = numbers
//    .SkipWhile(n => n % 3 != 0)
//    .ToArray();
//Console.WriteLine("Elements starting from the first number divisible by 3:");
//Console.WriteLine(string.Join(", ", takeFromDivisibleByThree));

#endregion

#region 5. Get the elements of the array starting from the first element less than its position.

//int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
//var takeFromLessThanPosition = numbers
//    .SkipWhile((n, index) => n >= index)
//    .ToArray();
//Console.WriteLine("Elements starting from the first number less than its position:");
//Console.WriteLine(string.Join(", ", takeFromLessThanPosition));

#endregion

#endregion

#region LINQ - Quantifiers

#region 1. Determine if any of the words in dictionary_english.txt (Read dictionary_english.txt into Array of String First) contain the substring 'ei'.

/*
Hello
Bad
Good
Fun
Where
Me
*/

//string[] words = File.ReadAllLines("dictionary_english.txt");
//var hasEi = words.Any(w => w.Contains("ei"));
//Console.WriteLine($"Any words contain 'ei': {hasEi}");

#endregion

#region 2. Return a grouped a list of products only for categories that have at least one product that is out of stock.

//var categoriesWithOutOfStock = ListGenerators.ProductList
//    .GroupBy(p => p.Category)
//    .Where(g => g.Any(p => p.UnitsInStock == 0))
//    .Select(g => new { Category = g.Key, Products = g.ToList() })
//    .ToList();
//Console.WriteLine("Categories with at least one out-of-stock product:");
//categoriesWithOutOfStock.ForEach(g =>
//{
//    Console.WriteLine($"\nCategory: {g.Category}");
//    g.Products.ForEach(p => Console.WriteLine(p.ToString()));
//});

#endregion

#region 3. Return a grouped a list of products only for categories that have all of their products in stock.

//var categoriesAllInStock = ListGenerators.ProductList
//    .GroupBy(p => p.Category)
//    .Where(g => g.All(p => p.UnitsInStock > 0))
//    .Select(g => new { Category = g.Key, Products = g.ToList() })
//    .ToList();
//Console.WriteLine("Categories with all products in stock:");
//categoriesAllInStock.ForEach(g =>
//{
//    Console.WriteLine($"\nCategory: {g.Category}");
//    g.Products.ForEach(p => Console.WriteLine(p.ToString()));
//});

#endregion

#endregion

Console.ReadKey();