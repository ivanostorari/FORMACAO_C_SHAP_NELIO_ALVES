﻿using System;
using System.IO;

namespace Projeto_Xadrez_Curso_Nelio_Aula2000
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Users\ivan.ostorari\Desktop\C# COMPLETO PROGRAMAÇÃO ORIENTADO A OBJETOS + PROJETOS NÉLIO ALVES\PROJETOS\Projetos\Projeto_Xadrez_Curso_Nelio_Aula200.0\temp\myfolder";

            Console.WriteLine("DirectorySeparatorChar: " + Path.DirectorySeparatorChar);
            Console.WriteLine("PathSeparator: " + Path.PathSeparator);
            Console.WriteLine("GetDirectoryName: " + Path.GetDirectoryName(path));
            Console.WriteLine("GetFileName" + Path.GetFileName(path));
        }
    }
}
