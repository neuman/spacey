using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;
using Faker;

namespace CSharp_Shell
{
	public enum  Castes {
		Domain,
		Server,
		Site
	}
	public class Observable : Object {
    		public string Name;
    		public Observable Up;
    		public List<Observable> Down = new List<Observable>();
    		
    		public string GetUpName(){
    			if(Up != null){
    				return Up.GetUpName();
    			}else{
    				return "";
    			}
    		}
    	}
    	
    public class Universe: Observable {
    	public int Max = 10;
    	
    	public void Generate(){
    		foreach(Castes s in (Castes[])Enum.GetValues(typeof(Castes))){
    			Console.WriteLine(s);
    			for(int i=0; i<=Max;  i++){
    			Console.WriteLine(Faker.NameFaker.FirstName());
    			Console.WriteLine(StringFaker.SelectFrom(1,"abc"));
    			}
    		}

    	}
    }

    public static class Program 
    {
    	
        public static void Main() 
        {
        Universe u = new Universe();
        u.Generate();
        Observable a = new Observable();
       
        }
    }
}