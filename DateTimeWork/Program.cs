
void Task1()
{
  Console.WriteLine("Enter your birthday: ");

  DateTime dateBirthday = DateTime.Parse(Console.ReadLine());
  DateTime dateToday = DateTime.Now;
  DateTime date;
  date = new DateTime(dateToday.Year, dateBirthday.Month, dateBirthday.Day);

  if (date < dateToday)
  {
    date = date.AddYears(1);
  }

  TimeSpan countDays = date - dateToday;

  Console.WriteLine($"Count days: {countDays.TotalDays}");

  Console.ReadKey();

}

void Task2()
{
  Console.WriteLine("Enter date your birthday");
  
}