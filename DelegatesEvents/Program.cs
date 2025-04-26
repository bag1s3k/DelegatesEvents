namespace DelegatesEvents;

using System;

public class Program {
    public delegate int Operation(int i, int j);

    public static int Add(int i, int j) => i + j;
    public static int Multiply(int i, int j) => i * j;

    static void Main() {
        Operation op;

        op = Add;
        Console.WriteLine("Add: " + op(5, 3));

        op = Multiply;
        Console.WriteLine("Mul: " + op(15, 5));
    }
}