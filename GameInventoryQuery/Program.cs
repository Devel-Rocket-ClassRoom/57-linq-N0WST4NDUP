using System;
using System.Collections.Generic;
using System.Linq;

List<GameItem> itemList = new()
{
    new("나무 검", "무기", "일반", 100, 3),
    new("강철 대검", "무기", "희귀", 800, 1),
    new("용의 검", "무기", "전설", 5000, 1),
    new("가죽 갑옷", "방어구", "일반", 200, 2),
    new("미스릴 갑옷", "방어구", "희귀", 1200, 1),
    new("드래곤 갑옷", "방어구", "전설", 8000, 0),
    new("체력 물약", "소비", "일반", 50, 10),
    new("마나 물약", "소비", "일반",80, 5),
    new("고급 물약", "소비", "희귀", 500, 0),
    new("엘릭서", "소비", "전설", 3000, 2),
};

Console.WriteLine("=== 쿼리 1: 가격 500 이상 (가격 내림차순) ===");
var 쿼리_1 = itemList.Where(e => e.Price >= 500).OrderByDescending(e => e.Price);
foreach (var item in 쿼리_1)
{
    Console.WriteLine($"{item.Name} - {item.Type} - {item.Price}원");
}
Console.WriteLine();

Console.WriteLine("=== 쿼리 2: 무기 타입 (등급순) ===");
var 쿼리_2 = itemList
                .Where(e => e.Type.Equals("무기"))
                .OrderBy(e => e.Grade.Equals("전설"))
                .ThenBy(e => e.Grade.Equals("희귀"))
                .ThenBy(e => e.Grade.Equals("일반"));
foreach (var item in 쿼리_2)
{
    Console.WriteLine($"{item.Name} - {item.Grade} - {item.Price}원");
}
Console.WriteLine();

Console.WriteLine("=== 쿼리 3: 총 가치 1000 이상 ===");
var 쿼리_3 = itemList
                .Where(e => e.Price * e.Quantity >= 1000)
                .Select(e => new { Name = e.Name, Price = e.Price * e.Quantity });
foreach (var item in 쿼리_3)
{
    Console.WriteLine($"{item.Name} - 총 가치: {item.Price}");
}
Console.WriteLine();

Console.WriteLine("=== 쿼리 4: 품절 아이템 (이름순) ===");
var 쿼리_4 = itemList
                .Where(e => e.Quantity == 0)
                .Select(e => e.Name);
foreach (var item in 쿼리_4)
{
    Console.WriteLine(item);
}
Console.WriteLine();

Console.WriteLine("=== 쿼리 5: 전설 등급 (이름과 가격) ===");
var 쿼리_5 = itemList
                .Where(e => e.Grade.Equals("전설"))
                .Select(e => new { Name = e.Name, Price = e.Price });
foreach (var item in 쿼리_5)
{
    Console.WriteLine($"{item.Name} - {item.Price}원");
}
Console.WriteLine();