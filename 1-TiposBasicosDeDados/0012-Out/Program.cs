using _0012_Out;
/*int result = Calculator.Sum(10, 20, 30, 40);

Console.WriteLine(result);  

    int a = 10;
    Calculator.Triple(ref a);
    Console.WriteLine(a); */

int a = 10;
int triple;
Calculator.Triple(a, out triple);
Console.WriteLine(triple);
