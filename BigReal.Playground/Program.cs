﻿using ExtendedNumerics;
using System.Numerics;

Console.WriteLine(new BigReal(0.012345).ToString(3));
Console.WriteLine(new BigReal((BigInteger)1234500).ToString(3));
Console.WriteLine(BigReal.Truncate(new BigReal(1234500.678)).ToString(3));
Console.WriteLine(BigReal.ShiftLeft(new BigReal(1234500.678), numberBase: 10).ToString(3));
Console.WriteLine(default(BigReal) * 3);

Console.WriteLine(BigReal.Parse("nan"));
Console.WriteLine(new BigReal(23.4f));
Console.WriteLine(double.NegativeInfinity);
Console.WriteLine(double.Abs(double.NegativeInfinity));

Console.WriteLine(BigReal.Pow(10, -2));
Console.WriteLine(Math.Pow(10, -2));

Console.WriteLine(BigReal.Pow(4, -2));
Console.WriteLine(BigReal.Pow(-4, 2));
Console.WriteLine(BigReal.Sqrt(4));
Console.WriteLine(BigReal.Root(4, -1));