// Задача №38

int n = 20;
int [] mass  = new int[n];      
Random rnd = new Random();      
for (int i = 0; i < n; i++)
    { mass[i] = rnd.Next(-10, 11);  
    Console.Write($" {mass[i]} ");
}
int min = 0;
int max = 0;
foreach (int i in mass)  
{
    if (min > i) min = i;
    if (max < i) max = i;
}
Console.WriteLine($" Cумма  максимального и минимального элемента равна: {max+min}");
