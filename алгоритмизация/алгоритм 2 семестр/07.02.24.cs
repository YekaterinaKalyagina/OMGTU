namespace ConsoleApplication31
{
    class Menu
    {
        public string first = "1. Создание базы данных";
        public string second = "2. Добавление в базу данных новую информацию";
        public string third = "3. Изменение данных аудиторий по заданному номеру";
        public string fourth = "4. Выбор аудиторий с заданным количеством мест больше или равным заданного";
        public string fifth = "5.  Выбор аудиторий с проектором ";
        public string sixth = "6.  Выбор аудиторий с ПК и заданным количеством посадочных мест";
        public string seventh = "7.  Выбор аудиторий по номеру этажа";
        public string eighth = "8.  Вывод всех данных по аудиториям";
        public string nineth = "9.  Выход";
        public void StartMenu()
        {
            Console.WriteLine("Меню:");
            Console.WriteLine(first);
            Console.WriteLine(second);
            Console.WriteLine(third);
            Console.WriteLine(fourth);
            Console.WriteLine(fifth);
            Console.WriteLine(sixth);
            Console.WriteLine(seventh);
            Console.WriteLine(eighth);
            Console.WriteLine(nineth);
        }

    }
    class ClassRoom
    {
        public int Number;
        public int Places;
        public int Projector;
        public int PC;

        public void formmasiv(List<int> a)
        {
            a.Add(Number);
            a.Add(Places);
            a.Add(Projector);
            a.Add(PC);
        }
    }

    internal class Program
    {

        static void Main(string[] args)
        {
            Menu startmenu = new Menu();
            startmenu.StartMenu();
            Console.WriteLine("Введите выбранную операцию:");
            ClassRoom Classroom0 = new ClassRoom();

            List<int> a = new List<int>();
            int length = 0;
            int temp = 0;
            int DobavAud = 0;
            string operation = Console.ReadLine();
            while (operation != "9")
            {
                switch (operation)
                {
                    case "1":
                        Console.Clear();
                        Console.WriteLine("_________________________________________________________________________________");
                        Console.WriteLine("Введите номер кабинета:");
                        Classroom0.Number = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine("Количество мест в аудитории:");
                        Classroom0.Places = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine("Наличие проектора в аудитории (если есть проектор, то вводится 1,если нет-0):");
                        temp = Convert.ToInt32(Console.ReadLine());
                        while (temp != 0 && temp != 1)
                        {
                            Console.WriteLine("Неверное значение, введите 1 или 0:");
                            temp = Convert.ToInt32(Console.ReadLine());
                        }
                        Classroom0.Projector = temp;

                        Console.WriteLine("Наличие пк в аудитории(если есть пк,то вводится 1,если нет-0):");
                        temp = Convert.ToInt32(Console.ReadLine());
                        while (temp != 0 && temp != 1)
                        {
                            Console.WriteLine("Неверное значение, введите 1 или 0:");
                            temp = Convert.ToInt32(Console.ReadLine());
                        }
                        Classroom0.PC = temp;

                        Console.WriteLine("_________________________________________________________________________________");
                        Classroom0.formmasiv(a);
                        Console.WriteLine("Нажмите любую кнопку для продолжения");
                        Console.ReadKey();
                        /*length = a.Count();
                        for (int i = 0; i < length; i+=4)
                        {
                            for (int j = i; j < i+4; j++)
                            {
                                Console.Write(a[j] + " ");
                            }
                            Console.Write("\n");
                        }*/
                        break;
                    case "2":
                        Console.Clear();
                        Console.WriteLine("_________________________________________________________________________________");
                        Console.WriteLine("Введите количество аудиторий, которые хотите добавить(отличное от 0):");
                        DobavAud = Convert.ToInt32(Console.ReadLine());
                        for (int k = 0; k < DobavAud; k++)
                        {
                            Console.WriteLine("Введите номер кабинета:");
                            Classroom0.Number = Convert.ToInt32(Console.ReadLine());

                            Console.WriteLine("Количество мест в аудитории:");
                            Classroom0.Places = Convert.ToInt32(Console.ReadLine());

                            Console.WriteLine("Наличие проектора в аудитории (если есть проектор, то вводится 1,если нет-0):");
                            temp = Convert.ToInt32(Console.ReadLine());
                            while (temp != 0 && temp != 1)
                            {
                                Console.WriteLine("Неверное значение, введите 1 или 0:");
                                temp = Convert.ToInt32(Console.ReadLine());
                            }
                            Classroom0.Projector = temp;

                            Console.WriteLine("Наличие пк в аудитории(если есть пк,то вводится 1,если нет-0):");
                            temp = Convert.ToInt32(Console.ReadLine());
                            while (temp != 0 && temp != 1)
                            {
                                Console.WriteLine("Неверное значение, введите 1 или 0:");
                                temp = Convert.ToInt32(Console.ReadLine());
                            }
                            Classroom0.PC = temp;

                            Console.WriteLine("_________________________________________________________________________________");
                            Classroom0.formmasiv(a);
                        }
                        Console.WriteLine("Нажмите любую кнопку для продолжения");
                        Console.ReadKey();
                        /* length = a.Count();
                         for (int i = 0; i < length; i+=4)
                         {
                             for (int j = i; j < i+4; j++)
                             {
                                 Console.Write(a[j] + " ");
                             }
                             Console.Write("\n");
                         }*/
                        break;
                    case "3":
                        Console.Clear();
                        Console.WriteLine("_________________________________________________________________________________");
                        Console.WriteLine("Введите номер номер аудитории, данные которой вы хотите изменить:");
                        temp = Convert.ToInt32(Console.ReadLine());
                        length = a.Count();
                        for (int i = 0; i < length; i += 4)
                        {
                            if (a[i] == temp)
                            {
                                Console.WriteLine("Количество мест в аудитории:");
                                a[i + 1] = Convert.ToInt32(Console.ReadLine());

                                Console.WriteLine("Наличие проектора в аудитории (если есть проектор, то вводится 1,если нет-0):");
                                temp = Convert.ToInt32(Console.ReadLine());
                                while (temp != 0 && temp != 1)
                                {
                                    Console.WriteLine("Неверное значение, введите 1 или 0:");
                                    temp = Convert.ToInt32(Console.ReadLine());
                                }
                                a[i + 2] = temp;

                                Console.WriteLine("Наличие пк в аудитории(если есть пк,то вводится 1,если нет-0):");
                                temp = Convert.ToInt32(Console.ReadLine());
                                while (temp != 0 && temp != 1)
                                {
                                    Console.WriteLine("Неверное значение, введите 1 или 0:");
                                    temp = Convert.ToInt32(Console.ReadLine());
                                }
                                a[i + 3] = temp;
                                break;
                            }
                        }
                        Console.WriteLine("Аудитория с заданым номером не найдена:(");

                        /* length = a.Count();
                         for (int i = 0; i < length; i+=4)
                         {
                             for (int j = i; j < i+4; j++)
                             {
                                 Console.Write(a[j] + " ");
                             }
                             Console.Write("\n");
                         }*/
                        Console.WriteLine("_________________________________________________________________________________");
                        Console.WriteLine("Нажмите любую кнопку для продолжения");
                        Console.ReadKey();
                        break;
                    case "4":
                        Console.Clear();
                        Console.WriteLine("_________________________________________________________________________________");
                        Console.WriteLine("Введите количество посадочных мест для поиска аудиторий с заданным количеством мест больше или равным заданного:");
                        temp = Convert.ToInt32(Console.ReadLine());
                        length = a.Count();
                        for (int i = 1; i < length; i += 4)
                        {
                            if (a[i] >= temp)
                            {
                                Console.Write(a[i - 1] + " ");
                                Console.Write(a[i] + " ");
                                Console.Write(a[i + 1] + " ");
                                Console.Write(a[i + 2]);
                                Console.Write("\n");
                            }
                        }
                        Console.WriteLine("_________________________________________________________________________________");
                        Console.WriteLine("Нажмите любую кнопку для продолжения");
                        Console.ReadKey();
                        break;
                    case "5":
                        Console.Clear();
                        Console.WriteLine("_________________________________________________________________________________");
                        length = a.Count();
                        for (int i = 2; i < length; i += 4)
                        {
                            if (a[i] == 1)
                            {
                                Console.Write(a[i - 2] + " ");
                                Console.Write(a[i - 1] + " ");
                                Console.Write(a[i] + " ");
                                Console.Write(a[i + 1]);
                                Console.Write("\n");
                            }
                        }
                        Console.WriteLine("_________________________________________________________________________________");
                        Console.WriteLine("Нажмите любую кнопку для продолжения");
                        Console.ReadKey();
                        break;
                    case "6":
                        Console.Clear();
                        Console.WriteLine("_________________________________________________________________________________");
                        Console.WriteLine("Введите количество посадочных мест для поиска аудиторий с ПК и с заданным количеством мест больше или равным заданного:");
                        temp = Convert.ToInt32(Console.ReadLine());
                        length = a.Count();
                        for (int i = 1; i < length; i += 4)
                        {
                            if (a[i] >= temp && a[i + 2] == 1)
                            {
                                Console.Write(a[i - 1] + " ");
                                Console.Write(a[i] + " ");
                                Console.Write(a[i + 1] + " ");
                                Console.Write(a[i + 2]);
                                Console.Write("\n");
                            }
                        }
                        Console.WriteLine("_________________________________________________________________________________");
                        Console.WriteLine("Нажмите любую кнопку для продолжения");
                        Console.ReadKey();
                        break;
                    case "7":
                        Console.Clear();
                        Console.WriteLine("Введите номер этажа:");
                        temp = Convert.ToInt32(Console.ReadLine());
                        length = a.Count();
                        for (int i = 0; i < length; i += 4)
                        {
                            if (a[i] / 100 == temp)
                            {
                                Console.Write(a[i] + " ");
                                Console.Write(a[i + 1] + " ");
                                Console.Write(a[i + 2] + " ");
                                Console.Write(a[i + 3]);
                                Console.Write("\n");
                            }
                        }
                        Console.WriteLine("_________________________________________________________________________________");
                        Console.WriteLine("Нажмите любую кнопку для продолжения");
                        Console.ReadKey();
                        break;
                    case "8":
                        Console.Clear();
                        Console.WriteLine("_________________________________________________________________________________");
                        length = a.Count();
                        for (int i = 0; i < length; i += 4)
                        {
                            for (int j = i; j < i + 4; j++)
                            {
                                Console.Write(a[j] + " ");
                            }
                            Console.Write("\n");
                        }
                        Console.WriteLine("_________________________________________________________________________________");
                        Console.WriteLine("Нажмите любую кнопку для продолжения");
                        Console.ReadKey();
                        break;

                }
                Console.Clear();
                startmenu.StartMenu();
                Console.WriteLine("Введите выбранную операцию:");
                operation = Console.ReadLine();
            }
        }
    }
}
