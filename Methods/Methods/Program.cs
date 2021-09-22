using System;

namespace Methods
{
    class Program

    {
        public static void Main(string[] args)
        {
            //Program.DoSomThing1();


            //Program obj = new Program();
            //obj.DoSomThing();

            //Program obj = new Program();
            //obj.JämnaSif();
            //obj.JämnaSif();

            //Program obj = new Program();
            //obj.EvenNum(30);

            //Program obj = new Program();
            //int result = obj.Sum(10,20);
            //Console.WriteLine(result);

            //Program obj = new Program();
            //string fn = obj.FullName("Anas","Anas");
            //Console.WriteLine("Your Full Name is : {0}",fn);
            //int Totale = 0;
            //int Product = 0;

            //Program.Calculate(10,20,out Totale,out Product);

            //Console.WriteLine("Sum = {0} & Product = {1}",Totale,Product);
            //int[] Numbers = new int[3];

            //Numbers[0] = 100;
            //Numbers[1] = 200;
            //Numbers[2] = 300;


            //Program.ParamMethod(Numbers);
            ////Program.ParamMethod();
            ///
            //int y = 0;
            //Program.Simpel(ref y);

            //Console.WriteLine(y);
            Bitmap bm = new Bitmap(8 * 100, 8 * 100);
            Graphics g = Graphics.FromImage(bm);
            Color color1, color2;
            for (int i = 0; i < 8; i++)
            {
                if (i % 2 == 0)
                {
                    color1 = Color.Black;
                    color2 = Color.White;
                }
                else
                {
                    color1 = Color.White;
                    color2 = Color.Black;
                }
                SolidBrush blackBrush = new SolidBrush(color1);
                SolidBrush whiteBrush = new SolidBrush(color2);

                for (int j = 0; j < 8; j++)
                {
                    if (j % 2 == 0)
                        g.FillRectangle(blackBrush, i * 100, j * 100, 100, 100);
                    else
                        g.FillRectangle(whiteBrush, i * 100, j * 100, 100, 100);
                }
            }

            g.DrawImage(bm, 150, 200);

        }


        //public  void DoSomThing()
        //{
        //    Console.WriteLine("Hello World1");
        //}

        //public void DoSomThing()
        //{
        //    Console.WriteLine("Hello World2");
        //}



        //public void JämnaSif()
        //{
        //    int start = 0;

        //    while (start <=20)
        //    {
        //        Console.WriteLine(start);
        //        start = start + 2;
        //    }
        //}

        //public void EvenNum(int target)
        //{
        //    Console.WriteLine("Print Even *Numbers from 0 to {0}",target);

        //    for (int i = 0; i <= target; i++)
        //    {
        //        if (i % 2==0)
        //        {
        //            Console.WriteLine(i + "");
        //        }
        //    }
        //}


        //public int Sum(int num1, int num2)
        //{
        //    return num1 + num2;
        //}

        //public string FullName(string firstName, string secondName)
        //{
        //    string FN = firstName + " " + secondName;
        //    return FN;
        //}

        //public static void Calculate(int firstNum, int secondNum, out int Sum, out int Product)
        //{
        //    Sum = firstNum + secondNum;
        //    Product = firstNum * secondNum;
        //}


        //public static void ParamMethod(params int[] Numbers)
        //{
        //    Console.WriteLine("There is {0} element ", Numbers.Length);
        //    foreach(int i in Numbers)
        //    {
        //        Console.WriteLine(i);
        //    }
        //}

        public static void Simpel(ref int x)
        {
            x = 111;
        }

    }
}
