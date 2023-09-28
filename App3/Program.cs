using System;

namespace App3
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            int taskNumber;
            do
            {
                Console.WriteLine("\n\nВведите номер задания от 1 до 5. \nВведите 0 для запуска всех заданий последовательно. \nВведите 12345 чтобы закрыть программу.\n");
                if (int.TryParse(Console.ReadLine(), out taskNumber))
                {
                    switch (taskNumber)
                    {
                        case 0:
                            Console.WriteLine("----------First task №930----------");
                            FirstTask930();
                            Console.WriteLine("----------Second task №937----------");
                            SecondTask937();
                            Console.WriteLine("----------Third task №956----------");
                            ThirdTask956();
                            Console.WriteLine("----------Fourth task №993----------");
                            FourthTask993();
                            Console.WriteLine("----------Fifth task №937----------");
                            FifthTask937();
                            break;
                        case 1:
                            Console.WriteLine("----------First task №930----------");
                            FirstTask930();
                            break;
                        case 2:
                            Console.WriteLine("----------Second task №937----------");
                            SecondTask937();
                            break;
                        case 3:
                            Console.WriteLine("----------Third task №956----------");
                            ThirdTask956();
                            break;
                        case 4:
                            Console.WriteLine("----------Fourth task №993----------");
                            FourthTask993();
                            break;
                        case 5:
                            Console.WriteLine("----------Fifth task №937----------");
                            FifthTask937();
                            break;
                    }
                }
            } while (taskNumber != 12345);
        }

        
        /// <summary>
        /// В двумерном массиве вещественных чисел заменить все элементы,
        /// меньше суммы элементов первой строки, этой суммы.
        /// </summary>
        static void FirstTask930()
        {
            Console.WriteLine("Task 1\nВведите количество строк: ");
            int.TryParse(Console.ReadLine(), out int numRow);
            Console.WriteLine("Task 1\nВведите количество столбцов: ");
            int.TryParse(Console.ReadLine(), out int numColumns);
            double[,] twoDimensionalArray = new double [numRow, numColumns];
            
            Console.Write("Полученый двумерный массив: \n(значения рандомные)\n");
            Random random = new Random();
            for (int i = 0; i < numRow; i++) {
                for (int j = 0; j < numColumns; j++)
                {
                    twoDimensionalArray[i, j] = Math.Round(random.NextDouble() * (99 - 1) + 1, 1);
                    Console.Write(twoDimensionalArray[i,j] + "  ");
                }
                Console.WriteLine();
            }
            
            // складываем элементы первой строки, сравниваем и заменяем те, которые меньше суммы первой строки;
            
            double sumFirstLine = 0.0;
            int amountElements = twoDimensionalArray.GetLength( 1);
            
            Console.Write("Сумма элементов первой строки = ");
            for (int j = 0; j < amountElements; j++)
            {
                sumFirstLine += twoDimensionalArray[0, j];
                // для красивого вывода в консоль;
                if (j == amountElements -1 )
                {
                    Console.Write(twoDimensionalArray[0, j]);
                }
                else
                {
                    Console.Write(twoDimensionalArray[0, j] + " + ");
                }
            }
            Console.Write($" = {sumFirstLine}\n");
            
            Console.WriteLine("Полученный двумерный массив: ");
            for (int i = 0; i < twoDimensionalArray.GetLength(0); i++)
            {
                for (int j = 0; j < amountElements; j++)
                {
                    if (twoDimensionalArray[i, j] < sumFirstLine)
                    {
                        twoDimensionalArray[i, j] = sumFirstLine;
                    }
                    Console.Write(twoDimensionalArray[i,j] + "  ");
                }
                Console.WriteLine();
            }
        }
        

        /// <summary>
        /// Вывести на экран (в одну строку) все элементы побочной диагонали массива:
        /// а) начиная с элемента, расположенного в правом верхнем углу;
        /// b) начиная с элемента, расположенного в левом нижнем углу;  
        /// </summary>
        static void SecondTask937()
        {
            Console.WriteLine("Task 2\n 1 -> a) начиная с элемента, расположенного в правом верхнем углу;\n 2 -> b) начиная с элемента, расположенного в левом нижнем углу;");
            int.TryParse(Console.ReadLine(), out int choice);
            
            if (choice == 1)
            {
                Console.WriteLine("Вы выбрали a)\nВведите количество строк и столбцов (одним числом): ");
                int.TryParse(Console.ReadLine(), out int sizeRowAndColumns);
            
                int[,] twoDimensionalArray = new int [sizeRowAndColumns, sizeRowAndColumns];
                
                Console.Write("Полученый двумерный массив: \n(значения рандомные)\n");
                Random random = new Random();
                for (int i = 0; i < sizeRowAndColumns; i++) {
                    for (int j = 0; j < sizeRowAndColumns; j++)
                    {
                        twoDimensionalArray[i, j] = random.Next(1, 99);
                        Console.Write(twoDimensionalArray[i,j] + "  ");
                    }
                    Console.WriteLine();
                }
                
                Console.Write("\nЭлементы побочной диагонали (по заданию (а)): ");
                for (int i = 0; i < sizeRowAndColumns; i++)
                {
                    for (int j = 0; j < sizeRowAndColumns; j++)
                    {
                        // Элементы побочной диагонали имеют координаты (i, RowAndColumns - 1 - i)
                        if (i + j == sizeRowAndColumns - 1)
                        {
                            Console.Write(twoDimensionalArray[i, j] + ",  ");
                        }
                    }
                }
                Console.WriteLine("\n");
            }

            if (choice == 2)
            {
                Console.WriteLine("Вы выбрали b)\nВведите количество строк и столбцов (одним числом): ");
                int.TryParse(Console.ReadLine(), out int sizeRowAndColumns);
            
                int[,] twoDimensionalArray = new int [sizeRowAndColumns, sizeRowAndColumns];
            
                Console.Write("Полученый двумерный массив: \n(значения рандомные)\n");
                Random random = new Random();
                for (int i = 0; i < sizeRowAndColumns; i++) {
                    for (int j = 0; j < sizeRowAndColumns; j++)
                    {
                        twoDimensionalArray[i, j] = random.Next(1, 99);
                        Console.Write(twoDimensionalArray[i,j] + "  ");
                    }
                    Console.WriteLine();
                }
            
                Console.Write("\nЭлементы побочной диагонали (по заданию (b)): ");
                for (int i = sizeRowAndColumns - 1; i >= 0; i--)
                {
                    for (int j = 0; j < sizeRowAndColumns; j++)
                    {
                        if (i + j == sizeRowAndColumns - 1)
                        {
                            Console.Write(twoDimensionalArray[i, j] + " ");
                        }
                    }
                }
                Console.WriteLine("\n");
            } 
            if (choice != 1 && choice != 2)
            {
                Console.WriteLine("Некоректное число, нужно ввести 1 или 2, все просто.");
            }
        }


        /// <summary>
        /// Дан двумерный массив. Определить сумму всех элементов:
        /// а) третьей строки массива;
        /// б) s-го столбца массива;
        /// в) второго столбца массива;
        /// г) k-й строки массива;
        /// </summary>
        static void ThirdTask956()
        {
            Console.WriteLine("Task 3\nВведите количество строк и столбцов (одним числом):");
            int.TryParse(Console.ReadLine(), out int sizeRowAndColumns);
            int[,] array = new int[sizeRowAndColumns, sizeRowAndColumns];
            int sumAnswer = 0;  //для ответов сложений;
            Console.WriteLine("Двумерный массив: ");
            Random random = new Random();
            for (int i = 0; i < sizeRowAndColumns; i++)
            {
                for (int j = 0; j < sizeRowAndColumns; j++)
                {
                    array[i,j] = random.Next(1, 99);
                    Console.Write(array[i,j] + "  ");
                }
                Console.WriteLine();
            }
            
            
            Console.WriteLine("\nа) Сумма всех элементов третьей строки массива: ");
            for (int j = 0; j < sizeRowAndColumns; j++)
            {
                // для красивого вывода в консоль процесса сумирования;
                if (j == sizeRowAndColumns -1)
                {
                    Console.Write(array[2, j]);
                }
                else
                {
                    Console.Write(array[2, j] + " + ");
                }
                sumAnswer += array[2, j];
            }
            Console.WriteLine(" = " + sumAnswer);
            
            
            Console.WriteLine("\nб) Сумма всех элементов s-го столбца массива.\nВведите S (номер столбца): ");
            int.TryParse(Console.ReadLine(), out int numberSColumn);
            // проверка, чтобы такой столбец был в массиве;
            if (numberSColumn > sizeRowAndColumns)
            {
                Console.WriteLine("Такого столбца нет в массиве. В массиве всего " + sizeRowAndColumns + " столбцов.");
            }
            else
            {
                Console.Write("Ответ: ");
                for (int i = 0; i < sizeRowAndColumns; i++)
                {
                    // для красивого вывода в консоль процесса сумирования;
                    if (i == sizeRowAndColumns -1)
                    {
                        Console.Write(array[i, numberSColumn -1]);
                    }
                    else
                    {
                        Console.Write(array[i, numberSColumn -1] + " + ");
                    }
                    sumAnswer += array[i, numberSColumn -1];
                }
                Console.WriteLine(" = " + sumAnswer);
            }
            
            
            Console.WriteLine("\nв) Сумма всех элементов второго столбца массива: ");
           
            for (int i = 0; i < sizeRowAndColumns; i++)
            {
                // для красивого вывода в консоль процесса сумирования;
                if (i == sizeRowAndColumns -1)
                {
                    Console.Write(array[i, 1]);
                }
                else
                {
                    Console.Write(array[i, 1] + " + ");
                }
                sumAnswer += array[i, 1];
            }
            Console.WriteLine(" = " + sumAnswer);
            
            
            Console.WriteLine("\nг) Сумма всех элементов k-й строки массива.\nВведите k (номер строки): ");
            int.TryParse(Console.ReadLine(), out int numberKRow);
            // проверка, чтобы такой столбец был в массиве;
            if (numberKRow > sizeRowAndColumns)
            {
                Console.WriteLine("Такой строки нет в массиве. В массиве всего " + sizeRowAndColumns + " строк.");
            }
            else
            {
                Console.Write("Ответ: ");
                for (int j = 0; j < sizeRowAndColumns; j++)
                {
                    // для красивого вывода в консоль процесса сумирования;
                    if (j == sizeRowAndColumns -1)
                    {
                        Console.Write(array[numberKRow -1, j]);
                    }
                    else
                    {
                        Console.Write(array[numberKRow -1, j] + " + ");
                    }
                    sumAnswer += array[numberKRow -1, j];
                }
                Console.WriteLine(" = " + sumAnswer);
            }
        }

        
        /// <summary>
        /// Дана целочисленная квадратная матрица.
        /// Найти в каждой строке наибольший элемент и поменять его местами с элементом главной диагонали.
        /// </summary>
        static void FourthTask993()
        {
            Console.WriteLine("Task 4\nВведите количество строк и столбцов (одним числом):");
            int.TryParse(Console.ReadLine(), out int sizeRowAndColumns);
            int[,] arrayTask4 = new int[sizeRowAndColumns, sizeRowAndColumns];
            
            Console.WriteLine("Созданный массив: ");
            Random random = new Random();
            for (int i = 0; i < sizeRowAndColumns; i++)
            {
                for (int j = 0; j < sizeRowAndColumns; j++)
                {
                    arrayTask4[i, j] = random.Next(1, 99);
                    Console.Write(arrayTask4[i, j] + " ");
                }
                Console.WriteLine();
            }

            Console.WriteLine("\nВ каждой строке был найден наибольший элемент и поменян местами с элементом главной диагонали.");
            for (int i = 0; i < sizeRowAndColumns; i++)
            {
               
                int maxRowValue = arrayTask4[i, i];
                 int indexMaxElementRow = i;
                for (int j = 1; j < sizeRowAndColumns; j++)
                {
                    if (arrayTask4[i, j] > arrayTask4[i, 0])
                    {
                        indexMaxElementRow = j;
                        maxRowValue = arrayTask4[i, j];
                    }
                }

                // Смена максимального элемента с элементом из главной диагонали;
                int mainDiagonalElement = arrayTask4[i, i];
                arrayTask4[i, i] = maxRowValue;
                arrayTask4[i, indexMaxElementRow] = mainDiagonalElement;
            }
            
            Console.WriteLine("Полученный массив:");
            for (int i = 0; i < sizeRowAndColumns; i++)
            {
                for (int j = 0; j < sizeRowAndColumns; j++)
                {
                    Console.Write(arrayTask4[i, j] + " ");
                }
                Console.WriteLine();
            }
        }


        /// <summary>
        ///  Вывести на экран (в одну строку) все элементы побочной диагонали массива:
        /// а) начиная с элемента, расположенного в правом верхнем углу;
        /// б) начиная с элемента, расположенного в левом нижнем углу.
        /// </summary>
        static void FifthTask937()
        {
            Console.WriteLine("Task 5\nЗадание 5 -- повторное, и было выполнено в задании 2.\nВведите 2 чтобы выполнить программу.");
        }
    }
}