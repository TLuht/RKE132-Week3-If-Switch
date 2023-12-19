//võtab kuupäeva väärtuse
int weekDay = Convert.ToInt32(DateTime.Now.DayOfWeek);

//võrdleb saadud väärtust, et saada kuupäev
switch (weekDay)
{
    case 0:
        Console.WriteLine("It's Sunday!");
        break;
    case 1:
        Console.WriteLine("It's Monday!");
        break;
    case 2:
        Console.WriteLine("Its's Tuesday!");
        break;
    case 3:
        Console.WriteLine("It's Wednesday!");
        break;
    case 4:
        Console.WriteLine("It's Thursday!");
        break;
    case 5:
        Console.WriteLine("It's Friday!");
        break;
    case 6:
        Console.WriteLine("It's Saturday");
        break;
    default:
        Console.WriteLine("Invalid date");
        break;
}