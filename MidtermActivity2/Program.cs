using System;
using TrigonometryLibrary;

namespace TrigonometryCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("╔══════════════════════════════════════════╗");
                Console.WriteLine("║          TRIGONOMETRY CALCULATOR         ║");
                Console.WriteLine("╠══════════════════════════════════════════╣");
                Console.WriteLine("║ 1. Solve using Sine                      ║");
                Console.WriteLine("║ 2. Solve using Cosine                    ║");
                Console.WriteLine("║ 3. Solve using Tangent                   ║");
                Console.WriteLine("║ 4. Degrees to Radians                    ║");
                Console.WriteLine("║ 0. Exit                                  ║");
                Console.WriteLine("╚══════════════════════════════════════════╝");
                Console.WriteLine();

                Console.Write("Select an option: ");
                int choice;

                if (int.TryParse(Console.ReadLine(), out choice))
                {
                    Console.WriteLine();

                    switch (choice)
                    {
                        case 1:
                            ShowSineMenu();
                            break;

                        case 2:
                            ShowCosineMenu();
                            break;

                        case 3:
                            ShowTangentMenu();
                            break;

                        case 4:
                            ConvertDegreesToRadians();
                            break;

                        case 0:
                            Console.WriteLine("Goodbye!");
                            return;

                        default:
                            Console.WriteLine("Please enter a valid option.");
                            Console.WriteLine();
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Error. Invalid input.");
                    Console.WriteLine();
                }
            }
        }

        static void ShowSineMenu()
        {
            var sineCalculator = new CalculateUsingSin();

            while (true)
            {
                Console.Clear();
                Console.WriteLine("╔══════════════════════════════════════════╗");
                Console.WriteLine("║       SOLVE USING SINE - OPTIONS         ║");
                Console.WriteLine("╠══════════════════════════════════════════╣");
                Console.WriteLine("║ 1. Solve Opposite Side                   ║");
                Console.WriteLine("║ 2. Solve Hypotenuse                      ║");
                Console.WriteLine("║ 3. Solve Angle (Degrees)                 ║");
                Console.WriteLine("║ 4. Solve Angle (Radians)                 ║");
                Console.WriteLine("║ 0. Back                                  ║");
                Console.WriteLine("╚══════════════════════════════════════════╝");
                Console.WriteLine();

                Console.Write("Select an option: ");
                int choice;

                if (int.TryParse(Console.ReadLine(), out choice))
                {
                    Console.WriteLine();

                    switch (choice)
                    {
                        case 1:
                            sineCalculator.Angle = GetUserInput("Enter the angle in degrees: ");
                            sineCalculator.Hypotenuse = GetUserInput("Enter the hypotenuse: ");
                            double oppositeSide = sineCalculator.SolveOpposite();
                            DisplayResult("Opposite Side", oppositeSide);
                            WaitForEnterKey();
                            break;

                        case 2:
                            sineCalculator.Angle = GetUserInput("Enter the angle in degrees: ");
                            sineCalculator.Opposite = GetUserInput("Enter the opposite side: ");
                            double hypotenuse = sineCalculator.SolveHypotenuse();
                            DisplayResult("Hypotenuse", hypotenuse);
                            WaitForEnterKey();
                            break;

                        case 3:
                            sineCalculator.Opposite = GetUserInput("Enter the opposite side: ");
                            sineCalculator.Hypotenuse = GetUserInput("Enter the hypotenuse: ");
                            double angleInDegrees = sineCalculator.SolveAngle();
                            DisplayResult("Angle", angleInDegrees);
                            WaitForEnterKey();
                            break;

                        case 4:
                            sineCalculator.Opposite = GetUserInput("Enter the opposite side: ");
                            sineCalculator.Hypotenuse = GetUserInput("Enter the hypotenuse: ");
                            double angleInRadians = sineCalculator.FindRadians();
                            DisplayResult("Angle", angleInRadians);
                            WaitForEnterKey();
                            break;

                        case 0:
                            return;

                        default:
                            Console.WriteLine("Please enter a valid option.");
                            Console.WriteLine();
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Error. Invalid input.");
                    Console.WriteLine();
                }
            }
        }

        static void ShowCosineMenu()
        {
            var cosineCalculator = new CalculateUsingCos();

            while (true)
            {
                Console.Clear();
                Console.WriteLine("╔══════════════════════════════════════════╗");
                Console.WriteLine("║      SOLVE USING COSINE - OPTIONS        ║");
                Console.WriteLine("╠══════════════════════════════════════════╣");
                Console.WriteLine("║ 1. Solve Adjacent Side                   ║");
                Console.WriteLine("║ 2. Solve Hypotenuse                      ║");
                Console.WriteLine("║ 3. Solve Angle                           ║");
                Console.WriteLine("║ 0. Back                                  ║");
                Console.WriteLine("╚══════════════════════════════════════════╝");
                Console.WriteLine();

                Console.Write("Select an option: ");
                int choice;

                if (int.TryParse(Console.ReadLine(), out choice))
                {
                    Console.WriteLine();

                    switch (choice)
                    {
                        case 1:
                            cosineCalculator.Angle = GetUserInput("Enter the angle in degrees: ");
                            cosineCalculator.Hypotenuse = GetUserInput("Enter the hypotenuse: ");
                            double adjacentSide = cosineCalculator.SolveAdjacent();
                            DisplayResult("Adjacent Side", adjacentSide);
                            WaitForEnterKey();
                            break;

                        case 2:
                            cosineCalculator.Angle = GetUserInput("Enter the angle in degrees: ");
                            cosineCalculator.Adjacent = GetUserInput("Enter the adjacent side: ");
                            double hypotenuse = cosineCalculator.SolveHypotenuse();
                            DisplayResult("Hypotenuse", hypotenuse);
                            WaitForEnterKey();
                            break;

                        case 3:
                            cosineCalculator.Adjacent = GetUserInput("Enter the adjacent side: ");
                            cosineCalculator.Hypotenuse = GetUserInput("Enter the hypotenuse: ");
                            double angleInDegrees = cosineCalculator.SolveAngle();
                            DisplayResult("Angle", angleInDegrees);
                            WaitForEnterKey();
                            break;

                        case 0:
                            return;

                        default:
                            Console.WriteLine("Please enter a valid option.");
                            Console.WriteLine();
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Error. Invalid input.");
                    Console.WriteLine();
                }
            }
        }

        static void ShowTangentMenu()
        {
            var tangentCalculator = new CalculateUsingTan();

            while (true)
            {
                Console.Clear();
                Console.WriteLine("╔══════════════════════════════════════════╗");
                Console.WriteLine("║     SOLVE USING TANGENT - OPTIONS        ║");
                Console.WriteLine("╠══════════════════════════════════════════╣");
                Console.WriteLine("║ 1. Solve Opposite Side                   ║");
                Console.WriteLine("║ 2. Solve Adjacent Side                   ║");
                Console.WriteLine("║ 3. Solve Angle                           ║");
                Console.WriteLine("║ 0. Back                                  ║");
                Console.WriteLine("╚══════════════════════════════════════════╝");
                Console.WriteLine();

                Console.Write("Select an option: ");
                int choice;

                if (int.TryParse(Console.ReadLine(), out choice))
                {
                    Console.WriteLine();

                    switch (choice)
                    {
                        case 1:
                            tangentCalculator.Angle = GetUserInput("Enter the angle in degrees: ");
                            tangentCalculator.Adjacent = GetUserInput("Enter the adjacent side: ");
                            double oppositeSide = tangentCalculator.SolveOpposite();
                            DisplayResult("Opposite Side", oppositeSide);
                            WaitForEnterKey();
                            break;

                        case 2:
                            tangentCalculator.Angle = GetUserInput("Enter the angle in degrees: ");
                            tangentCalculator.Opposite = GetUserInput("Enter the opposite side: ");
                            double adjacentSide = tangentCalculator.SolveAdjacent();
                            DisplayResult("Adjacent Side", adjacentSide);
                            WaitForEnterKey();
                            break;

                        case 3:
                            tangentCalculator.Opposite = GetUserInput("Enter the opposite side: ");
                            tangentCalculator.Adjacent = GetUserInput("Enter the adjacent side: ");
                            double angleInDegrees = tangentCalculator.SolveAngle();
                            DisplayResult("Angle", angleInDegrees);
                            WaitForEnterKey();
                            break;

                        case 0:
                            return;

                        default:
                            Console.WriteLine("Please enter a valid option.");
                            Console.WriteLine();
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Error. Invalid input.");
                    Console.WriteLine();
                }
            }
        }

        static void ConvertDegreesToRadians()
        {
            var degToRad = new ConvertAngleToRadians();

            Console.Clear();
            double angle = GetUserInput("Enter angle in degrees: ");

            double radian = degToRad.ConvertToRadians(angle);

            DisplayResult("Radians", radian);

            WaitForEnterKey();
        }

        static double GetUserInput(string prompt)
        {
            Console.Write(prompt);
            return double.Parse(Console.ReadLine());
        }

        static void DisplayResult(string label, double result)
        {
            Console.WriteLine($"{label}: {result}");
        }

        static void WaitForEnterKey()
        {
            Console.WriteLine("\nPress Enter to continue...");
            Console.ReadLine();
        }
    }
}

