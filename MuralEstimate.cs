using System;
using static System.Console;
using System.Globalization;

class Mural
{
    public double price;
    public string Name {get;set;}

    public char code
    {
        get{return this.code;}
        set{
            if (this.code == 'L' | this.code == 'S' | this.code == 'A' | this.code == 'C' | this.code == 'O')
                this.code = value;
            else
                this.code = 'I';
            }
    }
} //end mural class

class InteriorMural : Mural
{
    public int interiorNumber;
    public string name;
    public string interMural;

    //method to calc total rev 
    public double getRevenue(int c)
    {
        price = 0;
        switch(c)
        {
            case 1:
                price = interiorNumber * 500;
                WriteLine("$" + price + " for interior mural.");
                break;
            case 2:
                price = interiorNumber * 500;
                WriteLine("$" + price + " for interior mural.");
                break;
            case 3:
                price = interiorNumber * 500;
                WriteLine("$" + price + " for interior mural.");
                break;
            case 4:
                price = interiorNumber * 500;
                WriteLine("$" + price + " for interior mural.");
                break;
            case 5:
                price = interiorNumber * 500;
                WriteLine("$" + price + " for interior mural.");
                break;
            case 6:
                price = interiorNumber * 500;
                WriteLine("$" + price + " for interior mural.");
                break;
            case 7:
                price = interiorNumber * 450;
                WriteLine("$" + price + " for interior mural.");
                break;
            case 8:
                price = interiorNumber * 450;
                WriteLine("$" + price + " for interior mural.");
                break;
            case 9:
                price = interiorNumber * 500;
                WriteLine("$" + price + " for interior mural.");
                break;
            case 10:
                price = interiorNumber * 500;
                WriteLine("$" + price + " for interior mural.");
                break;
            case 11:
                price = interiorNumber * 500;
                WriteLine("$" + price + " for interior mural.");
                break;
            case 12:
                price = interiorNumber * 500;
                WriteLine("$" + price + " for interior mural.");
                break;
        }
        return price;
    }//end getRevenue

    public void getMural()
    {
        string str;
        WriteLine("Enter number of interior murals: ");
        str = ReadLine();

        if(int.TryParse(str, out interiorNumber))
        {
            interiorNumber = Convert.ToInt32(str);
            {
                if(interiorNumber > 0 && interiorNumber < 30)
                    WriteLine("It is a valid mural");
            }
        }
    }//end getMural

    public override string ToString()
    {
        return ("Interior mural " + name + " has code " + interMural);
    }    
}//end InteriorMural class

class ExteriorMural : Mural
{
    public int extNumber;
    public string name;
    public string extMural;

    //method to calc rev depending on month
    public int getRevenue(int c)
    {
        int muralCost = 0;
        switch (c)
        {
            case 1:
                muralCost = 250;
                WriteLine("$" + muralCost + " for exterior mural.");
                break;
            case 2:
                muralCost = 0;
                WriteLine("$" + muralCost + " for exterior mural.");
                break;
            case 3:
                muralCost = extNumber * 750;
                WriteLine("$" + muralCost + " for exterior mural.");
                break;
            case 4:
                muralCost = extNumber * 699;
                WriteLine("$" + muralCost + " for exterior mural.");
                break;
            case 5:
                muralCost = extNumber * 699;
                WriteLine("$" + muralCost + " for exterior mural.");
                break;
            case 6:
                muralCost = extNumber * 750;
                WriteLine("$" + muralCost + " for exterior mural.");
                break;
            case 7:
                muralCost = 0;
                WriteLine("$" + muralCost + " for exterior mural.");
                break;
            case 8:
                muralCost = extNumber * 750;
                WriteLine("$" + muralCost + " for exterior mural.");
                break;
            case 9:
                muralCost = extNumber * 699;
                WriteLine("$" + muralCost + " for exterior mural.");
                break;
            case 10:
                muralCost = extNumber * 699;
                WriteLine("$" + muralCost + " for exterior mural.");
                break;
            case 11:
                muralCost = extNumber * 750;
                WriteLine("$" + muralCost + " for exterior mural.");
                break;
            case 12:
                muralCost = 0;
                WriteLine("$" + muralCost + " for exterior mural.");
                break;
        }//end switch
        return muralCost;
    }//end getRevenue

    //get mural
    public void getMural()
    {
        string str;
        WriteLine("Enter number of exterior mural: ");
        str = ReadLine();

        if(int.TryParse(str, out extNumber))
        {
            extNumber = Convert.ToInt32(str);
            {
                if(extNumber > 0 && extNumber < 30)
                {
                    WriteLine("Is a valid mural.");
                }
            }
        }
    }//end getMural

    public override string ToString()
    {
        return ("Exterior Mural " + name + " has code "+ extMural);
    }
}//end class ExteriorMural

//begin class with Main
class MarshallsRevenue
{
    int totalRevenue;
    int tempo;

    public bool getMonth()
    {
        string locmonth;
        int dummy;
        WriteLine("Enter month: ");
        locmonth = ReadLine();

        if(int.TryParse(locmonth, out dummy))
        {
            dummy = Convert.ToInt32(locmonth);
            if(dummy > 0 & dummy < 13)
            {
                WriteLine("Valid month.");
                return true;
            }
        }
            return false;
    }//end getMonth

    static void Main(string[] args)
    {
        string category;
        MarshallsRevenue obj = new MarshallsRevenue();
        InteriorMural interM = new InteriorMural();
        ExteriorMural exterM = new ExteriorMural();

        //run loop until valid month is obtained
        while (!obj.getMonth())
        {
            WriteLine("Invalid month.");
        }
            
        WriteLine("Calling method for interior mural. ");
        interM.getMural();
        WriteLine("Calling method for exterior mural. ");
        exterM.getMural();

        if(interM.interiorNumber > exterM.extNumber)
            obj.temporary = interM.interiorNumber;
        else
            obj.temporary = exterM.extNumber;
            
        WriteLine("The valid mural codes are L, S, A, C, and O\n");
        int i;
        InteriorMural[] intArr = new InteriorMural[interM.interiorNumber];

        //get customer names along with exterior mural codes
        for(i = 0; i < interM.interiorNumber; i++)
        {
            intArr[i] = new InteriorMural();
            WriteLine("Interior Mural number " + (i+1));
            WriteLine("Name: ");
            intArr[i].name = ReadLine();
            WriteLine("Code: ");
            intArr[i].interMural = ReadLine();
            intArr[i].interiorNumber = interM.interiorNumber;
        }

        //get customer names along with interior mural codes
        ExteriorMural[] extArr = new ExteriorMural[exterM.extNumber];

        for(i = 0; i < exterM.extNumber; i++)
        {
            extArr[i] = new ExteriorMural();
            WriteLine("Exterior Mural number " + (i+1));
            WriteLine("Name: ");
            extArr[i].name = ReadLine();
            WriteLine("Code: ");
            extArr[i].extMural = ReadLine();
            extArr[i].extNumber = exterM.extNumber;
        }
    
        obj.totalRevenue = (int)(interM.getRevenue(obj.temporary) + exterM.getRevenue(obj.temporary));
        WriteLine("Total revenue is: " + obj.totalRevenue + "\n");
            
        int loop = 0;
        do
        {
            WriteLine("Enter category: ");
            category = ReadLine();
            loop = 0;

            switch(category)
            {
                case "L":
                    for (i=0; i < obj.temporary; i++)
                    {
                        if(intArr[i].interMural == "L")
                            WriteLine(intArr[i].ToString());
                        if(extArr[i].extMural == "L")
                            WriteLine(extArr[i].ToString());
                    }
                    break;

                case "S":
                    for (i=0; i < obj.temporary; i++)
                    {
                        if(intArr[i].interMural == "S")
                            WriteLine(intArr[i].ToString());
                        if(extArr[i].extMural == "S")
                            WriteLine(extArr[i].ToString());
                    }
                    break;
            
                case "A":
                    for (i=0; i < obj.tempo; i++)
                    {
                        if(intArr[i].interMural == "A")
                            WriteLine(intArr[i].ToString());
                        if(extArr[i].extMural == "A")
                            WriteLine(extArr[i].ToString());
                    }
                    break;
    
                case "C":
                    for (i=0; i < obj.tempo; i++)
                    {
                        if(intArr[i].interMural == "C")
                            WriteLine(intArr[i].ToString());
                        if(extArr[i].extMural == "C")
                            WriteLine(extArr[i].ToString());                        }
                    break;
                    
                case "O":
                    for (i=0; i < obj.tempo; i++)
                    {
                        if(intArr[i].interMural == "O")
                            WriteLine(intArr[i].ToString());
                        if(extArr[i].extMural == "O")
                            WriteLine(extArr[i].ToString());
                    }
                    break;
            
                default:
                    WriteLine("Invalid choice.");
                    loop = 1;
                    break;
                }//end switch
        }
        while (loop == 1);
        ReadLine();
    }
}//end MarshallsRevenue class

