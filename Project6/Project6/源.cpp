/*************************************************
Copyright (C), 1988-1999, Huawei Tech. Co., Ltd.
File name:         练习// 文件名
Author:    赵志鹏       Version:    1.0.0        Date:    2018-10-1 // 作者、版本及完成日期
Description:    // 用于详细说明此程序文件完成的主要功能，与其他模块
						 // 或函数的接口，输出值、取值范围、含义及参数间的控
						 // 制、顺序、独立或依赖等关系   Others:
						 // 其它内容的说明   Function List:  // 主要函数列表，每条记录应包括函数名及功能简要说明     1. ....
History:			// 修改历史记录列表，每条修改记录应包括修改日期、修改
						// 者及修改内容简述
*************************************************/


/*************************************************
						系	统	内	部	头	文	件
*************************************************/
#include<iostream>
#include<string>

using namespace std;

/*************************************************
								函	数	声	明
*************************************************/
int Numboer_Of_Str1(string Actual_Str, string Com_Str);
int Numboer_Of_Str2(string Actual_Str, string Com_Str);
/*************************************************
								全	局	变	量
*************************************************/

/*************************************************
								程	序	入	口
*************************************************/
int main()
{
	//string str="ababjavafsjlkjavak;javaljava";
	//string str1="java";
	string str = "abcdabcdabcd";
	string str1 = "ab";
	cout << Numboer_Of_Str1(str, str1)<<endl;
	cout << Numboer_Of_Str2(str, str1)<<endl;
	system("pause");
	return 0;
}
/*************************************************
								函	数	定	义
*************************************************/

/*********************
函	数	名：Numboer_Of_Str
入			参：Actual_Str:原字符串 Com_Str:比较的字符串
返	回	值：个数num
用			处：使用字符串方法计算原字符串中比较字符串出现的次数
*********************/
int Numboer_Of_Str1(string Actual_Str, string Com_Str)
{
	int num = 0;
	int flag = 0;
	for (int i = 0; i < Actual_Str.length(); i++)
	{

		if (Actual_Str[i] == Com_Str[0])
		{

			flag = 1;

			/*compare方法*/

			if (Actual_Str.compare(i, Com_Str.length(), Com_Str) != 0)
			{
				flag = 0;
			}

			if (flag == 1)
			{
				num++;
				i += Com_Str.length();
			}

		}/*end of if */

	}/*end of i循环*/

	return num;
}

/*********************
函	数	名：Numboer_Of_Str
入			参：Actual_Str:原字符串 Com_Str:比较的字符串
返	回	值：个数num
用			处：使用循环计算原字符串中比较字符串出现的次数
*********************/
int Numboer_Of_Str2(string Actual_Str, string Com_Str)
{
	int num = 0;
	int flag = 0;
	for (int i = 0; i < Actual_Str.length(); i++)
	{

		if (Actual_Str[i] == Com_Str[0])
		{

			flag = 1;

			/*循环实现比较*/
			for (int j = 0; j < Com_Str.length(); j++)
			{
				if (Actual_Str[i + j] != Com_Str[j])
					if (Actual_Str.compare(i, j, Com_Str) != 0)
					{
						flag = 0;
						break;
					}
			}/*end of j循环*/

			if (flag == 1)
			{
				num++;
				i += Com_Str.length();
			}

		}/*end of if */

	}/*end of i循环*/

	return num;
}

