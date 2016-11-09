#include <iostream>
#include <cstdlib>
#include <stdio.h> 
#include <time.h>

using namespace std;

namespace myEnums
{
	enum SembolType
	{
		Kupa,
		Karo,
		Sinek,
		Maca
	};

	enum RenkType
	{
		Siyah,
		Kirmizi
	};

};

class Sembol
{
public:
	myEnums::SembolType	m_sembol;
	myEnums::RenkType	m_renk;

	Sembol() {};
	Sembol(myEnums::SembolType sembol)
	{
		m_sembol = sembol;
		switch (sembol)
		{
		case myEnums::Kupa:
			m_renk = myEnums::Kirmizi;
			break;
		case myEnums::Karo:
			m_renk = myEnums::Kirmizi;
			break;
		case myEnums::Sinek:
			m_renk = myEnums::Siyah;
			break;
		case myEnums::Maca:
			m_renk = myEnums::Siyah;
			break;
		/*default:
			break;*/  // Burada default case ine gerek yok cünkü, enum kullandik ve baska deger alma ihtimali yok sembol'un.
		}
	};
};


class IskambilKarti
{
public:
	Sembol	m_sembol;
	int		m_rakam;

	IskambilKarti() {};
	IskambilKarti(Sembol sembol, int rakam)
	{
		m_sembol = sembol;
		m_rakam = rakam;
	};


};

const char* ConvertRenkValues(myEnums::RenkType);
const char* ConvertRenkValues(myEnums::SembolType);

int main()
{

	////MEMORY MANAGEMENT	
	//Sembol *smb = new Sembol();
	//int _sizeOfPointer = sizeof(smb);
	//Sembol _smb;
	//int _sizeOfStack = sizeof(_smb);

	//cout << _sizeOfPointer << endl;
	//cout << _sizeOfStack << endl;

	//delete smb;

	//MAIN CODE
	srand(time(NULL));
	int say1,say2;
	int kart_sayi,Secilen_kart,menu_sayi;
	int Deger_Tutan[100],YeniArray[100];
	IskambilKarti iskambilDizi[100];
	/*int random_rakam = rand()%4;
	myEnums::SembolType type  = (myEnums::SembolType) random_rakam;
	Sembol *smb = new Sembol(type);
	IskambilKarti *kart = new IskambilKarti(*smb, rakam);
	cout << ConvertRenkValues(kart->m_sembol.m_sembol);
	cout << rakam <<endl;*/
	
	cout << "Istediginiz kart sayisini girin";
	cin >> kart_sayi;

	for (int i=0; i<=kart_sayi-1; i++)
	{
		int rakam ;
		rakam = rand()%13; 
		int random_rakam = rand()%4;
		myEnums::SembolType type  = (myEnums::SembolType) random_rakam;
		Sembol *smb = new Sembol(type);
		IskambilKarti *kart = new IskambilKarti(*smb, rakam);
		cout << ConvertRenkValues(kart->m_sembol.m_sembol);
		cout << rakam <<endl;
		iskambilDizi[i] = *kart;
		
	}
	cout << "MENU " << endl;
	cout << "1.Sil" << endl;
	cout << "2.Degistir" << endl;
	cin >> menu_sayi;

	if( menu_sayi == 1)
	{
		int i=0;
		cout <<	"bir kart seciniz" << endl;
		cin >> Secilen_kart;
		IskambilKarti bos;
		iskambilDizi[Secilen_kart] = bos;
		
	}
	else 
	{
		cout <<	"iki kart seciniz" << endl;
		cin >> say1;
		cin >> say2;
		IskambilKarti sayidizi;
		sayidizi= iskambilDizi[say2-1];
		iskambilDizi[say2-1] = iskambilDizi[say1-1];
		iskambilDizi[say1-1] = sayidizi;

		for (int i = 0; i <kart_sayi; i++)
		{
			
			cout << iskambilDizi[i].m_rakam<< endl;
			
			
		}

		
	}
	

	system("pause");
	return 0;
}

const char* ConvertRenkValues(myEnums::RenkType renk)
{
	switch (renk)
	{
	case myEnums::Siyah:
		system("color 70");
		return "Siyah";
		
	case myEnums::Kirmizi:
		system("color 74");
		return "Kirmizi";
		
	}
}

const char* ConvertRenkValues(myEnums::SembolType Sembol)
{
	switch (Sembol)
	{
	case myEnums::Karo:
		system("color 70");
		return "Karo";
	case myEnums::Sinek:
		system("color 70");
		return "Sinek";
	case myEnums::Maca:
		system("color 74");
		return "Maco";
	case myEnums::Kupa:
		system("color 74");
		return "Kupa";

	}
}

