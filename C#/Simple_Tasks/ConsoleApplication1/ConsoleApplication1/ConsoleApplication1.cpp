#include "stdafx.h"
#include <windows.h>
#include <iostream> 

using namespace std;

EXCEPTION_RECORD er; // информация об исключении 
DWORD filter_function(EXCEPTION_POINTERS *p)
{
	// сохраняем содержимое структуры EXCEPTION_RECORD 
	er = *(p->ExceptionRecord);
	return EXCEPTION_EXECUTE_HANDLER;
}
int main()
{
	_try
	{
		RaiseException(	// вызываем исключение
			3221225617,            // код исключения деления на ноль
			0,                    // continuable exception 
			0, NULL);             // no arguments 

	}
		_except(filter_function(GetExceptionInformation()))
	{
		// распечатываем информацию об исключении 
		cout << "ExceptionCode = " << er.ExceptionCode << endl;
		cout << "ExceptionFlags = " << er.ExceptionFlags << endl;
		cout << "ExceptionRecord = " << er.ExceptionRecord << endl;
		cout << "ExceptionAddress = " << er.ExceptionAddress << endl;
		cout << "NumberParameters = " << er.NumberParameters << endl;
		// распечатываем параметры 
		if (er.ExceptionCode == EXCEPTION_INT_DIVIDE_BY_ZERO)
		{
			cout << "Type of access = " << er.ExceptionInformation[0] << endl;
			cout << "Address of access = " << er.ExceptionInformation[1] << endl;
		}
		cout << endl;
	}
	return 0;
}
