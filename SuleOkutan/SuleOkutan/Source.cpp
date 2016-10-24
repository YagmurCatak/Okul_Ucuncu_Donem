#include <iostream>

using namespace std;

void main()
{
	int Toplam = 0;
	int sonuc = 0;

	for (int i=2; i<20; i=i+2)
	{
		sonuc = i; 
		i = i + 2 ;
		sonuc = sonuc * i; 
	}
	cout << sonuc << endl;
	system("pause");
}