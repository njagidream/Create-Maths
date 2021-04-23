using System;
namespace createmaths{
//A program that generates maths myultiplication problems for your school kids
// Writen by Gitonga Njagi  
//Date : 23 April 2021

public class implement{
 static void Main(string []args ){
for (int i=0; i<9; i++){
Console.WriteLine("Round {0}",i);
Genmaths sent1=new Genmaths ();
sent1.display();
Genmaths sent2=new Genmaths ();
sent2.display();
Genmaths sent3=new Genmaths ();
sent3.display();
Genmaths sent4=new Genmaths ();
sent4.display();
  }
 }
}

	
public class Genmaths{

static Random rnd = new Random();
 int sel1  = rnd.Next(1, 10);  // creates a number between 1 and 9
 int sel2  = rnd.Next(5, 10);  // creates a number between 1 and 9
 int sel3  = rnd.Next(1, 10);  // creates a number between 1 and 9
 int sel4  = rnd.Next(5, 10);  // creates a number between 1 and 9

public void display(){

int [] part1={sel1,sel2};
int [] part2={sel3,sel4};
string  n1=part1[0]+""+ part1[1];
string n2=part2[0] +""+ part2[1];
Console.Write("{0} X {1}",n1,n2);
int answ=int.Parse(n1)*int.Parse(n2);
Console.WriteLine("="+answ);
  }

 }
 
}//namespace