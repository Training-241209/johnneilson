// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");


int number=20;
int count=1;

while (count <= number){
    string res = "";
    if (count%3==0) res+="Fizz";
    if (count%5==0) res+="Buzz";
    if (res.Equals("")){
        Console.WriteLine(count);
        count++;
        continue;
    }
    Console.WriteLine(res);
    count++;

}

