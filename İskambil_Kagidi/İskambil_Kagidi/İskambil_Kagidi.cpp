#include<iostream>

using namespace std;

enum SembolType
{
	Kupa,
	Karo,
	Maco,
	Sinek
};

enum RenkType
{
	Kirmizi,
	Siyah
};

class Sembol
{
	Sembol();
	Sembol(SembolType sembol);
	Sembol:: Sembol(SembolType sembol)
	{
		m_sembol = sembol;
		switch (SembolType)
		{
		case : Kupa
			   {
					m_renk = RenkType.Siyah;
			   }
		default:
		case : Karo
			   {
				   m_renk = RenkType.Kirmizi;
			   }
		default:
		case: Maco
			   {
				   m_renk = RenkType.Kirmizi;
			   }
		default:
		case: Sinek
			   {
				   m_renk = RenkType.Siyah;
			   }
		default:
			break;
		}
	} 
};

class IskambilKarti
{
	int m_rakam;
	Sembol m_sembol;
	IskambilKarti();
	IskambilKarti(int m_rakam,Sembol sembol);

};
 

int main()
{

}