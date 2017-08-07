using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VigneroRectangleExceptions
{
    class AreaConverter : System.Windows.Forms.Label
    {
        //declaring variables
        private double area;
        private double perimeter;
        private string choice;
        double areaConvert;
        double perimeterConvert;
      //default constructor
        public AreaConverter()
        {
            
        }
        //method to get the area
        //this will check what conversion is needed 
        //then the values that are calculated is stored and retrieved by the main form class
        //each conersion is different so this will allow the user to calculate an accurate amount depending on the choices they choose
        public double getArea()
        {
            if (choice.Equals("inTOcm"))
            {
                areaConvert = area * 2.54;
            
            }
            else if (choice.Equals("inTOft"))
            {
                areaConvert = area * 0.083333;
              
            }
            else if (choice.Equals("inTOm"))
            {
                areaConvert = area / 39.370;
                
            }


            if (choice.Equals("ftTOin"))
            {
                areaConvert = area * 12;
               
            }
            else if (choice.Equals("ftTOcm"))
            {
                areaConvert = area / 0.032808;
                
            }
            else if (choice.Equals("ftTOm"))
            {
                areaConvert = area / 3.2808;
                
            }


            if (choice.Equals("cmTOin"))
            {
                areaConvert = area * 0.39370;
             
            }
            else if (choice.Equals("cmTOft"))
            {
                areaConvert = area * 0.032808;
               
            }
            else if (choice.Equals("cmTOm"))
            {
                areaConvert = area / 100.00;
              
            }
       


            if (choice.Equals("mTOin"))
            {
                areaConvert = area * 39.370;
               
            }
            else if (choice.Equals("mTOft"))
            {
                areaConvert = area * 3.2808;
             
            }
            else if (choice.Equals("mTOcm"))
            {

                areaConvert = area / 0.010000;
               
            }
            return areaConvert;
        }
        //method to get the perimeter
        //this will check what conversion is needed 
        //then the values that are calculated is stored and retrieved by the main form class
        //each conersion is different so this will allow the user to calculate an accurate amount depending on the choices they choose
        public double getPerimeter()
        {
            if (choice.Equals("inTOcm"))
            {
           
                perimeterConvert = perimeter * 2.54;
            }
            else if (choice.Equals("inTOft"))
            {
             
                perimeterConvert = perimeter * 0.083333;
            }
            else if (choice.Equals("inTOm"))
            { 
                perimeterConvert = perimeter / 39.370;
            }


            if (choice.Equals("ftTOin"))
            {
              
                perimeterConvert = perimeter * 12;
            }
            else if (choice.Equals("ftTOcm"))
            {
              
                perimeterConvert = perimeter / 0.032808;
            }
            else if (choice.Equals("ftTOm"))
            {
                
                perimeterConvert = perimeter / 3.2808;
            }


            if (choice.Equals("cmTOin"))
            {
               
                perimeterConvert = perimeter * 0.39370;
            }
            else if (choice.Equals("cmTOft"))
            {
               
                perimeterConvert = perimeter * 0.032808;
            }
            else if (choice.Equals("cmTOm"))
            {
              
                perimeterConvert = perimeter / 100.00;
            }



            if (choice.Equals("mTOin"))
            {
               
                perimeterConvert = perimeter * 39.370;
            }
            else if (choice.Equals("mTOft"))
            {
               
                perimeterConvert = perimeter * 3.2808;
            }
            else if (choice.Equals("mTOcm"))
            {

              
                perimeterConvert = perimeter / 0.010000;
            }
            return perimeterConvert;
        }
        //setter for setting values to variables
        public void setArea(double area)
        {
            this.area = area;
        }
        public void setPerimeter(double perimeter)
        {
            this.perimeter = perimeter;
        }
        public void setchoice(string choice)
        {
            this.choice = choice;
        }
        
    }
}
