/* Rectangle Exceptions
 * David Vignero
 * POS/409
 * John Becton
 * 3/20/2017
 */


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Windows.Forms;

namespace VigneroRectangleExceptions
{
    public partial class RectangleAreaCalc : Form
    {
        bool isNumericLength;
        bool isNumericWidth;
        double length;
        double width;
        double area;
        double perimeter;
        string choice;
       
        public RectangleAreaCalc()
        {
            InitializeComponent();
            gbConvert.Visible = false;
           
            
            
        }
        //handle convert button
        private void btnConvert_Click(object sender, EventArgs e)
        {
            //checks if values ccan be parsed
            isNumericLength = double.TryParse(txtLength.Text, out length);
            isNumericWidth = double.TryParse(txtWidth.Text, out width);
            try
            {
                area = length * width;
                perimeter = 2*(length + width);
                //validates proper format
                if (isNumericLength && isNumericWidth && length > 0 && width > 0)
                {
                    //validates if option is checked
                    if (rbInchesConvert.Checked || rbCentimetersConvert.Checked || rbFeetConvert.Checked || rbMetersConvert.Checked)
                    {
                        convertCurrentMeasuermentCheck();
                    }

                    else
                    {
                        //throws exception message
                        throw (new Exception("Select an option to convert"));

                    }
                }
                else
                {
                    //throws format exception
                    throw (new FormatException("Length and Width must be numeric and greater than 0"));

                }
            }
            //handles exceptions
            
            catch (FormatException ed)
            {
                MessageBox.Show(ed.Message);
            }
            catch (Exception r)
            {
                MessageBox.Show(r.Message);
            }

            
            
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            //trying to parse values entered
            isNumericLength = double.TryParse(txtLength.Text, out length);
            isNumericWidth = double.TryParse(txtWidth.Text, out width);
            
            try
            {
                
              //executes if the entered values are parsable and over 0
                if (isNumericLength && isNumericWidth && length > 0 && width > 0)
                {
                    //each of these statements calculate area and perimeter depending on the radio button that is selected
                    if (rbInches.Checked)
                    {
                        AreaConverter converter = new AreaConverter();
                        area = (length * width);
                        perimeter = 2 * (length + width);
                          converter.setArea(area);
                          converter.setPerimeter(perimeter);
                        lblPerimeter.Text = perimeter.ToString("#.## in.");
                        
                        lblArea.Text = area.ToString("#.## in.²");
                       
                        rbFeetConvert.Enabled = true;
                        rbInchesConvert.Enabled = false;
                        rbMetersConvert.Enabled = true;
                        rbCentimetersConvert.Enabled = true;
                    }
                    else if (rbFeet.Checked)
                    {
                        AreaConverter converter = new AreaConverter();
                        area = (length * width);
                        perimeter = 2 * (length + width);
                          converter.setArea(area);
                          converter.setPerimeter(perimeter);
                        lblPerimeter.Text = perimeter.ToString("#.## ft.");
                        
                        lblArea.Text = area.ToString("#.## ft.²");
                  
                        rbFeetConvert.Enabled = false;
                        rbInchesConvert.Enabled = true;
                        rbMetersConvert.Enabled = true;
                        rbCentimetersConvert.Enabled = true;
                    }
                    else if (rbCentimeters.Checked)
                    {
                        AreaConverter converter = new AreaConverter();
                        area = (length * width);
                        perimeter = 2*(length + width);
                        converter.setArea(area);
                        converter.setPerimeter(perimeter);
                        lblPerimeter.Text = perimeter.ToString("#.## cm.");
                 
                        lblArea.Text = area.ToString("#.## cm.²");
                      
                        rbFeetConvert.Enabled = true;
                        rbInchesConvert.Enabled = true;
                        rbMetersConvert.Enabled = true;
                        rbCentimetersConvert.Enabled = false;
                    }
                    else if (rbMeters.Checked)
                    {
                        AreaConverter converter = new AreaConverter();
                        area = (length * width);
                        perimeter = 2 * (length + width);
                         converter.setArea(area);
                         converter.setPerimeter(perimeter);
                        lblPerimeter.Text = perimeter.ToString("#.## m.");
                     
                        lblArea.Text = area.ToString("#.## m.²");
                   
                        rbFeetConvert.Enabled = true;
                        rbInchesConvert.Enabled = true;
                        rbMetersConvert.Enabled = false;
                        rbCentimetersConvert.Enabled = true;
                    }
                    gbConvert.Visible = true;
                }
                else if(!(isNumericLength)&&!(isNumericWidth))
                {
                    //throws a format exception
                    throw (new FormatException("Please enter a numeric value"));
                }else if(length <= 0 || width <= 0)
                {
                    //throws a format exception
                    throw (new FormatException("Please enter a value greater than 0"));
                }
            }
            catch(FormatException i)
            {
                MessageBox.Show(i.Message);
            }
        }
        //button to resets values to default
        private void btnClear_Click(object sender, EventArgs e)
        {
            lblArea.ResetText();
            lblPerimeter.ResetText();
            txtLength.ResetText();
            txtWidth.ResetText();
            gbConvert.Visible = false;
            rbInches.Checked = true;
        }
        public void convertCurrentMeasuermentCheck()
        {
            //setting the area and perimeter for converting the measurement
            AreaConverter converter = new AreaConverter();
            converter.setArea(area);
            converter.setPerimeter(perimeter);
            //converting centimeters to other measurements using getters and setters from converter class
            if (rbCentimeters.Checked)
            {
                if(rbInchesConvert.Checked)
                 {
                 
                    choice = "cmTOin";
                    converter.setchoice(choice);
               
                    lblArea.Text = converter.getArea().ToString("#.## in.²");
                    lblPerimeter.Text = converter.getPerimeter().ToString("#.## in.");
                }
                 else if (rbFeetConvert.Checked)
                {
               
                    choice ="cmTOft";
                    converter.setchoice(choice);
                    
                    lblArea.Text = converter.getArea().ToString("#.## ft.²");
                    lblPerimeter.Text = converter.getPerimeter().ToString("#.## ft.");
                }
                else if (rbMetersConvert.Checked)
                {
                   
                    choice ="cmTOm";
                    converter.setchoice(choice);
                  
                    lblArea.Text = converter.getArea().ToString("#.## m.²");
                    lblPerimeter.Text = converter.getPerimeter().ToString("#.## m.");
                }
            }
            //converting inches to other measurements using getters and setters from the covnerter class
             if (rbInches.Checked)
            {
                if (rbCentimetersConvert.Checked)
                {
               
                    choice = "inTOcm";

                    converter.setchoice(choice);
                
                    lblArea.Text = converter.getArea().ToString("#.## cm.²");
                    lblPerimeter.Text = converter.getPerimeter().ToString("#.## cm.");
                }
                else if (rbFeetConvert.Checked)
                {
                 
                    choice = "inTOft";
                    converter.setchoice(choice);
                   
                    lblArea.Text = converter.getArea().ToString("#.## ft.²");
                    lblPerimeter.Text = converter.getPerimeter().ToString("#.## ft.");
                }
                else if (rbMetersConvert.Checked)
                {
                   
                    choice = "inTOm";
                    converter.setchoice(choice);
          
                    lblArea.Text = converter.getArea().ToString("#.## m.²");
                    lblPerimeter.Text = converter.getPerimeter().ToString("#.## m.");
                }
            }
             //convert feet to other measurements using getters and setters from converter class
            if (rbFeet.Checked)
            {
                if (rbCentimetersConvert.Checked)
                {
                   
                    choice = "ftTOcm";
                    converter.setchoice(choice);
                    
                    lblArea.Text = converter.getArea().ToString("#.## cm.²");
                    lblPerimeter.Text = converter.getPerimeter().ToString("#.## cm.");
                }
                else if (rbInchesConvert.Checked)
                {
                   
                    choice = "ftTOin";
                    converter.setchoice(choice);
                
                    lblArea.Text = converter.getArea().ToString("#.## in.²");
                    lblPerimeter.Text = converter.getPerimeter().ToString("#.## in.");
                }
                else if (rbMetersConvert.Checked)
                {
                   
                    choice = "ftTOm";
                    converter.setchoice(choice);
                  
                    lblArea.Text = converter.getArea().ToString("#.## m.²");
                    lblPerimeter.Text = converter.getPerimeter().ToString("#.## m.");
                }
            }
            //convert meters to other measurements using getters and setters from converter class
            if (rbMeters.Checked)
            {
                if (rbCentimetersConvert.Checked)
                {
                   
                    choice = "mTOcm";
                    converter.setchoice(choice);
                 
                    lblArea.Text = converter.getArea().ToString("#.## cm.²");
                    lblPerimeter.Text = converter.getPerimeter().ToString("#.## cm.");
                }
                else if (rbFeetConvert.Checked)
                {
                   
                    choice = "mTOft";
                    converter.setchoice(choice);
                 
                    lblArea.Text = converter.getArea().ToString("#.## ft.²");
                    lblPerimeter.Text = converter.getPerimeter().ToString("#.## ft.");
                }
                else if (rbInchesConvert.Checked)
                {
                   
                    choice = "mTOin";
                    converter.setchoice(choice);
                   
                    lblArea.Text = converter.getArea().ToString("#.## in.²");
                    lblPerimeter.Text = converter.getPerimeter().ToString("#.## in.");
                }
            }
      
        }
        //enabling radio buttons depending on which one is selected
        private void rbInches_CheckedChanged(object sender, EventArgs e)
        {
           
            rbFeetConvert.Enabled = true;
            rbInchesConvert.Enabled = false;
            rbMetersConvert.Enabled = true;
            rbCentimetersConvert.Enabled = true;
        }

        private void rbFeet_CheckedChanged(object sender, EventArgs e)
        {
           
            rbFeetConvert.Enabled = false;
            rbInchesConvert.Enabled = true;
            rbMetersConvert.Enabled = true;
            rbCentimetersConvert.Enabled = true;
        }

        private void rbMeters_CheckedChanged(object sender, EventArgs e)
        {
          
            rbFeetConvert.Enabled = true;
            rbInchesConvert.Enabled = true;
            rbMetersConvert.Enabled = false;
            rbCentimetersConvert.Enabled = true;
        }

        private void rbCentimeters_CheckedChanged(object sender, EventArgs e)
        {
        
            rbFeetConvert.Enabled = true;
            rbInchesConvert.Enabled = true;
            rbMetersConvert.Enabled = true;
            rbCentimetersConvert.Enabled = false;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
            
        }
    }
    }

