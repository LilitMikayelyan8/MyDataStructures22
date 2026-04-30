using MyChessProj;

PrintMatrixMainDiagonal(8);

PrintMatrixAuxiliaryDiagonal(5);

MyPointer p1 = new MyPointer(1, 3);
MyPointer p2 = new MyPointer(1, 6);
Console.WriteLine(CheckTheRook(p1, p2));

MyPointer p3 = new MyPointer(1, 3);
MyPointer p4 = new MyPointer(1, 6);
Console.WriteLine(CheckTheKnight(p3, p4));

void PrintMatrixMainDiagonal(int matrixSize)
{
	char[,] matrix = new char[matrixSize, matrixSize];
	for (int i = 0; i < matrixSize; i++)
	{
		for (int j = 0;	j< matrixSize; j++)
		{
            if (i == j)
                matrix[i, j] = '#';
            else
                matrix[i, j] = '*';
            Console.Write(matrix[i, j].ToString() + '\t');
        }
        Console.WriteLine();
	}
    char[] newarr = new char[matrixSize];
	for (int i = 0; i < matrixSize; i++)
	{
		newarr[i] = matrix[i,i];
	}
    Console.WriteLine(newarr);
}


void PrintMatrixAuxiliaryDiagonal(int matrixSize)
{
    char[,] matrix = new char[matrixSize, matrixSize];
    for (int i = 0; i < matrixSize; i++)
    {
        for (int j = 0; j < matrixSize; j++)
        {
            if (i + j == matrixSize - 1)
                matrix[i, j] = '#';
            else
                matrix[i, j] = '*';
            Console.Write(matrix[i, j].ToString() + '\t');
        }
        Console.WriteLine();
    }
    char[] newarr = new char[matrixSize];
    for (int i = 0; i < matrixSize; i++)
    {
        for(int j = 0;j < matrixSize; j++)
        {
            if (i+j==matrixSize-1)
            {
                newarr[i]=matrix[i,j];
            }
        }
    }
    Console.WriteLine(newarr);
}

bool CheckTheRook(MyPointer p1, MyPointer p2)
{
    if (p1.x == p2.x || p1.y == p2.y)
        return true;
    return false;
}

bool CheckTheKnight(MyPointer p1, MyPointer p2)
{
    int a = Math.Abs(p1.x - p2.x);
    int b = Math.Abs(p1.y - p2.y);
    if ((a==2 && b==1) || (a==1 && b==2))
        return true;
    return false;
}

int CountTheSteps(MyPointer p1, MyPointer p2) 
{

    int[,] matrix = new int[8, 8];
    for (int i = 0; i < 8; i++)
    {
        for (int j = 0; j < 8; j++)
        {
            matrix[i, j] = '0';
            
            Console.Write(matrix[i, j].ToString() + '\t');
        }
        Console.WriteLine();
    }

    return 0;
    
}

