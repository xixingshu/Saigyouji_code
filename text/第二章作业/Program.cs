using System;

namespace 第二章作业
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 作业一
            while (true)
            {
                
                    Console.WriteLine("请输入第一个参数：");
                    Cal.Frist_st = Console.ReadLine();
                    Console.WriteLine("请输入运算符：");
                    Cal.Opreator = Console.ReadLine()[0];
                    Console.WriteLine("请输入第二个参数：");
                    Cal.Second_str = Console.ReadLine();
                try
                {
                    int.Parse(Cal.Frist_st);
                    Console.WriteLine("结果为：{0}", Cal.Result());
                }
                catch
                {
                    Console.WriteLine("结果为：{0}", Cal.Re());
                }
               
            }

            #endregion
            #region 作业二
            //Str2Num.St = Console.ReadLine();
            //Str2Num.Str2num();
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
        /// 第一个参数的输入与转换
        /// </summary>
        static public string Frist_st { get; set; }
        static public double Frist_number => Change(Frist_st);
        /// <summary>
        /// 运算符
        /// </summary>
        static public char Opreator { get; set; }
        /// <summary>
        /// 第二个参数的输入与转换
        /// </summary>
        static public string Second_str { get; set; }
        static public double Second_number => Change(Second_str);
        /// <summary>
        /// 运算结果 无结果返回0xffff
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
                default: Console.WriteLine("此运算不存在"); result = 0xffff; break;
            }
            return result;
        }
        /// <summary>
        /// 运算结果 无结果返回空
        /// </summary>
        /// <returns></returns>
        static public string Re ()
        {
            string result;
            int flag = 0;
            switch(Opreator)
            {
                case '+':result = Frist_st + Second_str;break;
                case '-':
                    for (int i = 0; i < Frist_st.Length; i++)
                    {
                        if (Frist_st[i] == Second_str[0])
                            for (int j = 0; j < Second_str.Length; j++)
                            {
                                if (Frist_st[i + j] != Second_str[j])
                                    break;
                                flag++;
                            }
                        if (flag == Second_str.Length)
                        {
                            result = Frist_st.Remove(i, flag);
                            return result;
                        }
                    }
                    result = "";
                    break;
                default:
                    Console.WriteLine("此运算不存在");result = ""; break;
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
