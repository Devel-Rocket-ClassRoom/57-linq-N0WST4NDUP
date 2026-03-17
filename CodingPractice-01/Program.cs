using System;
using System.Collections.Generic;
using System.Linq;

// 1. 메서드 구문 기본 사용법
// int[] numbers = { 1, 2, 3, 4, 5 };

// IEnumerable<int> result = numbers.Where(n => n > 3);

// foreach (int n in result)
// {
//     Console.WriteLine(n);
// }

// 2. Where - 필터링
// string[] names = { "Tom", "Dick", "Harry", "Mary", "Jay" };

// var filtered = names.Where(n => n.Contains("a"));

// foreach (var name in filtered)
// {
//     Console.WriteLine(name);
// }

// 3. Select - 변환
// string[] names = { "Tom", "Dick", "Harry" };

// var uppercased = names.Select(n => n.ToUpper());

// foreach (var name in uppercased)
// {
//     Console.WriteLine(name);
// }

// 4. OrderBy - 오름차순 정렬
// string[] colors = { "Red", "Green", "Blue" };

// var sorted = colors.OrderBy(c => c);

// foreach (var color in sorted)
// {
//     Console.WriteLine(color);
// }

// 5. OrderByDescending - 내림차순 정렬
// int[] numbers = { 3, 1, 4, 1, 5, 9, 2, 6 };

// var descending = numbers.OrderByDescending(n => n);

// foreach (var n in descending)
// {
//     Console.Write(n + " ");
// }

// 6. 쿼리 연산자 체이닝
// string[] names = { "Tom", "Dick", "Harry", "Mary", "Jay" };

// var query = names
//     .Where(n => n.Contains("a"))
//     .OrderBy(n => n.Length)
//     .Select(n => n.ToUpper());

// foreach (var name in query)
// {
//     Console.WriteLine(name);
// }

// 7. 쿼리 구문 기본 구조
// int[] numbers = { 1, 2, 3, 4, 5 };

// var query = from n in numbers
//             where n % 2 == 0
//             select n;

// foreach (var n in query)
// {
//     Console.WriteLine(n);
// }

// 8. 쿼리 구문 필터링과 정렬
// string[] names = { "Tom", "Dick", "Harry", "Mary", "Jay" };

// var query = from n in names
//             where n.Contains("a")
//             orderby n.Length
//             select n.ToUpper();

// foreach (var name in query)
// {
//     Console.WriteLine(name);
// }

// 9. 메서드 구문과 쿼리 구문 비교
// int[] numbers = { 3, 2, 1, 4, 5 };

// var methodResult = numbers
//     .Where(n => n % 2 == 1)
//     .OrderBy(n => n);

// var queryResult = from n in numbers
//                   where n % 2 == 1
//                   orderby n
//                   select n;

// Console.WriteLine("메서드 구문:");
// foreach (var n in methodResult)
// {
//     Console.Write(n + " ");
// }

// Console.WriteLine("\n쿼리 구문:");
// foreach (var n in queryResult)
// {
//     Console.Write(n + " ");
// }