Console.WriteLine("Введите число элементов массива");
int size = Convert.ToInt32(Console.ReadLine());
string[] array = new string[size];
string[] help_array = new string[size];
int j=0;
void Fillarray(string [] array){
    Console.WriteLine("Заполните массив");
    for (int i=0; i < array.Length; i++){
        array[i]= Convert.ToString(Console.ReadLine());
    }
}
void Printarray(string [] array){
    Console.Write("[ ");
    for (int i=0; i < array.Length; i++){
        Console.Write($"{array[i]} ");
    }
    Console.Write("]");
    Console.WriteLine();
}

Fillarray(array);
Printarray(array);


for (int i=0; i < array.Length; i++){
    if (array[i].Length<4) {
        help_array[j]=array[i];
        j++;
    }
}
string[] result = new string[j];
for (int i=0; i < result.Length; i++){
    result[i]=help_array[i];
}
Console.WriteLine("Итоговый массив");
Printarray(result);