string mes;
Console.WriteLine("Введите название предмета: ф, м, и, г, б");
string subject = Console.ReadLine();
switch (subject)
{case "ф": mes = "Физика"; break;
 case "м": mes = "Математика"; break;
 case "и": mes = "История"; break;
 case "г": mes = "География"; break;
 case "б": mes = "Биология"; break;
 default: mes = "Некорректная буква предмета"; break;
}
Console.WriteLine(mes);
Console.ReadKey();