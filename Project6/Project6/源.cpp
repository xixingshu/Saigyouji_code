/*************************************************
Copyright (C), 1988-1999, Huawei Tech. Co., Ltd.
File name:         ��ϰ// �ļ���
Author:    ��־��       Version:    1.0.0        Date:    2018-10-1 // ���ߡ��汾���������
Description:    // ������ϸ˵���˳����ļ���ɵ���Ҫ���ܣ�������ģ��
						 // �����Ľӿڣ����ֵ��ȡֵ��Χ�����弰������Ŀ�
						 // �ơ�˳�򡢶����������ȹ�ϵ   Others:
						 // �������ݵ�˵��   Function List:  // ��Ҫ�����б�ÿ����¼Ӧ���������������ܼ�Ҫ˵��     1. ....
History:			// �޸���ʷ��¼�б�ÿ���޸ļ�¼Ӧ�����޸����ڡ��޸�
						// �߼��޸����ݼ���
*************************************************/


/*************************************************
						ϵ	ͳ	��	��	ͷ	��	��
*************************************************/
#include<iostream>
#include<string>

using namespace std;

/*************************************************
								��	��	��	��
*************************************************/
int Numboer_Of_Str1(string Actual_Str, string Com_Str);
int Numboer_Of_Str2(string Actual_Str, string Com_Str);
/*************************************************
								ȫ	��	��	��
*************************************************/

/*************************************************
								��	��	��	��
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
								��	��	��	��
*************************************************/

/*********************
��	��	����Numboer_Of_Str
��			�Σ�Actual_Str:ԭ�ַ��� Com_Str:�Ƚϵ��ַ���
��	��	ֵ������num
��			����ʹ���ַ�����������ԭ�ַ����бȽ��ַ������ֵĴ���
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

			/*compare����*/

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

	}/*end of iѭ��*/

	return num;
}

/*********************
��	��	����Numboer_Of_Str
��			�Σ�Actual_Str:ԭ�ַ��� Com_Str:�Ƚϵ��ַ���
��	��	ֵ������num
��			����ʹ��ѭ������ԭ�ַ����бȽ��ַ������ֵĴ���
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

			/*ѭ��ʵ�ֱȽ�*/
			for (int j = 0; j < Com_Str.length(); j++)
			{
				if (Actual_Str[i + j] != Com_Str[j])
					if (Actual_Str.compare(i, j, Com_Str) != 0)
					{
						flag = 0;
						break;
					}
			}/*end of jѭ��*/

			if (flag == 1)
			{
				num++;
				i += Com_Str.length();
			}

		}/*end of if */

	}/*end of iѭ��*/

	return num;
}

