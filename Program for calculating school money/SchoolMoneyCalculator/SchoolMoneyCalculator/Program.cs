using System.Text;

using Cadastre.Data;

using Microsoft.EntityFrameworkCore;

using SchoolMoneyCalculator.Data.Models;

namespace SchoolMoneyCalculator
{
    public class Program
    {
        private static decimal balance;

        static void Main(string[] args)
        {
            var context = new CalculatorContext();

            string[] months = new string[] { "Януари", "Февруари", "Март", "Април", "Май", "Юни", "Юли", "Август", "Септември", "Октомври", "Ноември", "Декември" };

            int num = 0;
            while (num != 4)
            {
                balance = context.Calculators.Sum(x => x.СумаЗаМесеца);

                if (num != 0)
                {
                    Console.WriteLine();
                    Console.WriteLine("-----------------------------------");
                    Console.WriteLine();
                }

                Console.WriteLine($"Какво желаете:");
                Console.WriteLine($"1. Добавяне в базата данни");
                Console.WriteLine($"2. Променяне на данни");
                Console.WriteLine($"3. Баланс на картата");
                Console.WriteLine($"4. Край");

                num = int.Parse(Console.ReadLine());

                //1. Adding
                //     \/

                if (num == 1)
                {
                    Console.WriteLine($"Въведете месец: ");
                    string month = Console.ReadLine();
                    if (String.IsNullOrWhiteSpace(month) || !months.Contains(month))
                    {
                        while (String.IsNullOrWhiteSpace(month) || !months.Contains(month))
                        {
                            Console.WriteLine("Невалидна информация!");
                            Console.WriteLine("Опитай пак");
                            month = Console.ReadLine();
                        }
                    }


                    Console.WriteLine($"Въведете стипендия преведена през месец {month}: ");
                    decimal scholarship = decimal.Parse(Console.ReadLine());
                    if (scholarship < 0)
                    {
                        while (scholarship < 0)
                        {
                            Console.WriteLine("Невалидна информация!");
                            Console.WriteLine("Опитай пак");
                            scholarship = decimal.Parse(Console.ReadLine());
                        }
                    }


                    Console.WriteLine($"Въведете транспортни пари преведени през месец {month}: ");
                    decimal transportMoney = decimal.Parse(Console.ReadLine());
                    if (transportMoney < 0)
                    {
                        while (transportMoney < 0)
                        {
                            Console.WriteLine("Невалидна информация!");
                            Console.WriteLine("Опитай пак");
                            transportMoney = decimal.Parse(Console.ReadLine());
                        }
                    }

                    Console.WriteLine(AddingRecord(context, month, scholarship, transportMoney));
                }



                //2. Updating
                //      \/

                else if (num == 2)
                {
                    Console.WriteLine($"Въведете Месец: ");
                    string monthToUpdate = Console.ReadLine();
                    if (String.IsNullOrWhiteSpace(monthToUpdate) || !months.Contains(monthToUpdate))
                    {
                        while (String.IsNullOrWhiteSpace(monthToUpdate) || !months.Contains(monthToUpdate))
                        {
                            Console.WriteLine("Невалидна информация!");
                            Console.WriteLine("Опитай пак");
                            monthToUpdate = Console.ReadLine();
                        }
                    }

                    var tableToFind = context.Calculators.FirstOrDefault(x => x.Месец == monthToUpdate);

                    Calculator tableToUpdate;

                    if (tableToFind is not null)
                    {

                        Console.WriteLine($"Въведете какво искате да промените: ");
                        Console.WriteLine($"1. Стипендия");
                        Console.WriteLine($"2. Транспортни");

                        int text = int.Parse(Console.ReadLine());

                        if (text == 1)
                        {
                            Console.WriteLine($"Въведете каква да е новата стипендия за месец {tableToFind.Месец}: ");
                            decimal newSt = decimal.Parse(Console.ReadLine());

                            tableToFind.Стипендия = newSt;

                            decimal temp = 0.0m;

                            if (newSt < tableToFind.Стипендия)
                            {
                                temp = tableToFind.СумаЗаМесеца - (newSt + tableToFind.Транспортни);
                                balance -= temp;
                                tableToFind.СумаЗаМесеца -= temp;
                            }
                            else
                            {
                                temp = (newSt + tableToFind.Транспортни) - tableToFind.СумаЗаМесеца;
                                balance += temp;
                                tableToFind.СумаЗаМесеца += temp;
                            }

                            context.SaveChanges();
                        }


                        else if (text == 2)
                        {
                            Console.WriteLine($"Въведете какви да са новите транспортни за месец {tableToFind.Месец}: ");
                            decimal newTs = decimal.Parse(Console.ReadLine());

                            tableToFind.Транспортни = newTs;

                            decimal temp = 0.0m;

                            if (newTs < tableToFind.Транспортни)
                            {
                                temp = tableToFind.СумаЗаМесеца - (newTs + tableToFind.Стипендия);
                                balance -= temp;
                                tableToFind.СумаЗаМесеца -= temp;
                            }
                            else
                            {
                                temp = (newTs + tableToFind.Стипендия) - tableToFind.СумаЗаМесеца;
                                balance += temp;
                                tableToFind.СумаЗаМесеца += temp;
                            }


                            context.SaveChanges();
                        }
                        else
                        {
                            Console.WriteLine($"Невалидна дата!");
                        }

                    }
                    else
                    {
                        Console.WriteLine($"Невалидна Дата!");
                    }

                }

                //3. Balance
                //      \/

                else if (num == 3)
                {
                    Console.WriteLine("-----------------------------------");
                    Console.WriteLine();
                    Console.WriteLine($"Баланс: {balance}");
                }
                else if (num <= 0 || num > 3)
                {
                    Console.WriteLine("Невалидна дата");
                }
            }

        }


        private static string AddingRecord(CalculatorContext context, string month, decimal scholarship, decimal transportMoney)
        {
            
            balance += scholarship + transportMoney;


            var calculatorToAdd = new Calculator()
            {
                Месец = month,
                Стипендия = scholarship,
                Транспортни = transportMoney,
                СумаЗаМесеца = scholarship + transportMoney,
            };


            context.Calculators.Add(calculatorToAdd);
            context.SaveChanges();

            StringBuilder sb = new StringBuilder();

            Console.WriteLine();
            Console.WriteLine("--------------------------------------------------------------------------");
            Console.WriteLine();


            sb.AppendLine($"Успешно прибавяне!");
            sb.AppendLine($"Сума (Стипендия + Транспортни) за месец {month} - {scholarship + transportMoney}");

            if (month == "Септемрви")
            {
                sb.AppendLine($"Пари, които да приведе Бащицата за месец {month} - {50 - transportMoney}");
            }
            else
            {
                sb.AppendLine($"Пари, които да приведе Бащицата за месец {month} - {100 - transportMoney}");
            }

            return sb.ToString().TrimEnd();
        }
    }
}