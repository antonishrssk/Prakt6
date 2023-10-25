namespace Lib_4
{
    public class Pair
    {
        public int P1 { get; set; } // Первое число пары
        public int P2 { get; set; } // Второе число пары

        /// <summary>
        /// Параметризированный конструктор для класса Pair
        /// </summary>
        /// <param name="p1">Первое число пары</param>
        /// <param name="p2">Второе число пары</param>
        public Pair(int p1, int p2)
        {
            P1 = p1;
            P2 = p2;
        }

        /// <summary>
        /// Устанавливает значения для пары чисел
        /// </summary>
        /// <param name="p1">Первое число пары</param>
        /// <param name="p2">Второе число пары</param>
        public void SetParams(int p1, int p2)
        {
            P1 = p1;
            P2 = p2;
        }

        /// <summary>
        /// Устанавливает значения для пары чисел из другой пары чисел
        /// </summary>
        /// <param name="pair">Пара чисел</param>
        public void SetParams(Pair pair)
        {
            P1 = pair.P1;
            P2 = pair.P2;
        }

        /// <summary>
        /// Оператор "больше" для сравнения двух пар
        /// </summary>
        /// <param name="first">Пара 1</param>
        /// <param name="second">Пара 2</param>
        /// <returns>Булевое значение</returns>
        public static bool operator >(Pair first, Pair second)
        {
            return first.P1 > first.P2 || first.P1 == first.P2 && second.P1 > second.P2;
        }

        /// <summary>
        /// Оператор "меньше" для сравнения двух пар
        /// </summary>
        /// <param name="first">Пара 1</param>
        /// <param name="second">Пара 2</param>
        /// <returns>Булевое значение</returns>
        public static bool operator <(Pair first, Pair second) 
        {
            return first.P1 < first.P2 || first.P1 == first.P2 && second.P1 < second.P2;
        }
    }
}
