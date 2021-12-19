using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_15
{
    /*Разработать интерфейс ISeries генерации ряда чисел. Интерфейс содержит следующие элементы:
           - метод void setStart(int x) - устанавливает начальное значение
           - метод int getNext() - возвращает следующее число ряда
           - метод void reset() - выполняет сброс к начальному значению
      Разработать классы ArithProgression и GeomProgression, которые реализуют интерфейс ISeries. 
      В классах реализовать методы интерфейса в соответствии с логикой арифметической и геометрической прогрессии соответственно.*/
    class Program
    {
        static void Main(string[] args)
        {
            //Расчёты арифметической прогрессии
            ArithProgression arith = new ArithProgression();
            Console.WriteLine("Последовательно введите начальное значение и шаг для расчёта арифметической прогрессии:");
            arith.setStart(Convert.ToInt32(Console.ReadLine()));
            arith.setStep(Convert.ToInt32(Console.ReadLine()));
            Console.WriteLine("Результаты расчёта арифметической прогрессии:");
            Console.WriteLine(arith.getNext());
            Console.WriteLine(arith.getNext());
            Console.WriteLine(arith.getNext());
            Console.WriteLine(arith.getNext());
            Console.WriteLine(arith.getNext());
            Console.WriteLine(arith.getNext());
            Console.WriteLine("После сброса к начальному значению:");
            arith.reset();
            Console.WriteLine(arith.getNext());
            Console.WriteLine(arith.getNext());
            Console.WriteLine(arith.getNext());

            //Расчёты геометрической прогрессии
            GeomProgression geom = new GeomProgression();
            Console.WriteLine();
            Console.WriteLine("Последовательно введите начальное значение и шаг для расчёта геометрической прогрессии:");
            geom.setStart(Convert.ToInt32(Console.ReadLine()));
            geom.setStep(Convert.ToInt32(Console.ReadLine()));
            Console.WriteLine("Результаты расчёта геометрической прогрессии:");
            Console.WriteLine(geom.getNext());
            Console.WriteLine(geom.getNext());
            Console.WriteLine(geom.getNext());
            Console.WriteLine(geom.getNext());
            Console.WriteLine(geom.getNext());
            Console.WriteLine(geom.getNext());
            Console.WriteLine("После сброса к начальному значению:");
            geom.reset();
            Console.WriteLine(geom.getNext());
            Console.WriteLine(geom.getNext());
            Console.WriteLine(geom.getNext());
            Console.ReadKey();
        }
    }
    interface ISeries
    {
        void setStart(int x);
        int getNext();
        void reset();
    }
    class ArithProgression
    {
        int step;
        int startValue;
        int currentValue;

        public int getNext()
        {
            currentValue += step;
            return currentValue;
        }
        public void reset()
        {
            currentValue = startValue;
        }
        public void setStart (int x)
        {
            startValue = x;
            currentValue = startValue;
        }
        public void setStep (int s)
        {
            step = s;
        }
    }
    class GeomProgression
    {
        int step;
        int startValue;
        int currentValue;

        public int getNext()
        {
            currentValue *= step;
            return currentValue;
        }
        public void reset()
        {
            currentValue = startValue;
        }
        public void setStart(int x)
        {
            startValue = x;
            currentValue = startValue;
        }
        public void setStep(int s)
        {
            step = s;
        }
    }
}
