
int[] studentsnote = new int[3];
string[] studentname = new string[3];
Console.Write("1.Enter name for student: ");
studentname[0] = Console.ReadLine();
Console.Write("1.Enter grade for student: ");
studentsnote[0] = Convert.ToInt32(Console.ReadLine());
Console.Write("2.Enter name for student: ");
studentname[1] = Console.ReadLine();
Console.Write("2.Enter grade for student: ");
studentsnote[1] = Convert.ToInt32(Console.ReadLine());
Console.Write("3.Enter name for student: ");
studentname[2] = Console.ReadLine();
Console.Write("3.Enter grade for student: ");
studentsnote[2] = Convert.ToInt32(Console.ReadLine());

var studentlength = studentname.Length;
Console.WriteLine("Students array length is : " + studentname.Length);


foreach (var studentn in studentname[..2])
{
    Console.WriteLine(studentn);
}

foreach (var studentp in studentsnote[..2])
{
    Console.WriteLine(studentp);
}

var studentsnotetotal = studentsnote[0] + studentsnote[1] + studentsnote[2];

Console.WriteLine("Students' grade point average: " + studentsnotetotal / studentlength);