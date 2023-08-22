/*          Class: Soru

Object:Soru1  Object:Soru2  Object:Soru3..  Object

CevapKontrol  CevapKontrol  CevapKontrol    Metod instence

*/


using System;
using System.Diagnostics;
using Microsoft.VisualBasic;

namespace OOP 
{
        internal class Program
        {
            static void Main(string[] args)        
            {
            var SoruA=new Soru(){
                SoruMetni="Soru A", 
                Secenekler= new string [4] {"A","B","C","D"},         
                Cevap="A"                                              
                };

            var SoruB=new Soru(){
                SoruMetni="Soru B",
                Secenekler=new string[4] {"A","B","C","D"},
                Cevap="B"
            };

            var SoruC=new Soru(){
                SoruMetni="Soru C",
                Secenekler=new string [4] {"A","B","C","D"},
                Cevap="C"
            };  

            var SoruD=new Soru(){
                SoruMetni="Soru D",
                Secenekler=new string[4] {"A","B","C","D"},
                Cevap="D"
            };

            var sorular = new Soru[] {SoruA,SoruB,SoruC,SoruD};
            
            foreach(var i in sorular)
            {
                Console.WriteLine(i.SoruMetni);  //Sorulara ulaşmak için 
                    
                    foreach(var j in i.Secenekler){
                        
                        Console.WriteLine(j);
                    }

                    //Kullanıcıdan cevap alalım. 
                    Console.Write("Cevabınız");
                    var cevap= Console.ReadLine();
                    if(i.cevapKontrol(cevap)){
                        Console.WriteLine(" Doğru ");
                    }else{
                        Console.WriteLine(" Yanlış ");
                    }
            }

            }

            


        }

    
        class Soru
        
        {
           //Properties 
            public string SoruMetni { get; set; }
            public string[] Secenekler { get; set; }
            public string Cevap { get; set; }

            //Methods

            //cevapKontrol adında bool türünde bir metot tanımlıyorum. 
            //Buradaki (this).Cevap paratre ile gönderilen cevap eşitse değer gönderiyor. 
            public bool cevapKontrol(string cevap){
                return this.Cevap.ToLower()==cevap.ToLower();
            }

        }

}