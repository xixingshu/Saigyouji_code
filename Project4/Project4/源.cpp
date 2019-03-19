#include<iostream>
#include<string>
#include<iomanip>
using namespace std;
/**
*	MAXSIZE		:�������
*	Current_SIZE	:��ǰ����
*/
#define MAXSIZE 40
#define Current_SIZE 2

#pragma region �������
typedef enum {
	Failed = -1,
	Number_Change = 0,
	Book_Change = 1
}Statue;
#pragma endregion

#pragma region �ṹ��Ķ���
/**
*	ISBN		:ISBN���
*	Name		:����
*	Number	:�Ȿ�������
*	Price		:�Ȿ����ۼ�
*/
typedef struct {
	 string ISBN;
	 string Name;
	 int Number;
	 int Price;
}Book;

//=============================
typedef Book ElemType;
//=============================

typedef struct {
	ElemType data[MAXSIZE]; // �������ʾ˳���
	 int length;    // ���Ա�ǰ����
} SqList ;
#pragma endregion

#pragma region ��������
//==========================
void BookInit(SqList *List);															/*��ʼ��*/
void display(SqList *List);															/*��ʼ��*/
Statue Add(SqList *List, Book book);											/*��*/
Statue Del(SqList *List, Book book);											/*ɾ*/
Statue Change(SqList *List, Book book);									/*��*/
Statue LookFor(SqList *List);																/*��*/
//==========================
#pragma endregion


int main()
{
	SqList list;
	Book book1,book2;
	book1.ISBN = "1234";
	book1.Name = "c++�����ŵ���ѧ";
	book1.Number = 10;
	book1.Price = 50;
	book2.ISBN = "12234";
	book2.Name = "c++�����ŵ���ѧ2";
	book2.Number = 102;
	book2.Price = 152;
	list.length = Current_SIZE;
#pragma region ��ʼ��
	cout << "��ʼ��:" << endl;
	BookInit(&list);
	display(&list);
	system("pause");
	system("cls");
#pragma endregion
#pragma region ����
	cout << "��:" << endl;
	Add(&list, book1);
	Add(&list, book2);
	display(&list);
	system("pause");
	system("cls");
#pragma endregion
#pragma region ɾ��
	cout << "ɾ:" << endl;
	Del(&list, book2);
	Del(&list, book1);
	display(&list);
	system("pause");
	system("cls");
#pragma endregion
#pragma region �޸�
	display(&list);
	book1.Number = 100;
	book1.Price = 5;
	cout << "��:" << endl;
	Change(&list, book1);
	display(&list);
	system("pause");
	system("cls");
#pragma endregion
#pragma region ��ѯ
	cout << "��:" << endl;
	LookFor(&list);
	system("pause");
	system("cls");
#pragma endregion
	display(&list);
	system("pause");
	return 0;
}
//======================
void display()
{
	cout << setw(10) << "ISBN���" << setw(20) << "����" << setw(15) << "ʣ������" << setw(10) << "�۸�" << endl;
}
//======================
#pragma region ��ʼ��

void BookInit(SqList *List)
{
	display();
	for (int i = 0; i < List->length; i++)
	{
		cin >> List->data[i].ISBN;
		cin >> List->data[i].Name;
		cin >> List->data[i].Number;
		cin >> List->data[i].Price;
	}
}
#pragma endregion

#pragma region ��ʾ
void display(SqList *List)
{
	display();
	for (int i = 0; i < List->length; i++)
	{
		cout << setw(10) << List->data[i].ISBN;
		cout << setw(20) << List->data[i].Name;
		cout << setw(15) << List->data[i].Number;
		cout << setw(10) << List->data[i].Price;
		cout<< endl;
	}
}
#pragma endregion

#pragma region ����
Statue Add(SqList *List,Book book)
{
	if (List->length >= MAXSIZE)return Failed;

	for (int i = 0; i < List->length; i++)
	{
		if (List->data[i].ISBN == book.ISBN)
		{
			if (List->data[i].Name == book.Name && List->data[i].Price == book.Price)
			{
				List->data[i].Number += book.Number;
				return Number_Change;
			}
			else
			{
				cout << "¼����Ϣ�������ٴ�ȷ��";
				return Failed;
			}
		}
		
	}
	List->length += 1;
	List->data[List->length - 1] = book;
	return Book_Change;

}
#pragma endregion

#pragma region ɾ��
Statue Del(SqList *List,Book book)
{
	if (List->length <=0 )return Failed;

	for (int i = 0; i < List->length; i++)
	{
		if (List->data[i].ISBN == book.ISBN)
		{
			if (List->data[i].Name == book.Name && List->data[i].Price == book.Price)
			{
				List->data[i].Number -= book.Number;
				if (List->data[i].Number < 0)
					return Failed;
				else if (List->data[i].Number == 0)
				{
					for (int j = i; j > List->length - 1; j++)
					{
						List->data[j] = List->data[j + 1];
					}
					List->length -= 1;
					return Book_Change;
				}
				else
					return Number_Change;
			}
			else
			{
				cout << "¼����Ϣ�������ٴ�ȷ��";
				return Failed;
			}
		}
	}
		return Failed;	
}
#pragma endregion

#pragma region �޸�
Statue Change(SqList *List, Book book)
{
	if (List->length <= 0)return Failed;

	for (int i = 0; i < List->length; i++)
	{
		if (List->data[i].ISBN == book.ISBN)
		{
			List->data[i] = book;
			return Book_Change;
		}
	}
	cout << "Failed";
	return Failed;
}
#pragma endregion

#pragma region ��ѯ
Statue LookFor(SqList *List)
{
	if (List->length <= 0)return Failed;
	Book book;
	cin >> book.ISBN;
	for (int i = 0; i < List->length; i++)
	{
		if (List->data[i].ISBN == book.ISBN)
		{
			display();
			cout <<setw(10)<< List->data[i].ISBN;
			cout << setw(20) << List->data[i].Name;
			cout << setw(15) << List->data[i].Number;
			cout << setw(10) << List->data[i].Price;
			cout<< endl;
			return Book_Change;
		}
	}
	cout << "Failed";
	return Failed;
}
#pragma endregion


