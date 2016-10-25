#include <iostream>

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
	Sembol *smb = new Sembol(myEnums::Kupa);
	int rakam = 10;
	IskambilKarti *kart = new IskambilKarti(*smb, rakam);

	cout << ConvertRenkValues(kart->m_sembol.m_renk) << endl;
	return 0;
}

const char* ConvertRenkValues(myEnums::RenkType renk)
{
	switch (renk)
	{
	case myEnums::Siyah:
		return "Siyah";
	case myEnums::Kirmizi:
		return "Kirmizi";
	}
}