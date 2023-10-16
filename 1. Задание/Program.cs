namespace _1._Задание
{
    using System;
    using System.Runtime.InteropServices;

    class Program
    {

        /// <summary>
        /// Пользователь вводит порядковый номер пальца руки. Необходимо показать его название на экран.
        /// </summary>
        static void Main()
        {
            try
            {
                
                // Здесь можно ввести порядковый номер пальца
                Print();
                int fingerNumber = int.Parse(Console.ReadLine());
                // Используем делегаты Action<T> и Func<T>
                Action<int> displayFingerName = PrintFingerName;
                displayFingerName(fingerNumber);

                Func<int, string> getFingerName = GetFingerName;
                string fingerName = getFingerName(fingerNumber);
                Console.WriteLine(fingerName);
                Console.ReadLine();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message.ToString());
                Console.ReadLine();
                Console.Clear();
                Main();
            }
        }

        /// <summary>
        /// Метод для отображения названия пальца
        /// </summary>
        /// <param name="fingerNumber"></param>
        static void PrintFingerName(int fingerNumber)
        {
            string fingerName = GetFingerName(fingerNumber);
            Console.WriteLine(fingerName);
        }

        /// <summary>
        /// Метод для получения названия пальца
        /// </summary>
        /// <param name="fingerNumber"></param>
        /// <returns></returns>
        static string GetFingerName(int fingerNumber)
        {
            switch (fingerNumber)
            {
                case 1:
                    return "Большой палец";
                case 2:
                    return "Указательный палец";
                case 3:
                    return "Средний палец";
                case 4:
                    return "Безымянный палец";
                case 5:
                    return "Мизинец";
                default:
                    return "Недопустимый номер пальца";
            }
        }
        
        static void Print()
        {
            Console.WriteLine("Введите номер пальца для использования руки ");
            Console.WriteLine("1 = Большой палец");
            Console.WriteLine("2 = Указательный палец");
            Console.WriteLine("3 = Средний палец");
            Console.WriteLine("4 = Безымянный палец");
            Console.WriteLine("5 = Мизинец");
        }

   
    }

}