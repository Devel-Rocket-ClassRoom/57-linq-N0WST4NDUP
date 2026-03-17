using System;
using System.Collections.Generic;
using System.Linq;

List<Product> products = new()
{
    new("Laptop", "Electronics", 1200),
    new("Mouse", "Electronics", 25),
    new("Keyboard", "Electronics", 75),
    new("Shirt", "Clothing", 50),
    new("Pants", "Clothing", 100),
    new("Desk", "Furniture", 250),
    new("Chair", "Furniture", 150),
    new("Monitor", "Electronics", 300),
};

Console.WriteLine("=== 문제 1: 가격 100 이상 ===");
var q1 = products
            .Where(e => e.Price >= 100);
foreach (var item in q1)
{
    Console.WriteLine($"{item.Name}");
}
Console.WriteLine();

Console.WriteLine("=== 문제 2: Electronics 카테고리 ===");
var q2 = products
            .Where(e => e.Category.Equals("Electronics"));
foreach (var item in q2)
{
    Console.WriteLine($"{item.Name} - {item.Category} - {item.Price}원");
}
Console.WriteLine();

Console.WriteLine("=== 문제 3: 이름순 정렬 ===");
var q3 = products
            .OrderBy(e => e.Name);
foreach (var item in q3)
{
    Console.WriteLine($"{item.Name}");
}
Console.WriteLine();

Console.WriteLine("=== 문제 4: 평균 가격 ===");
var q4 = products
            .Select(e => e.Price)
            .Average();
Console.WriteLine($"{q4:f2}원");
Console.WriteLine();

Console.WriteLine("=== 문제 5: 가장 저렴한 상품 ===");
var q5 = products
            .OrderBy(e => e.Price)
            .First();
Console.WriteLine($"{q5.Name} - {q5.Price}원");
Console.WriteLine();

Console.WriteLine("=== 문제 6: 가장 비싼 상품 ===");
var q6 = products
            .OrderByDescending(e => e.Price)
            .First();
Console.WriteLine($"{q6.Name} - {q6.Price}원");
Console.WriteLine();

Console.WriteLine("=== 문제 7: Electronics 평균 가격 ===");
var q7 = products
            .Where(e => e.Category.Equals("Electronics"))
            .Select(e => e.Price)
            .Average();
Console.WriteLine($"{q7:f2}원");
Console.WriteLine();

Console.WriteLine("=== 문제 8: 'o' 포함 상품 (대문자) ===");
var q8 = products
            .Select(e => e.Name.ToUpper())
            .Where(e => e.Contains('O'));
foreach (var item in q8)
{
    Console.WriteLine($"{item}");
}
Console.WriteLine();

Console.WriteLine("=== 문제 9: Clothing 역순 ===");
var q9 = products
            .Where(e => e.Category.Equals("Clothing"))
            .OrderByDescending(e => e.Name);
foreach (var item in q9)
{
    Console.WriteLine($"{item.Name}");
}
Console.WriteLine();

Console.WriteLine("=== 문제 10: 가격 50~300, 복합 정렬 ===");
var q10 = products
            .Where(e => 50 <= e.Price && e.Price <= 300)
            .OrderBy(e => e.Price)
            .ThenBy(e => e.Name);
foreach (var item in q10)
{
    Console.WriteLine($"{item.Name} - {item.Price}원");
}
Console.WriteLine();