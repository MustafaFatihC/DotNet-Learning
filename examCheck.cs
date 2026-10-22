Console.Write("Please enter your exam point -> ");

int examPoint = Convert.ToInt32(Console.ReadLine());

if (examPoint >= 90 && examPoint <= 100)
{
    Console.WriteLine($"Your exam point is {examPoint}, so you passed the exam with AA");
}
else if (examPoint >= 80 && examPoint <= 89)
{
    Console.WriteLine($"Your exam point is {examPoint}, so you passed the exam with BA");
}
else if (examPoint >= 70 && examPoint <= 79)
{
    Console.WriteLine($"Your exam point is {examPoint}, so you passed the exam with BB");
}
else if (examPoint >= 60 && examPoint <= 69)
{
    Console.WriteLine($"Your exam point is {examPoint}, so you passed the exam with CB");
}
else if (examPoint >= 50 && examPoint <= 59)
{
    Console.WriteLine($"Your exam point is {examPoint}, so you passed the exam with CC");
}
else if (examPoint > 100 || examPoint < 0)
{
    Console.WriteLine($"Your exam point must be between 100 and 0 ,so your exam point can't be {examPoint} ");
}
else
{
    Console.WriteLine($"Your exam point is {examPoint}, so you passed the exam with FF");
}