#include <stdio.h>
#include <conio.h>
#include <stdlib.h>
#include <time.h>
#define BOYUT 10

using namespace std;
int labirent[10][10] =
	{
		{1,1,1,1,1,1,1,1,1,1},
		{0,1,0,0,0,0,1,0,0,0},
		{0,1,0,0,0,0,1,0,0,0},
		{0,1,1,1,1,1,1,0,0,0},
		{0,1,0,1,0,0,1,1,1,1},
		{0,1,0,1,0,0,1,0,0,1},
		{0,1,0,1,0,0,1,0,0,1},
		{0,1,0,1,0,0,1,0,0,1},
		{0,1,0,1,0,0,1,0,0,1},
		{0,1,0,1,1,1,1,0,0,1}
	};

int sag_Git (int x)
{
	
	x++;
	return ;
}

int asagi_Git (int y)
{
	y++;
	return ;
}

int sola_Git (int x)
{
	x--;
	return ;
}

int yukari_Git(int y)
{
	y--;
	return ;
}

int main()
{
	int x=0,y=0;
	
	
	printf("\n\n");
	for (int i=0; i<BOYUT; i++)
	{
		for(int j=0; j<BOYUT ; j++)
			{
             printf("%d", labirent[i][j]);
            }
		printf("\n");
	}

	if (labirent[x][y] == 1)
	{
		sag_Git(x);
		if (labirent[x][y]==1)
		{
			asagi_Git(y);
			if (labirent[x][y]==1)
			{
				sola_Git(x);
			}
		}
	}
	system("pause");
	return 0;
	
}

