// В этом пространстве имен содержатся средства для работы с изображениями. Чтобы оно стало доступно, в проект был подключен Reference на сборку System.Drawing.dll
using System.Drawing;
using System;
namespace Fractals
{
	internal static class DragonFractalTask
	{
        public static void DrawDragonFractal(Pixels pixels, int iterationsCount, int seed)
        {
            /*
			Начните с точки (1, 0)
			Создайте генератор рандомных чисел с сидом seed
			
			На каждой итерации:

			1. Выберите случайно одно из следующих преобразований и примените его к текущей точке:

				Преобразование 1. (поворот на 45° и сжатие в sqrt(2) раз):
				x' = (x · cos(45°) - y · sin(45°)) / sqrt(2)
				y' = (x · sin(45°) + y · cos(45°)) / sqrt(2)

				Преобразование 2. (поворот на 135°, сжатие в sqrt(2) раз, сдвиг по X на единицу):
				x' = (x · cos(135°) - y · sin(135°)) / sqrt(2) + 1
				y' = (x · sin(135°) + y · cos(135°)) / sqrt(2)
		
			2. Нарисуйте текущую точку методом pixels.SetPixel(x, y)

			*/
            double x = 1, y = 0;
            double x1, y1;
            var random = new Random(seed);
            int nextNumber;
            for (int i = 0; i < iterationsCount; i++)
            {
                nextNumber = random.Next(0, 2);
                if (nextNumber == 0)
                {
                    x1 = (x * Math.Cos(Math.PI / 4) - y * Math.Sin(Math.PI / 4)) / Math.Sqrt(2);
                    y1 = (x * Math.Sin(Math.PI / 4) + y * Math.Cos(Math.PI / 4)) / Math.Sqrt(2);
                }
                else
                {
                    x1 = (x * Math.Cos(3 * Math.PI / 4) - y * Math.Sin(3 * Math.PI / 4)) / Math.Sqrt(2) + 1;
                    y1 = (x * Math.Sin(3 * Math.PI / 4) + y * Math.Cos(3 * Math.PI / 4)) / Math.Sqrt(2);
                }
                x = x1;
                y = y1;
                pixels.SetPixel(x, y);
            }
        }
    }
}
}

/*        public static void Conversion1(Pixels pixels, double x, double y)
        {
            x = (x * Math.Cos(45) - y * Math.Sin(45)) / Math.Sqrt(2);
            y = (x * Math.Sin(45) + y * Math.Cos(45)) / Math.Sqrt(2);
            pixels.SetPixel(x, y);
        }
        public static void Conversion2(Pixels pixels, double x, double y)
        {
            x = (x * Math.Cos(135) - y * Math.Sin(135)) / Math.Sqrt(2) + 1;
            y = (x * Math.Sin(135) + y * Math.Cos(135)) / Math.Sqrt(2);
            pixels.SetPixel(x, y);
        }
*/
