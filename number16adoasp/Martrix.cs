using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace number16adoasp
{
    // Класс, представляющий двумерную матрицу
    public class Matrix
    {
        // Приватное поле для хранения данных матрицы
        private readonly double[,] _data;

        // Свойство для получения количества строк матрицы
        public int Rows => _data.GetLength(0);

        // Свойство для получения количества столбцов матрицы
        public int Columns => _data.GetLength(1);

        // Конструктор для создания матрицы заданных размеров
        public Matrix(int rows, int columns)
        {
            _data = new double[rows, columns];
        }

        // Индексатор для доступа к элементам матрицы
        public double this[int row, int column]
        {
            get => _data[row, column];
            set => _data[row, column] = value;
        }

        // Метод для печати матрицы на консоль
        public void Print()
        {
            for (int i = 0; i < Rows; i++)
            {
                for (int j = 0; j < Columns; j++)
                {
                    Console.Write($"{_data[i, j]:F2}\t");
                }
                Console.WriteLine();
            }
        }

        // Статический метод для сложения двух матриц
        public static Matrix Add(Matrix a, Matrix b)
        {
            if (a.Rows != b.Rows || a.Columns != b.Columns)
            {
                throw new ArgumentException("Размеры матриц должны совпадать!");
            }

            var result = new Matrix(a.Rows, a.Columns);
            for (int i = 0; i < a.Rows; i++)
            {
                for (int j = 0; j < a.Columns; j++)
                {
                    result[i, j] = a[i, j] + b[i, j];
                }
            }
            return result;
        }

        // Перегрузка оператора + для сложения матриц
        public static Matrix operator +(Matrix a, Matrix b)
        {
            return Add(a, b);
        }

        // Статический метод для умножения двух матриц
        public static Matrix Multiply(Matrix a, Matrix b)
        {
            if (a.Columns != b.Rows)
            {
                throw new ArgumentException("Количество столбцов первой матрицы должно равняться количеству строк второй матрицы!");
            }

            var result = new Matrix(a.Rows, b.Columns);
            for (int i = 0; i < a.Rows; i++)
            {
                for (int j = 0; j < b.Columns; j++)
                {
                    for (int k = 0; k < a.Columns; k++)
                    {
                        result[i, j] += a[i, k] * b[k, j];
                    }
                }
            }
            return result;
        }

        // Перегрузка оператора * для умножения матриц
        public static Matrix operator *(Matrix a, Matrix b)
        {
            return Multiply(a, b);
        }
    }
}
