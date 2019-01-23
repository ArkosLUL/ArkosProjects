// lr5.cpp: ���������� ����� ����� ��� ����������� ����������.
//

#include "stdafx.h"
#include <stdio.h>
#include <cstdio>
#include <iostream>
#include <iomanip>
#include <fstream>
#include <string>


using namespace std;

struct List {
	char FIO [40];
	unsigned int key;
	unsigned int day;
	unsigned int month;
	unsigned int year;
	List * next;
	List * prev;
};
List * find_elem_by_key(List * head, unsigned int key)//�� ������
{
	if(head == NULL)
	{
		cout << "C����� ����" << endl;
		return NULL;
	}
	List * elem = NULL;
	List * current = head;
	while(current->next != NULL)
	{
	
		if(current->key == key)
		{
			
			return current;
		}
		current = current->next;
		
	}
	if(current->key == key)
	{
			
		return current;
	}
	
	return elem;
}
void Add(List *& head, List *& end)
{
	int from_keys = 0;
	cout << "������� 1,���� ������ ������� �������� � ����������, � �� ����� in.txt " << endl;
	cin >> from_keys;
	if(from_keys == 1)
	{
		if(head != NULL)
		{

			cout <<"������� ���������� ��������� ������� �� ������ ��������"  << endl;
		
			List *current = head;
			List * tail = end;
			int n;
			cin >> n;
			
			while(current->next != NULL)
			{
				current = current->next;
			}
			for( int i = 0 ; i < n; i++)
			{
				List *temp = new List;
				cout << "������� ���" << endl;
				cin.ignore();
				gets_s(temp->FIO);
				cout << "������� ����� �������������" << endl;
				cin >> temp->key;
				cout << "������� ����" << endl;
				cin >> temp->day;
				cout << "������� �����" << endl;
				cin >> temp->month;
				cout << "������� ���" << endl;
				cin >> temp->year;
				List *buf = find_elem_by_key(head,temp->key);
				if(buf == NULL)
				{
					current->next = temp;
					temp->prev = current;
					current = temp;
					current->next = NULL;
				}
				else {
					strcpy(buf->FIO,temp->FIO);
					buf->day = temp->day;
					buf->month = temp->month;
					buf->year = temp->year;
					
				}
			}
			end = current;
			current->next = NULL;
			
		}
		else 
		{
			cout <<"������� ���������� ��������� ������� �� ������ ��������"  << endl;
			head = new List;
			int n;
			cin >> n;
			List *current = head;
			List *tail = end;
			cin.ignore();
			cout << "������� ���" << endl;
			gets_s(current->FIO);
			cout << "������� ����� �������������" << endl;
			cin >> current->key;
			cout << "������� ����" << endl;
			cin >> current->day;
			cout << "������� �����" << endl;
			cin >> current->month;
			cout << "������� ���" << endl;
			cin >> current->year;
			head->prev = NULL;
			current->next = NULL;
			end = current;
			end->next = NULL;

		
			for( int i = 0 ; i < (n-1); i++)
			{
				List *temp = new List;
				
				cout << "������� ���" << endl;
				cin.ignore();
				gets_s(temp->FIO);
				cout << "������� ����� �������������" << endl;
				cin >> temp->key;
				cout << "������� ����" << endl;
				cin >> temp->day;
				cout << "������� �����" << endl;
				cin >> temp->month;
				cout << "������� ���" << endl;
				cin >> temp->year;
				List *buf = find_elem_by_key(head,temp->key);
				if(buf == NULL)
				{
					current->next = temp;
					temp->prev = current;
					current = temp;
					current->next = NULL;
				}
				else {
					strcpy(buf->FIO,temp->FIO);
					buf->day = temp->day;
					buf->month = temp->month;
					buf->year = temp->year;
					
				}
			}
			
		}
	}
	else
	{
		fstream file1;
		file1.open("in.txt",ios::in | ios::out);
		if(!file1.is_open())
		{
			cout<< "���-�� �� ��� � ������� ������,������ ����� ��� �� ����������" << endl ;
			return;
		}
		if(head != NULL)
		{
			List *current = head;
			List *tail = end;
			while(current->next != NULL)
			{
				current = current->next;
			}
			List *temp = new List;
			file1.getline(temp->FIO,40,';');
			file1 >> temp->key;
			file1 >> temp->day;
			file1 >> temp->month;
			file1 >> temp->year;
			List *buf = find_elem_by_key(head,temp->key);
			if(buf == NULL)
			{
				current->next = temp;
				temp->prev = current;
				current = temp;
				current->next = NULL;
			}
			else {
				strcpy(buf->FIO,temp->FIO);
				buf->day = temp->day;
				buf->month = temp->month;
				buf->year = temp->year;
				
			}
			string line;
			while(getline(file1,line))
			{
				List *temp = new List;
				file1.getline(temp->FIO,40,';');
				file1 >> temp->key;
				file1 >> temp->day;
				file1 >> temp->month;
				file1 >> temp->year;
				List *buf = find_elem_by_key(head,temp->key);
				if(buf == NULL)
				{
					current->next = temp;
					temp->prev = current;
					current = temp;
					current->next = NULL;
				}
				else {
					strcpy(buf->FIO,temp->FIO);
					buf->day = temp->day;
					buf->month = temp->month;
					buf->year = temp->year;
				
				}
			}
			current->next = NULL;
			end = current;
		}else 
		{
			head = new List;
			List *current = head;
			List *tail = end;
			
			file1.getline(current->FIO,40,';');
			file1 >> current->key;
			file1 >> current->day;
			file1 >> current->month;
			file1 >> current->year;
			current->next = NULL;
			string line;
			while(getline(file1,line))
			{
				List *temp = new List;
				file1.getline(temp->FIO,40,';');
				file1 >> temp->key;
				file1 >> temp->day;
				file1 >> temp->month;
				file1 >> temp->year;
				List *buf = find_elem_by_key(head,temp->key);
				if(buf == NULL)
				{
					current->next = temp;
					temp->prev = current;
					current = temp;
					current->next = NULL;
				}
				else {
					strcpy(buf->FIO,temp->FIO);
					buf->day = temp->day;
					buf->month = temp->month;
					buf->year = temp->year;
				
				}
			}
			current->next = NULL;
			end = current;
		}
	}
}
void OutputEnd(List *end)
{
	fstream file2;
	file2.open("result.txt", ios::out);
	List * tail = end;
	if (tail != NULL)
	{	
		int i = 1;
		
			

			//cout << i << "." << setw(40) << left << current->FIO << "����: " << current->key << "\t���� �������� " << current->day << "." << current->month << "." << current->year << endl;
		
	}
	else
	{
		cout << "������ ���� " << endl;
		file2 << "������ ���� " << endl;
	}

}
void Output(List *head)
{
	fstream file2;
	file2.open("result.txt",ios::out);
	List * current = head;
	if(current != NULL)
	{

		int i = 1;
		while(current->next != NULL)
		{
			cout << i << "." <<setw(40) <<left <<current->FIO << "����: " <<current->key << "\t���� �������� " <<current->day << "." << current->month <<"."<<current->year <<endl;
			file2 << i << "." <<setw(40) <<left <<current->FIO<< "����: " <<current->key << "\t���� �������� " <<current->day << "." << current->month <<"."<<current->year << endl;
			current = current->next;
			i++;

		}
		cout << i << "." <<setw(40) <<left <<current->FIO << "����: " <<current->key << "\t���� �������� " <<current->day << "." << current->month <<"."<<current->year <<endl;
		file2 << i << "." <<setw(40) <<left <<current->FIO<< "����: " <<current->key << "\t���� �������� " <<current->day << "." << current->month <<"."<<current->year << endl;
			
	}
	else 
		{ 
			cout << "������ ���� " << endl;
			file2 <<"������ ���� " << endl;
		}
}
void Add_One(List*& head, List*& end)
{
	int count = 0;
	List * current = head;
	List * tail = end;
	if(current != NULL)
	{
		while(current->next != NULL)
		{
			
			current = current->next;
		}
		
		List *temp = new List;
		cout << "������� ���" << endl;
		cin.ignore();
		gets_s(temp->FIO);
		cout << "������� ����� �������������" << endl;
		cin >> temp->key;
		cout << "������� ����" << endl;
		cin >> temp->day;
		cout << "������� �����" << endl;
		cin >> temp->month;
		cout << "������� ���" << endl;
		cin >> temp->year;
		List *buf = find_elem_by_key(head,temp->key);
		if(buf == NULL)
		{
					tail = temp;
					tail->next = NULL;
					current->next = temp;
					temp->prev = current;
					temp->next = NULL;
				}
		else {
			strcpy(buf->FIO,temp->FIO);
			buf->day = temp->day;
			buf->month = temp->month;
			buf->year = temp->year;
					
		}
	}
	else
	{
		head = new List;
		end = new List;
		cin.ignore();
		cout << "������� ���" << endl;
		gets_s(head->FIO);
		cout << "������� ����� �������������" << endl;
		cin >> head->key;
		cout << "������� ����" << endl;
		cin >> head->day;
		cout << "������� �����" << endl;
		cin >> head->month;
		cout << "������� ���" << endl;
		cin >> head->year;
		head->next = NULL;
		head->prev = NULL;
		end->next = NULL;
		
	}

}
void delete_elem(List *&head, List * temp1, List *&end)//������ ��������,��� �������� ������� ����� �������
{
	if(head == NULL)
	{
		cout << "������ ���� " << endl;
		return;
	}
	//if(temp1 == head)
	//{
	//	//cout << "  " << endl;
	//	if(head->next != NULL)
	//	{

	//		head = head->next;
	//		head->prev = NULL;
	//	}
	//	return;
	//}
	List * current = head;
	List * temp = current;
	if(temp1 == current)
	{
		head = head->next;
		if(head->next != NULL)
			head->next->prev = NULL;
		end = temp1->prev;
		return;
	}
	while(current != NULL)
	{
		//temp = current;
		if( temp1 == current->next)
		{
			temp = current;
			current = current->next;
			break;
		}
		current = current->next;

	}
	if(current->next != NULL)
	{
	temp->next = current->next;
	current->next->prev = temp;
	}
	else {
		temp->next = NULL;
	}
	delete[] current;

}
void Delete_List(List *&head, List *&end)
{
	if(head == NULL)
	{
		cout << "������ ���� " << endl;
		return;
	}
	if(head->next == NULL)
	{
		
		delete []head;
		end = NULL;
		head = NULL;
		return;

	}
	List *current=head->next;
	List * nextptr;
	while(current->next!=NULL)
	{
		
		nextptr = current->next;
		delete [] current;
		current = nextptr;
	

	}
	delete [] current;
	delete []head;
	end = NULL;
	head = NULL;
}
int _tmain()
{
	setlocale(LC_ALL,"Russian");
	List *head = NULL;
	List *end = NULL;
	List *buf = NULL;
	unsigned int key;
	int k = 0;

	do
	{
		cout << "1.������������� ������(� ����-�� ��� �����)  " << endl;
		cout << "2.�������� 1 ������� " << endl;
		cout << "3.����� ������� �� ����� " << endl;
		cout << "4.�������� �������� �� �����  " << endl;
		cout << "5.����� ������ � ���������� ��� � ���� " << endl;
		cout << "6.������� ������ " << endl;
		cout << "7.������� ��������� " << endl;
		cin >> k;
		switch(k)
		{
		case 1:
			{
				Add(head, end);
				break;
			}
		case 2:
			{
				Add_One(head, end);
				break;

			}
		case 3:
			{
				
				cout << "������� ���� " << endl;
				cin >> key;
				buf = find_elem_by_key(head,key);
				if(buf != NULL)
				cout<<setw(40) <<left <<buf->FIO << "����: " <<buf->key << "���� ��������" <<buf->day << "." << buf->month <<"."<<buf->year <<endl;
				else cout << "�������� � ����� ������ ���" << endl;
				break;

			}
		case 4:
			{
				
				cout << "������� ���� " << endl;
				cin >> key;
				buf = find_elem_by_key(head,key);
				if(buf != NULL)
				delete_elem(head,buf,end);
				else cout << "�������� � ����� ������ ���" << endl;
				break;

			}
		case 5:
			{
				Output(head);
				break;

			}
		case 6:
			{
				Delete_List(head,end);
				break;

			}
		case 7:
			{
			//OutputEnd(end);
			cout  << "." << setw(40) << left << end->FIO << "����: " << end->key << "\t���� �������� " << end->day << "." << end->month << "." << end->year << endl;
				break;

			}
		default:
			cout << "�� ������� ������������ �����" << endl;
			break;
		}




		}while(k!=7);

	system("pause");
	return 0;
}

