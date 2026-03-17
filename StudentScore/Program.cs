using System;
using System.Collections.Generic;
using System.Linq;

List<Student> students = new()
{
    new("김철수", "수학", 85),
    new("김철수", "영어", 78),
    new("이영희", "수학", 92),
    new("이영희", "영어", 88),
    new("박민수", "수학", 76),
    new("박민수", "영어", 82),
    new("정지은", "수학", 95),
    new("정지은", "영어", 91),
};

Console.WriteLine("=== 문제 1: 85점 이상 ===");
var q1 = students
            .Where(e => e.Score >= 85);
foreach (var s in q1)
{
    Console.WriteLine(s);
}
Console.WriteLine();

Console.WriteLine("=== 문제 2: 수학 과목 ===");
var q2 = students
            .Where(e => e.Subject.Equals("수학"));
foreach (var s in q2)
{
    Console.WriteLine(s);
}
Console.WriteLine();

Console.WriteLine("=== 문제 3: 점수 내림차순 ===");
var q3 = students
            .OrderByDescending(e => e.Score);
foreach (var s in q3)
{
    Console.WriteLine(s);
}
Console.WriteLine();

Console.WriteLine("=== 문제 4: 전체 평균 ===");
var q4 = students
            .Select(e => e.Score)
            .Average();
Console.WriteLine($"{q4:f3}점");
Console.WriteLine();

Console.WriteLine("=== 문제 5: 수학 최고/최저 점수 ===");
var q5 = students
            .Where(e => e.Subject.Equals("수학"))
            .OrderByDescending(e => e.Score);
Console.WriteLine($"최고: {q5.First().Score}점\n최저: {q5.Last().Score}점");
Console.WriteLine();

Console.WriteLine("=== 문제 6: 영어 90점 이상 존재 여부 ===");
var q6 = students
            .Where(e => e.Subject.Equals("영어"))
            .Any(e => e.Score >= 90);
Console.WriteLine(q6);
Console.WriteLine();

Console.WriteLine("=== 문제 7: 모두 70점 이상 여부 ===");
var q7 = students
            .Any(e => e.Score >= 70);
Console.WriteLine(q7);
Console.WriteLine();

Console.WriteLine("=== 문제 8: 학생 이름 (중복 제거) ===");
var q8 = students
            .Select(e => e.Name)
            .Distinct();
foreach (var s in q8)
{
    Console.WriteLine(s);
}
Console.WriteLine();

Console.WriteLine("=== 문제 9: 수학 최고점 학생 ===");
var q9 = students
            .Where(e => e.Subject.Equals("수학"))
            .OrderByDescending(e => e.Score)
            .First();
Console.WriteLine(q9.Name);
Console.WriteLine();

Console.WriteLine("=== 문제 10: 과목별 정렬 ===");
var q10 = students
            .OrderByDescending(e => e.Subject)
            .ThenByDescending(e => e.Score);
foreach (var s in q10)
{
    Console.WriteLine(s);
}
Console.WriteLine();