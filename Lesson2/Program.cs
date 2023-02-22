using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson2
{
    internal class Program
    {
        static void Main()
        {
            float sumNumbers;
            float arithmeticMean;
            string fullName1 = "Иваной Иван Иванович";
            string fullName2 = "Петров Петр Петрович";
            string fullName3 = "Акакиев Акакий Акаков";
            int earsOld1 = 21;
            int earsOld2 = 20;
            int earsOld3 = 22;
            string emailCom1 = "ivanov@gmail.com";
            string emailCom2 = "petrov@gmail.com";
            string emailCom3 = "gachiboy@gmail.com";
            float programScores1 = 50;
            float programScores2 = 47;
            float programScores3 = 61;
            float mathScores1 = 56;
            float mathScores2 = 72;
            float mathScores3 = 52;
            float physicsScores1 = 36;
            float physicsScores2 = 91;
            float physicsScores3 = 64;
            Console.WriteLine("Ф.И.О: {0} Возраст: {1} email: {2} Баллы по программированию: {3} Баллы по математике: {4} Баллы по физике: {5}",
                fullName1,
                earsOld1,
                emailCom1,
                programScores1,
                mathScores1,
                physicsScores1);
            Console.WriteLine("Ф.И.О: {0} Возраст: {1} email: {2} Баллы по программированию: {3} Баллы по математике: {4} Баллы по физике: {5}",
                fullName2,
                earsOld2,
                emailCom2,
                programScores2,
                mathScores2,
                physicsScores2);
            Console.WriteLine("Ф.И.О: {0} Возраст: {1} email: {2} Баллы по программированию: {3} Баллы по математике: {4} Баллы по физике: {5}",
                fullName3,
                earsOld3,
                emailCom3,
                programScores3,
                mathScores3,
                physicsScores3);
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Среднее арифметическое по результатом трех экзаменов.");
            Console.ReadLine();
            sumNumbers = programScores1 + physicsScores1 + mathScores1;
            Console.WriteLine(fullName1+" Результат: "+(arithmeticMean =sumNumbers/3)+" баллов" );
            sumNumbers = 0;
            Console.ReadLine();
            sumNumbers = programScores2 + physicsScores2 + mathScores2;
            Console.WriteLine(fullName2 + " Результат: " + (arithmeticMean = sumNumbers / 3) + " баллов");
            Console.ReadLine();
            sumNumbers = 0;
            sumNumbers = programScores3 + physicsScores3 + mathScores3;
            Console.WriteLine(fullName3 + " Результат: " + (arithmeticMean = sumNumbers / 3) + " баллов");
            Console.ReadKey();

        }
    }
}
