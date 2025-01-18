int fun1(int m, int n)
{
	int s = 0;
	while (m <= n)
	{
		s += m;
		m++;
	}

	return s;
}

//fun1(1, 4);
//------
//s=0 => m=1, n=4
//m=1<4 -> s=0+1=1
//m=2<4 -> s=1+2=3
//m=3<4 -> s=3+3=6
//m=4=4 -> s=6+4=10
//m=5>4 -> exit