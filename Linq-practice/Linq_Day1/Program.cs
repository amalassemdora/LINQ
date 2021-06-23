using System;
using System.Collections.Generic;
using System.Linq;

namespace Linq_Day1
{
	class Program
	{
		class Subject
		{
			public int Code { get; set; }
			public string Name { get; set; }
		}
		class Student
		{
			public int ID { get; set; }
			public String FirstName { get; set; }
			public String LastName { get; set; }
			public Subject []subjects { get; set; }

			public override string ToString()
			{
				return $"< FullName = {FirstName} {LastName} ,NoOfSubjects = {subjects.Length} >";
			}

		}

		static void Main(string[] args)
		{
			List<int> numbers = new List<int>() { 2, 4, 6, 7, 1, 4, 2, 9, 1 };
			//***************1**********************//
			Console.WriteLine("*****************1*******************");
			var q1 = numbers.Distinct();
			var q2 = from n in q1
					 orderby n
					 select n;
			foreach (var item in q2)
			{
				Console.WriteLine(item);
			}
			//***************2**********************//
			Console.WriteLine("*****************2********************");
			var q = q2.Select(n => new { Number = n, Multiply = n * n });
			foreach (var item in q)
			{
				Console.WriteLine(item);
			}

			//***************3**********************//
			Console.WriteLine("*****************3********************");
			string[] names = { "Tom", "Dick", "Harry", "MARY", "Jay" };
			//USING Query Expression 
			Console.WriteLine("Query Expression");

			var q3 = from name in names
					 where name.Length == 3
					 select name;
			foreach (var item in q3)
			{
				Console.WriteLine(item);
			}
			//method Expression
			Console.WriteLine("method Expression");

			var q4 = names.Where(name => name.Length == 3);
			foreach (var item in q4)
			{
				Console.WriteLine(item);
			}
			Console.WriteLine("*************3-2************");
			//USING Query Expression 
			Console.WriteLine("Query Expression");
			var q5 = from name in names
					 where name.Contains("a") || name.Contains("A")
					 orderby name.Length
					 select name;
			foreach (var item in q5)
			{
				Console.WriteLine(item);
			}
			//method Expression
			Console.WriteLine("method Expression");

			var q6 = names.Where(name => name.Contains("a") || name.Contains("A")).OrderBy(name => name.Length);
			foreach (var item in q6)
			{
				Console.WriteLine(item);
			}
			Console.WriteLine("*************3-3************");

			//USING Query Expression 
			Console.WriteLine("Query Expression");
			var q7 = from name in names.Take(2)
					 select name;
			foreach (var item in q7)
			{
				Console.WriteLine(item);
			}
			//method Expression
			Console.WriteLine("method Expression");
			var q8 = names.Take(2);
			foreach (var item in q8)
			{
				Console.WriteLine(item);
			}

			//***************4**********************//
			Console.WriteLine("*****************4*******************");
			List<Student> students = new List<Student>()
			{
				new Student(){ ID=1, FirstName="Ali", LastName="Mohammed",
				subjects=new Subject[]{ new Subject(){ Code=22,Name="EF"},
				new Subject(){Code=33,Name="UML"}}},
				
				new Student(){ ID=2, FirstName="Mona", LastName="Gala",
				subjects=new Subject []{ new Subject(){ Code=22,Name="EF"},
				new Subject (){Code=34,Name="XML"},new Subject (){ Code=25, Name="JS"}}}, 

				new Student(){ ID=3, FirstName="Yara", LastName="Yousf", subjects=new Subject
				[]{ new Subject (){ Code=22,Name="EF"}, new Subject (){
				Code=25,Name="JS"}}},

				 new Student(){ ID=1, FirstName="Ali", LastName="Ali",
				 subjects=new Subject []{ new Subject (){ Code=33,Name="UML"}}},

            };
			var q9 = students.Select(st => new { FullName = st.FirstName + " " + st.LastName , NoOfSubjects =st.subjects.Length}); ;
			foreach (var item in q9)
			{
				Console.WriteLine(item);
			}
			Console.WriteLine("*************4-2************");

			var q10 = students.OrderByDescending(st => st.FirstName).ThenBy(st => st.LastName).Select( st =>new { FullName = st.FirstName + " " + st.LastName });
			foreach (var item in q10)
			{
				Console.WriteLine(item.FullName);
			}
			Console.WriteLine("*************4-3************");

			var q11 = students.SelectMany(st => st.subjects, (parent, child) => new { FullName = parent.FirstName + " " +parent.LastName, SubjectName = child.Name });
			foreach (var item in q11)
			{
				Console.WriteLine(item);
			}
			Console.WriteLine("*************4-4************");

			
			var q12 = q11.GroupBy(st => st.FullName);
			foreach(var item in q12)
			{
				Console.WriteLine(item.Key);
				foreach(var c in item)
				Console.WriteLine($"    {c.SubjectName}");
			}
			Console.ReadKey();
		}
	}
}
