
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
  DateTime dateBirthday = DateTime.Parse(Console.ReadLine());
  DateTime today = DateTime.Now;
  TimeSpan daysCount = today - dateBirthday;
  Console.WriteLine($"Count days: {Math.Truncate(daysCount.TotalDays)} Count months: {Math.Truncate(daysCount.TotalDays/30)} Count years: {Math.Truncate(daysCount.TotalDays/365)} ");
}

void Task3()
{
  
}