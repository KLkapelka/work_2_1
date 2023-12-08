// Создайте коллекцию(массив) размерностью 100.
// Добавьте в коллекцию числа в убывающем порядке, каждое число меньше предыдущего на 3;

using System;
class work_2_1
{
    static void Main()
    {
        int[] array = new int[100]; 
        int number = 300; 
        
        for(int i = 0; i < 100; i++)
        {
            array[i] = number; 
            number -= 3; 
        }
        var str = string.Join(" ", array); 
        Console.WriteLine(str); 
    }
}
