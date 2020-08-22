using System;

class MainClass {
  public static void Main (string[] args) {
      Double media=0;
      Double nota1=0;
      Double nota2=0;
      Double nota3=0;
      Double nota4=0;
      Console.WriteLine("Programa que calcula a média bimestral");
      Console.Write("Informe a nota do 1° bimestre : ");
      nota1 = Convert.ToDouble(Console.ReadLine());
      Console.Write("Informe a nota do 2° bimestre : ");
      nota2 = Convert.ToDouble(Console.ReadLine());
      Console.Write("Informe a nota do 3° bimestre : ");
      nota3 = Convert.ToDouble(Console.ReadLine());
      Console.Write("Informe a nota do 4° bimestre : ");
      nota4 = Convert.ToDouble(Console.ReadLine());
      media = (nota1 + nota2 + nota3 + nota4) / 4;
      Console.WriteLine("A media é: " + media);
      Console.ReadKey(); 
  }
}