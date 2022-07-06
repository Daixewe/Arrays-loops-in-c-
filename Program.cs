Console.WriteLine("Array loop");

const int size = 5;
int[] numbers = new int [size];

for (int i = 0;i < size; i++)
{
 Console.Write("Ingrese un número: ");
 string input = Console.ReadLine() ?? "0";
 numbers[i] = Int32.Parse(input);
}


 int total = 0;
 for (int i=0; i<size; i++)
 {
 total = total + numbers[i];

 }

 for (int i=0; i< size; i++)
 {

     Console.WriteLine(numbers[i]);

 }
 Console.WriteLine("Total: " + total);