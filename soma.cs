using System;

class MainClass {
  public static void Main (string[] args) {
      Double soma=0;
      Double num1=0;
      Double num2=0;
      Console.WriteLine("Programa que calcula a soma entre 2 números");
      Console.Write("Primeiro número: ");
      num1 = Convert.ToDouble(Console.ReadLine());
      Console.Write("Segundo número: ");
      num2 = Convert.ToDouble(Console.ReadLine());
      soma= num1 + num2;
      Console.WriteLine("Soma= " + soma);
      Console.ReadKey();
  }
}