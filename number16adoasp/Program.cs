using System;
using number16adoasp;
// Пример использования класса Matrix

// Создание двух матриц 2x2
 Matrix A = new Matrix(2, 2);
 A[0, 0] = 1; A[0, 1] = 2;
 A[1, 0] = 3; A[1, 1] = 4;

Matrix B = new Matrix(2, 2);
B[0, 0] = 5; B[0, 1] = 6;
 B[1, 0] = 7; B[1, 1] = 8;

// Сложение матриц
Matrix sum = A + B;
Console.WriteLine("Сумма матриц:");
sum.Print();

 // Умножение матриц
Matrix product = A * B;
Console.WriteLine("\nПроизведение матриц:");
product.Print();
    
