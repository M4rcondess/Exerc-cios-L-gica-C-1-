using System;

class Program {
  public static void Main (string[] args) {
    Console.WriteLine ("Digite a temperatura em Fahrenheit");
    int tempF = Convert.ToInt16(Console.ReadLine());
    int tempC = ((tempF - 32) *5) /9;

    Console.WriteLine("A temperatura em celsius é:" + tempC.ToString());
    Console.ReadKey();
 }
}