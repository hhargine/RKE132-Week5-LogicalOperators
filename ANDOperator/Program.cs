//Math >= 90; Bilogy >=90, Chemistry >=90;

int math, biology, chemistry;

Console.WriteLine("Enter your Math result:");
math = Int32.Parse(Console.ReadLine());

Console.WriteLine("Enter your Bilogy result:");
biology = Int32.Parse(Console.ReadLine());

Console.WriteLine("Enter your Chemistry result:");
chemistry = Int32.Parse(Console.ReadLine());

if(math >= 90 && biology >= 90 && chemistry >= 90)
{
    Console.WriteLine("Congratulations! You are accepted.");

}
else
{
    Console.WriteLine("Your application cannot be approved.");
}

