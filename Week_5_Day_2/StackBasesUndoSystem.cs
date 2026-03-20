using System;
using System.Collections.Generic;

namespace StackUndoSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter number of operations: ");
            int n = int.Parse(Console.ReadLine());

            string[] stack = new string[n]; // array-based stack
            int top = -1; // stack pointer

            for (int i = 0; i < n; i++)
            {
                Console.Write("\nEnter operation (Type X / Undo): ");
                string input = Console.ReadLine();

                // PUSH operation
                if (input.StartsWith("Type"))
                {
                    if (top < n - 1)
                    {
                        top++;
                        stack[top] = input;
                    }
                    else
                    {
                        Console.WriteLine("Stack Overflow!");
                    }
                }
                // POP operation (Undo)
                else if (input.Equals("Undo", StringComparison.OrdinalIgnoreCase))
                {
                    if (top >= 0)
                    {
                        top--; // remove last action
                    }
                    else
                    {
                        Console.WriteLine("Nothing to undo (Stack is empty)");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid operation");
                }

                // Display current state
                Console.Write("Current State: ");
                if (top == -1)
                {
                    Console.WriteLine("Empty");
                }
                else
                {
                    for (int j = 0; j <= top; j++)
                    {
                        Console.Write(stack[j] + " ");
                    }
                    Console.WriteLine();
                }
            }

            // Final state
            Console.WriteLine("\n--- Final State ---");
            if (top == -1)
            {
                Console.WriteLine("Empty");
            }
            else
            {
                for (int i = 0; i <= top; i++)
                {
                    Console.Write(stack[i] + " ");
                }
            }
        }
    }
}