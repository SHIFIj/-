namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            {
                try
                {
                    // Ввод коэффициентов уравнения
                    Console.WriteLine("Введите коэффициенты квадратного уравнения:");
                    Console.Write("a = ");
                    double a = Convert.ToDouble(Console.ReadLine());
                    Console.Write("b = ");
                    double b = Convert.ToDouble(Console.ReadLine());
                    Console.Write("c = ");
                    double c = Convert.ToDouble(Console.ReadLine());

                    // Проверка, что a не равно 0
                    if (a == 0)
                    {
                        throw new ArgumentException("Коэффициент a не может быть равен 0.");
                    }

                    // Вычисление дискриминанта
                    double discriminant = b * b - 4 * a * c;

                    // В зависимости от дискриминанта вычисляем корни
                    if (discriminant > 0)
                    {
                        // Два вещественных корня
                        double x1 = (-b + Math.Sqrt(discriminant)) / (2 * a);
                        double x2 = (-b - Math.Sqrt(discriminant)) / (2 * a);
                        Console.WriteLine($"Корни уравнения: x1 = {x1}, x2 = {x2}");
                    }
                    else if (discriminant == 0)
                    {
                        // Один вещественный корень
                        double x = -b / (2 * a);
                        Console.WriteLine($"Единственный корень: x = {x}");
                    }
                    else
                    {
                        // Нет вещественных корней
                        Console.WriteLine("Уравнение не имеет вещественных корней.");
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("Ошибка: введено нечисловое значение. Попробуйте еще раз.");
                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine($"Ошибка: {ex.Message}");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Неизвестная ошибка: {ex.Message}");
                }
            }
        }
    }
    }
