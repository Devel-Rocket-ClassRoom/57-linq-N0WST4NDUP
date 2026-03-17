using System;
using System.Collections.Generic;
using System.Linq;

// 1. Sum, Count, Average
// int[] numbers = { 1, 2, 3, 4, 5 };

// int sum = numbers.Sum();
// int count = numbers.Count();
// double average = numbers.Average();

// Console.WriteLine($"합계: {sum}");
// Console.WriteLine($"개수: {count}");
// Console.WriteLine($"평균: {average}");

// 2. Min, Max
// int[] numbers = { 3, 1, 4, 1, 5, 9, 2, 6 };

// int min = numbers.Min();
// int max = numbers.Max();

// Console.WriteLine($"최솟값: {min}");
// Console.WriteLine($"최댓값: {max}");

// 3. 조건부 집계
// int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

// int evenSum = numbers.Where(n => n % 2 == 0).Sum();

// int countOver5 = numbers.Count(n => n > 5);

// Console.WriteLine($"짝수 합계: {evenSum}");
// Console.WriteLine($"5보다 큰 숫자 개수: {countOver5}");

// 4. First, Last
// int[] numbers = { 10, 20, 30, 40, 50 };

// int first = numbers.First();
// int last = numbers.Last();

// Console.WriteLine($"첫 번째: {first}");
// Console.WriteLine($"마지막: {last}");

// 5. 조건부 요소 선택
// int[] numbers = { 1, 2, 3, 4, 5 };

// int firstOver3 = numbers.First(n => n > 3);

// Console.WriteLine($"3보다 큰 첫 번째: {firstOver3}");

// 6. Take, Skip
// int[] numbers = { 10, 20, 30, 40, 50 };

// var firstThree = numbers.Take(3);

// var skipTwo = numbers.Skip(2);

// Console.WriteLine("처음 3개:");
// foreach (var n in firstThree)
// {
//     Console.Write(n + " ");
// }

// Console.WriteLine("\n2개 건너뛴 후:");
// foreach (var n in skipTwo)
// {
//     Console.Write(n + " ");
// }

// 7. Any, All
// int[] numbers = { 1, 2, 3, 4, 5 };

// // 요소가 하나라도 있는지
// bool hasAny = numbers.Any();

// // 짝수가 하나라도 있는지
// bool hasEven = numbers.Any(n => n % 2 == 0);

// // 모든 요소가 양수인지
// bool allPositive = numbers.All(n => n > 0);

// Console.WriteLine($"요소 존재: {hasAny}");
// Console.WriteLine($"짝수 존재: {hasEven}");
// Console.WriteLine($"모두 양수: {allPositive}");

// 8. Contains
// int[] numbers = { 1, 2, 3, 4, 5 };

// bool has3 = numbers.Contains(3);
// bool has10 = numbers.Contains(10);

// Console.WriteLine($"3 포함: {has3}");
// Console.WriteLine($"10 포함: {has10}");

// 9. Distinct
// int[] numbers = { 1, 2, 2, 3, 3, 3, 4, 5 };

// var distinct = numbers.Distinct();

// foreach (var n in distinct)
// {
//     Console.Write(n + " ");
// }

// 10. Concat, Union
// int[] first = { 1, 2, 3 };
// int[] second = { 3, 4, 5 };

// // 단순 연결 (중복 포함)
// var concat = first.Concat(second);

// // 합집합 (중복 제거)
// var union = first.Union(second);

// Console.WriteLine("Concat:");
// foreach (var n in concat)
// {
//     Console.Write(n + " ");
// }

// Console.WriteLine("\nUnion:");
// foreach (var n in union)
// {
//     Console.Write(n + " ");
// }

// 11. 지연 실행
// var numbers = new List<int> { 1, 2, 3 };

// // 쿼리 생성 (아직 실행 안 됨)
// var query = numbers.Where(n => n > 1);

// // 새 요소 추가
// numbers.Add(4);

// // 쿼리 실행 (foreach에서 실행됨)
// Console.WriteLine("결과:");
// foreach (var n in query)
// {
//     Console.WriteLine(n);
// }

// 12. 즉시 실행 연산자
// var numbers = new List<int> { 1, 2, 3 };

// int count = numbers.Count();

// numbers.Add(4);

// Console.WriteLine($"개수: {count}"); 

// 13. ToList로 결과 고정
// var numbers = new List<int> { 1, 2, 3 };

// var result = numbers.Where(n => n > 1).ToList();

// numbers.Add(4);

// Console.WriteLine("결과:");
// foreach (var n in result)
// {
//     Console.WriteLine(n);
// }

// 14. Select로 새 타입 생성
// var names = new List<string> { "홍길동", "김철수", "이영희" };

// var result = names.Select(n => new { Name = n, Length = n.Length });

// foreach (var item in result)
// {
//     Console.WriteLine($"이름: {item.Name}, 길이: {item.Length}");
// }

// 15. 혼합 구문
// string[] names = { "Tom", "Dick", "Harry", "Mary", "Jay" };

// int count = (from n in names
//              where n.Contains("a")
//              select n).Count();

// Console.WriteLine($"'a' 포함 이름 개수: {count}");

// string first = (from n in names
//                 orderby n
//                 select n).First();

// Console.WriteLine($"알파벳 순 첫 번째: {first}");