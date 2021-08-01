using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaAlunoCorrigidoExercicio
{
    class Program
    {
        static void Main(string[] args)
        {
            string aluno, aluno1, aluno2, aluno3;

            Console.WriteLine("Seja bem vindo.Aqui iremos calcula media aritmetrica entre alunos" +
           "curso de matemática \n");
            Console.WriteLine(" Alunos Matriculados em Licenciatura em Matemática  ano 2021 \n");

            Console.WriteLine("Digite o nome do 1° aluno:\n");
            aluno = Console.ReadLine();
            Console.WriteLine("Digite nota 1 aluno:\n");
            double primeiraNota1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine("Digite nota 2 aluno :\n");
            double segundaNota2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine("Digite nota 3 aluno :\n");
            double terceiraNota3 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine();
            double soma = primeiraNota1 + segundaNota2 + terceiraNota3;
            Console.WriteLine("soma das notas " + soma);
            double media = soma / 3;
            Console.WriteLine(aluno + " media de " + media);
            Console.WriteLine();
           
            Console.WriteLine("Digite o nome do 2° aluno:\n ");
            aluno1 = Console.ReadLine();
            Console.WriteLine("Digite nota 1 aluno:\n");
            double primeiraNota4 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine("Digite nota 2 aluno :\n");
            double segundaNota5 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine("Digite nota 3 aluno  :\n");
            double terceiraNota6 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine();
            double soma1 = primeiraNota4 + segundaNota5 + terceiraNota6;
            Console.WriteLine("soma das notas " + soma1);
            double media1 = soma1 / 3;
            Console.WriteLine(aluno1 + " media de " + media + media1);
            Console.WriteLine();
            
            Console.WriteLine("Digite o nome do 3° aluno:\n ");
            aluno1 = Console.ReadLine();
            Console.WriteLine("Digite nota 1 aluno:\n");
            double primeiraNota7 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine("Digite nota 2 aluno :\n");
            double segundaNota8 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine("Digite nota 3 aluno  :\n");
            double terceiraNota9 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine();
            double soma2 = primeiraNota7 + segundaNota8 + terceiraNota9;
            Console.WriteLine("soma das notas " + soma2);
            double media2 = soma2 / 3;
            Console.WriteLine(aluno1 + " media de "  + media2);
            Console.WriteLine();
            

            Console.WriteLine("Digite o nome do 3° aluno:\n ");
            aluno2 = Console.ReadLine();
            Console.WriteLine("Digite nota 1 aluno:\n");
            double primeiraNota10 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine("Digite nota 2 aluno :\n");
            double segundaNota11 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine("Digite nota 3 aluno  :\n");
            double terceiraNota12 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine();
            double soma3 = primeiraNota10 + segundaNota11 + terceiraNota12;
            Console.WriteLine("soma das notas " + soma3);
            double media3 = soma3 / 3;
            Console.WriteLine(aluno2 + " media de " + media3);
            Console.WriteLine();

            Console.WriteLine("Digite o nome do 4° aluno:\n ");
            aluno3 = Console.ReadLine();
            Console.WriteLine("Digite nota 1 aluno:\n");
            double primeiraNota11 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine("Digite nota 2 aluno :\n");
            double segundaNota12 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine("Digite nota 3 aluno  :\n");
            double terceiraNota13 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine();
            double soma4 = primeiraNota10 + segundaNota11 + terceiraNota12;
            Console.WriteLine("soma das notas " + soma4);
            double media4 = soma4 / 3;
            Console.WriteLine(aluno3 + " media de " + media4);
            Console.WriteLine();
            Console.ReadKey();




        }
    }
}
