using System;

namespace 第二章作业
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 作业一
            //while (true)
            //{
            //    try
            //    {
            //        Console.WriteLine("请输入第一个参数：");
            //        string o = Console.ReadLine();
            //        Console.WriteLine("请输入运算符：");
            //        string t = Console.ReadLine();
            //        Console.WriteLine("请输入第二个参数：");
            //        string tr = Console.ReadLine();
            //        Cal.Frist_number = Cal.Change(o);
            //        Cal.Opreator = t[0];
            //        Cal.Second_number = Cal.Change(tr);
            //        Console.WriteLine("结果为：{0}", Cal.Result());
            //    }
            //    catch
            //    {
            //        Console.WriteLine("异常中断");
            //    }
            //}

            #endregion
            #region 作业二
            Str2Num.St = Console.ReadLine();
            Str2Num.Str2num();
            #endregion
            #region 作业三
            #endregion
            Console.ReadKey();
        }

    }
    /// <summary>
    /// 作业一 calculate
    /// </summary>
    public class Cal
    {
        /// <summary>
        /// 第一个参数
        /// </summary>
        static public double Frist_number { get;set; }
        /// <summary>
        /// 运算符
        /// </summary>
        static public char Opreator { get; set; }
        /// <summary>
        /// 第二个参数
        /// </summary>
        static public double Second_number { get; set; }
        /// <summary>
        /// 运算结果
        /// </summary>
        /// <returns>本次运算的结果</returns>
        static public double Result()
        {
            double result;
            switch (Opreator)
            {
                case '+': result = Frist_number + Second_number; break;
                case '-': result = Frist_number - Second_number; break;
                case '*': result = Frist_number * Second_number; break;
                case '/': if (Second_number == 0) { Console.WriteLine("除数无意义"); result = 0.0; } else { result = Frist_number / Second_number; } break;
                default: Console.WriteLine("此运算不存在"); result = 0.0; break;
            }
            return result;
        }
        /// <summary>
        /// 将相应的字符串转换为数字
        /// </summary>
        /// <param name="st">输入的参数字符串</param>
        /// <returns>转换后的数字</returns>
        static public double Change(string st)
        {
            double num = 0;
            double num1 = 0;
            int flag = 1, fla = 1, f = 1;
            for (int i = 0; i < st.Length; i++)
            {
                if (st[i] == '-')
                {
                    flag = -1;
                }
                else if (st[i] >= '0' && st[i] <= '9')
                {
                    if (f == 1)
                        num = num * 10 + (st[i] - '0');
                    else
                    {
                        num1 = num1 * 10 + (st[i] - '0');
                        fla *= 10;
                    }
                }
                else if (st[i] == '.')
                {
                    f = 0;
                }
            }
            return flag * (num + num1 / fla);
        }

        static public bool Equals(int a,int b)
        {
            if (a == b)
                return true;
            else
                return false;
        }
    }
    /// <summary>
    /// 作业二 提取字符串中的数字
    /// </summary>
    public class Str2Num
    {
        /// <summary>
        /// 要操作的字符串
        /// </summary>
        static public string St { get; set; }
        /// <summary>
        /// 字符串中的数字
        /// </summary>
        static public void Str2num()
        {
            int num = 0;
            for(int i=0;i<St.Length;i++)
            {
                if(St[i]>='0'&&St[i]<='9')
                {
                    num = St[i] - '0';
                    Console.Write(num);
                }
            }
        }
    }
   /// <summary>
   /// 作业四 汽车类
   /// </summary>
    public class Car
    {
        /// <summary>
        /// 车牌号
        /// </summary>
        static public string Id { get; set; }
        /// <summary>
        /// 车的型号
        /// </summary>
        static public string Class { get; set; }
        /// <summary>
        /// 车的颜色
        /// </summary>
        static public string Color { get; set; }
    }
}
