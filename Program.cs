using System;

namespace Lab2 // 21. Описать класс Комната, содержащий сведения о метраже, высоте потолков и количестве окон. Предусмотреть инициализацию
					//с проверкой допустимости значений полей. Описать методы вычисления площади и объема комнаты и свойства для получения состояния объекта.

{
	class Room
	{
		double length;
		double width;
		double high;
		int countWindow;

		public Room()
		{
			length = 0.0;
			width = 0.0;
			high = 0.0;
			countWindow = 0;
		}

		public Room(double length, double width, double high, int countWindow)
		{
			this.length = length;
			this.width = width;
			this.high = high;
			this.countWindow = countWindow;
		}

		public void print()
		{
			Console.WriteLine($"\nДлина комнаты: {length}, ширина: {width}, высота: {high}, количество окон: {countWindow}.\n");
		}

		public void Square()
		{
			Console.WriteLine($"Площадь комнаты: {length * width}.\n");
		}
		public void Volume()
		{
			Console.WriteLine($"Объем комнаты: {length * width * high}.\n");
		}
		public double Length
		{
			set
			{
				if (value < 1)
					Console.WriteLine("Значение не может быть отрицательным!");
				else
					length = value;
			}
			get { return length; }
		}
		public double Width
		{
			set
			{
				if (value < 1)
					Console.WriteLine("Значение не может быть отрицательным!");
				else
					width = value;
			}
			get { return width; }
		}
		public double High
		{
			set
			{
				if (value < 1)
					Console.WriteLine("Значение не может быть отрицательным!");
				else
					high = value;
			}
			get { return high; }
		}
		public int CountWindow
		{
			set
			{
				if (value < 1)
					Console.WriteLine("Значение не может быть отрицательным!");
				else
					countWindow = value;
			}
			get { return countWindow; }
		}

		static void Main(string[] args)
		{
			Console.Write("\nЦель данной программы заполнение данных о комнатах с последующим их выводом на экран,");
			Console.Write("а так же вычисление площади и объёма комнат.\n");
			int option = 0;
			while (option != 10)
			{
				Console.Write("\n1. Старт;\n10. ВЫХОД.\nВвод: ");
				option = Convert.ToInt32(Console.ReadLine()!);
				switch (option)
				{
					case 1:
						{
							Console.Write("\nВведите количество комнат: ");
							int RoomsCount = Convert.ToInt32(Console.ReadLine());
							var A = new Room[RoomsCount];
							for (int i = 0; i < RoomsCount; i++)
							{
								string l, w, h, c;

								do
								{
									Console.Write("\nВведите длину команты: ");
									l = Console.ReadLine()!;
								} while (Double.TryParse(l, out double ll) != true);
								double length = Convert.ToDouble(l);

								do
								{
									Console.Write("Введите ширину команты: ");
									w = Console.ReadLine()!;
								} while (Double.TryParse(w, out double ww) != true);
								double width = Convert.ToDouble(w);

								do
								{
									Console.Write("Введите высоту комнаты: ");
									h = Console.ReadLine()!;
								} while (Double.TryParse(h, out double hh) != true);
								double high = Convert.ToDouble(h);

								do
								{
									Console.Write("Введите количество окон в комнате: ");
									c = Console.ReadLine()!;
								} while (Int32.TryParse(c, out int cc) != true);
								int countWindow = Convert.ToInt32(c);

								A[i] = new Room(length, width, high, countWindow);
								A[i].print();
								A[i].Square();
								A[i].Volume();
								Console.WriteLine($"Количество окон: {A[i].CountWindow}");
							}
						}
						break;
					case 10:
						{
							//exit
							break;
						}
					default:
						{
							Console.WriteLine("\nВведено неверное число.\nВведите число 1 или 10.");
							break;
						}
				}
			}
		}
	}
}
