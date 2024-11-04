using _20241104GYA;
using System.Text;

List<Versenyzo> versenyzok = [];

using StreamReader sr = 
    new("..\\..\\..\\src\\forras.txt", encoding: Encoding.UTF8);

while (!sr.EndOfStream) versenyzok.Add(new(sr.ReadLine()));

Console.WriteLine($"1. feladat: Versenyzők száma: {versenyzok.Count}");
var f1 = versenyzok.Count(p => p.Kategoria == "elit");
Console.WriteLine($"2. feladat: Veresenyzők száma (elit): {f1} darab");
var f2 = versenyzok.Where(v => !v.Nem).Average(v => 2014 - v.SzulEv);
Console.WriteLine($"3. feladat: Női versenyzők átlagéletkora: {f2:0.00} év");
var f3 = versenyzok.Sum(v => v.VersenyIdok["kerékpár"].TotalHours);
Console.WriteLine($"4. feladat: Kerékpározással töltött összidő: {f3:0.00} óra");
var f4 = versenyzok.Where(p=>p.Kategoria == "elit junior")
    .Average(p => p.VersenyIdok["úszás"].TotalMinutes);
Console.WriteLine($"5. feladat: Elit juniorok átlagos úszási ideje: {f4:0.00} perc");
var f5 = versenyzok.Where(p=> p.Nem).MinBy(v=>v.OsszIdoSec);
Console.WriteLine($"6.feladat: Férfi győztes: {f5}");

var f6 = versenyzok.GroupBy(p => p.Kategoria).OrderBy(p => p.Key);
Console.WriteLine("7. Versenyt befejzők száma (kategória, fő, átlag depó idő):");
foreach (var item in f6) Console.WriteLine($"{item.Key,11}: " +
    $"{item.Count(),2} fő   " +
    $"{item.Average(v => v.VersenyIdok["I. depó"].TotalMinutes +
    v.VersenyIdok["II. depó"].TotalMinutes):0.00} perc");

Console.WriteLine("\nCsopi 2-es feladatok:");
var f7 = versenyzok.Count(p => p.Kategoria == "elit junior");
Console.WriteLine($"1. feladat: Veresenyzők száma (elit junior): {f1} darab");
var f8 = versenyzok.Where(v => v.Nem).Average(v => 2014 - v.SzulEv);
Console.WriteLine($"2. feladat: Férfi versenyzők átlagéletkora: {f8:0.00} év");
var f9 = versenyzok.Sum(v => v.VersenyIdok["futás"].TotalHours);
Console.WriteLine($"3. feladat: Futással töltött összidő: {f9:0.00} óra");
var f10 = versenyzok.Where(p => p.Kategoria == "20-24")
    .Average(p => p.VersenyIdok["úszás"].TotalMinutes);
Console.WriteLine($"4. feladat: 20-24 kategóriában átlagos úszási" +
    $" idő: {f10:0.00} perc");
var f11 = versenyzok.Where(p => !p.Nem).MinBy(v => v.OsszIdoSec);
Console.WriteLine($"5.feladat: Női győztes: {f11}");
var f12 = versenyzok.GroupBy(p => p.Nem).OrderBy(p => p.Key);
Console.WriteLine("6. Versenyt befejzők száma (nem, fő):");
foreach (var item in f12) Console.WriteLine($"{(item.Key ? "Férfi" : "Nő"),11}: " +
    $"{item.Count(),2} fő");
Console.WriteLine("7. Korkategóriánként átlag idő (kategória, átlag depó idő):");
var f13 = versenyzok.GroupBy(p => p.Kategoria).OrderBy(p => p.Key);
foreach (var item in f13) Console.WriteLine($"{item.Key,11}: " +
    $"{item.Average(v => v.VersenyIdok["I. depó"].TotalMinutes +
    v.VersenyIdok["II. depó"].TotalMinutes):0.00} perc");

Console.WriteLine("\nCsopi 3-as feladatok:");
var f14 = versenyzok.Count(p => p.Kategoria == "25-29");
Console.WriteLine($"1. feladat: Veresenyzők száma (25-29): {f14} darab");
var f15 = versenyzok.Average(v => 2014 - v.SzulEv);
Console.WriteLine($"2. feladat: Versenyzők átlagéletkora: {f15:0.00} év");
var f16 = versenyzok.Sum(v => v.VersenyIdok["úszás"].TotalHours);
Console.WriteLine($"3. feladat: Úszással töltött összidő: {f16:0.00} óra");
var f17 = versenyzok.Where(p => p.Kategoria == "elit")
    .Average(p => p.VersenyIdok["úszás"].TotalMinutes);
Console.WriteLine($"4. feladat: Elit kategóriában átlagos úszási" +
    $" idő: {f17:0.00} perc");
var f18 = versenyzok.Where(p => p.Nem).MinBy(v => v.OsszIdoSec);
Console.WriteLine($"5.feladat: Férfi győztes: {f18}");
Console.WriteLine("7. Korkategóriánként átlag idő (kategória, fő, átlag depó idő):");
var f19 = versenyzok.GroupBy(p => p.Kategoria).OrderBy(p => p.Key);
foreach (var item in f19) Console.WriteLine($"{item.Key,11}: " +
    $"{item.Count(),2} fő   " +
    $"{item.Average(v => v.VersenyIdok["I. depó"].TotalMinutes +
    v.VersenyIdok["II. depó"].TotalMinutes):0.00} perc");