#include<iostream>
#include<string>
#include<iomanip>
using namespace std;
/**
*	MAXSIZE		:最大容量
*	Current_SIZE	:当前容量
*/
#define MAXSIZE 40
#define Current_SIZE 2

#pragma region 操作结果
typedef enum {
	Failed = -1,
	Number_Change = 0,
	Book_Change = 1
}Statue;
#pragma endregion

#pragma region 结构体的定义
/**
*	ISBN		:ISBN书号
*	Name		:书名
*	Number	:这本书的数量
*	Price		:这本书的售价
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
	ElemType data[MAXSIZE]; // 用数组表示顺序表
	 int length;    // 线性表当前长度
} SqList ;
#pragma endregion

#pragma region 函数声明
//==========================
void BookInit(SqList *List);															/*初始化*/
void display(SqList *List);															/*初始化*/
Statue Add(SqList *List, Book book);											/*增*/
Statue Del(SqList *List, Book book);											/*删*/
Statue Change(SqList *List, Book book);									/*改*/
Statue LookFor(SqList *List);																/*查*/
//==========================
#pragma endregion


int main()
{
	SqList list;
	Book book1,book2;
	book1.ISBN = "1234";
	book1.Name = "c++从入门到神学";
	book1.Number = 10;
	book1.Price = 50;
	book2.ISBN = "12234";
	book2.Name = "c++从入门到神学2";
	book2.Number = 102;
	book2.Price = 152;
	list.length = Current_SIZE;
#pragma region 初始化
	cout << "初始化:" << endl;
	BookInit(&list);
	display(&list);
	system("pause");
	system("cls");
#pragma endregion
#pragma region 增加
	cout << "增:" << endl;
	Add(&list, book1);
	Add(&list, book2);
	display(&list);
	system("pause");
	system("cls");
#pragma endregion
#pragma region 删除
	cout << "删:" << endl;
	Del(&list, book2);
	Del(&list, book1);
	display(&list);
	system("pause");
	system("cls");
#pragma endregion
#pragma region 修改
	display(&list);
	book1.Number = 100;
	book1.Price = 5;
	cout << "改:" << endl;
	Change(&list, book1);
	display(&list);
	system("pause");
	system("cls");
#pragma endregion
#pragma region 查询
	cout << "查:" << endl;
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
	cout << setw(10) << "ISBN编号" << setw(20) << "书名" << setw(15) << "剩余数量" << setw(10) << "价格" << endl;
}
//======================
#pragma region 初始化

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

#pragma region 显示
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

#pragma region 增加
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
				cout << "录入信息有误！请再次确认";
				return Failed;
			}
		}
		
	}
	List->length += 1;
	List->data[List->length - 1] = book;
	return Book_Change;

}
#pragma endregion

#pragma region 删除
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
				cout << "录入信息有误！请再次确认";
				return Failed;
			}
		}
	}
		return Failed;	
}
#pragma endregion

#pragma region 修改
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

#pragma region 查询
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


