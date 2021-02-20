/*'~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
' Comments by the prof:
'
'~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
' Project #1 -- Regular Polygons
' Created by Laura Waite
' Date: 10/13/2020
' Project Name: Regular Polygons
' Class: CS 218
' Time: 15 hours 18 minutes
' Platform: PC, Windows 10, VS 2017
'~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
' This program calculates attributes of a user-defined regular polygon. 
' User inputs number of sides (n) as a whole number between 3 and 1,000,000 and 
' the length of the sides (s) as a number greater than 0 and less than 1,000,000.
' From these values the program calculates the polygon's interior angle, circumradius, 
' apothem, perimeter, area, central angle, and number of distinct diagonals. 
' It also calculates the area and circumference of the polygon's circumcircle and the 
' error percentage for approximating these values by the area and perimeter of the polygon.
' Users can also print the GUI using the Print button, and for polygons with 100 or fewer sides 
' users may choose to graph a representation of the polygon based on number of sides.
'~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
' Comments by the student:
' Non-standard variable naming conventions used to preserve mathematical formulae
' Icon file © 2020 icon-icons.com
' Logo file © 2020 Laura Waite - created in Adobe Illustrator CS5
' 
' DrawPoly function reference material:
' Method: https://docs.microsoft.com/en-us/dotnet/api/system.drawing.graphics.drawpolygon
' Math: https://stackoverflow.com/questions/3436453/calculate-coordinates-of-a-regular-polygons-vertices
' 
' Extra credit questions:
' (1) How many sides must the polygon have in order for the perimeter error to less than 0.0000001%?
' 4056 sides is the minimum number of sides required for a perimeter error of less than 0.0000001%, 
' with an error percentage of 0.0000000999890826258024759109%.
' (2) Does the length of the sides affect the error (why or why not)?
' No, the length of the sides only affects the size of the two shapes, not their relationship to each other.
'~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~*/
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Project1_RegularPolygons
{

    /*~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
    ' Name:             Regular Polygons : Form
    ' Description:
    ' 
    ' Class for Regular Polygons Form application. Contains global variables.
    ' 
    ' Date:             10/13/2018
    ' Author:           Laura Waite
    ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~*/
    public partial class RegularPolygons : Form
    {
        // Declare class variables
        // Number of sides n
        int n;

        //Length of sides s
        double s;

        // Circumradius R, apothem a, perimeter P, area A
        decimal R, a, P, A;

        // Circumference of circumcircle, area of circumcircle
        decimal decCircCirc, decAreaCirc;

        // Bitmap for printing GUI
        Bitmap memoryImage;


        /*~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        ' Name:             RegularPolygons()
        ' Description:
        ' 
        ' Method for the GUI creation.
        ' Also calls SplashScreen, sets title to application run date, and sets
        ' default index for combobox control.
        ' 
        ' Date:             10/13/2018
        ' Author:           Laura Waite
        ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~*/
        public RegularPolygons()
        {
            // Show splash screen
            (new SplashScreen()).ShowDialog();

            // Initialize form
            InitializeComponent();

            // Set title to include current date
            DateTime todaysDate = DateTime.Today;
            this.Text = "Regular Polygons -- " + todaysDate.ToString("d");

            // Set default index for combobox
            cboPrecision.SelectedIndex = 0;
        }


        /*~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        ' Name:             btnCalculate_Click()
        ' Description:
        ' 
        ' Event handler for the GUI button 'Calculate'. Validates user
        ' inputs within given range and to specified numeric formats or shows
        ' error if input is invalid. Calls 11 different methods for mathematical 
        ' calculations. Also controls whether the Draw GUI button is enabled and 
        ' sets/returns the logo image to avoid confusion after the application has 
        ' drawn a user defined polygon.
        ' 
        ' Parameter:        object sender
        ' Parameter:        EventArgs e
        ' Return:           void
        ' Date:             10/13/2018
        ' Author:           Laura Waite
        ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~*/
        private void btnCalculate_Click(object sender, EventArgs e)
        {
            // Validate inputs
            try
            {
                // Check for valid number of sides
                n = int.Parse(txtNumberSides.Text);

                // Check for sides input in range
                if (n >= 3 && n <= 1000000)
                {

                    try
                    {
                        // Check for valid length
                        s = double.Parse(txtLengthSides.Text);

                        // Check for length input in range
                        if (s > 0 && s <= 1000000)
                        {
                            // Call calculations methods

                            // Interior angle
                            InteriorAngle(n);

                            // Circumradius
                            Circumradius(n, s, ref R);

                            // Apothem
                            Apothem(n, R, ref a);

                            // Perimeter
                            Perimeter(n, s, ref P);

                            // Area
                            Area(a, P, ref A);

                            // Circumference of circumcircle
                            CircumcircleCircumference(R, ref decCircCirc);

                            // Area of circumcircle
                            CircumcircleArea(R, ref decAreaCirc);

                            // Error in perimeter
                            PerimeterError(P, decCircCirc);

                            // Error in area
                            AreaError(A, decAreaCirc);

                            // Central angle
                            CentralAngle(n);

                            // Distinct Diagonals
                            DistinctDiagonals(n);

                            // If sides n <= 100, enable Draw button and set focus
                            if (n <= 100)
                            {
                                btnDraw.Enabled = true;
                                btnDraw.Focus();
                            }
                            else
                            {
                                // Draw button is hidden/remains hidden
                                btnDraw.Enabled = false;

                                // Focus set to first input, text highlighted for next entry
                                txtNumberSides.Focus();
                                txtNumberSides.SelectAll();
                            }
                            // Logo image is shown/remains visible
                            picPoly.Visible = true;

                        }
                        else
                        {
                            // Show error for length of sides out of range
                            MessageBox.Show("Please enter a number greater than 0 and less than 1,000,000.", "Error! Out of Range", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                            // Set focus on length textbox and highlight
                            txtLengthSides.Focus();
                            txtLengthSides.SelectAll();
                        }
                    }
                    catch
                    {
                        // Show error for non-decimal input for length of sides
                        MessageBox.Show("Please enter numbers only.", "Error! Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                        // Set focus on length textbox and highlight
                        txtLengthSides.Focus();
                        txtLengthSides.SelectAll();
                    }
                }
                else
                {
                    // Show error for number of sides out of range
                    MessageBox.Show("Please enter a whole number between 3 and 1,000,000.", "Error! Out of Range", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                    // Set focus to sides textbox and highlight
                    txtNumberSides.Focus();
                    txtNumberSides.SelectAll();
                }
            }
            catch
            {
                // Show error for non-integer input for number of sides
                MessageBox.Show("Please enter whole numbers only.", "Error! Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                // Set focus to sides textbox and highlight
                txtNumberSides.Focus();
                txtNumberSides.SelectAll();
            }
        }


        /*~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        ' Name:             InteriorAngle()
        ' Description:
        ' 
        ' Method that calculates the interior angle (in radians, represented
        ' in degrees) of the user defined polygon.
        ' 
        ' Parameter:        int n
        ' Return:           void
        ' Date:             10/13/2020
        ' Author:           Laura Waite
        ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~*/
        private void InteriorAngle(int n)
        {
            // Declare variables
            decimal decAngle;
            const decimal TRIANGLE_SUM_ANGLE = 180.0m;

            // Calculate degree of interior angle of polygon
            decAngle = (n - 2) * (TRIANGLE_SUM_ANGLE / n);

            // Display result in read-only textbox with unicode degree symbol based on selected precision
            if (cboPrecision.SelectedIndex == 0)
            {
                txtIntAngle.Text = decAngle.ToString() + "\u00B0";
            }
            else
            {
                txtIntAngle.Text = decAngle.ToString("n" + cboPrecision.SelectedIndex.ToString()) + "\u00B0";
            }
        }

        /*~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        ' Name:             Circumradius()
        ' Description:
        ' 
        ' Method that calculates the circumradius of the user defined polygon.
        ' 
        ' Parameter:        int n
        ' Parameter:        double s
        ' Parameter:        decimal R (by reference)
        ' Return:           void
        ' Date:             10/13/2020
        ' Author:           Laura Waite
        ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~*/
        private void Circumradius(int n, double s, ref decimal R)
        {
            // Calculate circumradius
            R = (decimal)(s / (2 * Math.Sin(Math.PI / n)));

            // Display result in read-only textbox based on selected precision
            if (cboPrecision.SelectedIndex == 0)
            {
                txtCircumradius.Text = R.ToString();
            }
            else
            {
                txtCircumradius.Text = R.ToString("n" + cboPrecision.SelectedIndex.ToString());
            }
        }

        /*~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        ' Name:             Apothem()
        ' Description:
        ' 
        ' Method that calculates the apothem of the user defined polygon.
        ' 
        ' Parameter:        int n
        ' Parameter:        decimal R
        ' Parameter:        decimal a (by reference)
        ' Return:           void
        ' Date:             10/13/2020
        ' Author:           Laura Waite
        ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~*/
        private void Apothem(int n, decimal R, ref decimal a)
        {
            // Calculcate apothem
            a = R * (decimal)Math.Cos(Math.PI / n);

            // Display result in read-only textbox based on selected precision
            if (cboPrecision.SelectedIndex == 0)
            {
                txtApothem.Text = a.ToString();
            }
            else
            {
                txtApothem.Text = a.ToString("n" + cboPrecision.SelectedIndex.ToString());
            }
        }

        /*~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        ' Name:             Perimeter()
        ' Description:
        ' 
        ' Method that calculates the perimeter of the user defined polygon.
        ' 
        ' Parameter:        int n
        ' Parameter:        double s
        ' Parameter:        decimal P (by reference)
        ' Return:           void
        ' Date:             10/13/2020
        ' Author:           Laura Waite
        ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~*/
        private void Perimeter(int n, double s, ref decimal P)
        {
            // Calculate perimeter
            P = (decimal)(n * s);

            // Display result in read-only textbox based on selected precision
            if (cboPrecision.SelectedIndex == 0)
            {
                txtPerimeter.Text = P.ToString();
            }
            else
            {
                txtPerimeter.Text = P.ToString("n" + cboPrecision.SelectedIndex.ToString());
            }
        }

        /*~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        ' Name:             Area()
        ' Description:
        ' 
        ' Method that calculates the area of the user defined polygon.
        ' 
        ' Parameter:        decimal a
        ' Parameter:        decimal P
        ' Parameter:        decimal A (by reference)
        ' Return:           void
        ' Date:             10/13/2020
        ' Author:           Laura Waite
        ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~*/
        private void Area(decimal a, decimal P, ref decimal A)
        {
            // Calculate area
            A = 0.5m * P * a;

            // Display result in read-only textbox based on selected precision
            if (cboPrecision.SelectedIndex == 0)
            {
                txtArea.Text = A.ToString();
            }
            else
            {
                txtArea.Text = A.ToString("n" + cboPrecision.SelectedIndex.ToString());
            }
        }

        /*~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        ' Name:             CircumcircleCircumference()
        ' Description:
        ' 
        ' Method that calculates the circumference of the circumcircle 
        ' of the user defined polygon.
        ' 
        ' Parameter:        decimal R
        ' Parameter:        decimal decCircCirc (by reference)
        ' Return:           void
        ' Date:             10/13/2020
        ' Author:           Laura Waite
        ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~*/
        private void CircumcircleCircumference(decimal R, ref decimal decCircCirc)
        {
            // Calculate circumference of circumcircle
            decCircCirc = 2 * (decimal)Math.PI * R;

            // Display result in read-only textbox based on selected precision
            if (cboPrecision.SelectedIndex == 0)
            {
                txtCircCirc.Text = decCircCirc.ToString();
            }
            else
            {
                txtCircCirc.Text = decCircCirc.ToString("n" + cboPrecision.SelectedIndex.ToString());
            }
        }

        /*~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        ' Name:             CircumcircleArea()
        ' Description:
        ' 
        ' Method that calculates the area of the circumcircle of the 
        ' user defined polygon.
        ' 
        ' Parameter:        decimal R
        ' Parameter:        decimal decAreaCirc (by reference)
        ' Return:           void
        ' Date:             10/13/2020
        ' Author:           Laura Waite
        ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~*/
        private void CircumcircleArea(decimal R, ref decimal decAreaCirc)
        {
            // Calculate area of circumcircle
            decAreaCirc = (decimal)(Math.PI * Math.Pow((double)R, 2.0));

            // Display result in read-only textbox based on selected precision
            if (cboPrecision.SelectedIndex == 0)
            {
                txtCircArea.Text = decAreaCirc.ToString();
            }
            else
            {
                txtCircArea.Text = decAreaCirc.ToString("n" + cboPrecision.SelectedIndex.ToString());
            }
        }

        /*~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        ' Name:             PerimeterError()
        ' Description:
        ' 
        ' Method that calculates the error in the approximate measurement  
        ' of the circumference of the circumcircle when based on measurement
        ' of user defined polygon's perimeter.
        ' 
        ' Parameter:        decimal P
        ' Parameter:        decimal decCircCirc
        ' Return:           void
        ' Date:             10/13/2020
        ' Author:           Laura Waite
        ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~*/
        private void PerimeterError(decimal P, decimal decCircCirc)
        {
            // Declare variable
            decimal decErrorP;

            // Calculate error in perimeter
            decErrorP = (decimal)Math.Abs(decCircCirc - P) / decCircCirc;

            // Display result in read-only textbox with unicode percent symbol based on selected precision
            if (cboPrecision.SelectedIndex == 0)
            {
                txtErrorPerimeter.Text = decErrorP.ToString() + "\u0025";
            }
            else
            {
                txtErrorPerimeter.Text = decErrorP.ToString("n" + cboPrecision.SelectedIndex.ToString()) + "\u0025";
            }
        }

        /*~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        ' Name:             AreaError()
        ' Description:
        ' 
        ' Method that calculates the error in the approximate measurement  
        ' of the area of the circumcircle when based on measurement
        ' of user defined polygon's area.
        ' 
        ' Parameter:        decimal A
        ' Parameter:        decimal decAreaCirc
        ' Return:           void
        ' Date:             10/13/2020
        ' Author:           Laura Waite
        ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~*/
        private void AreaError(decimal A, decimal decAreaCirc)
        {
            // Declare variable
            decimal decErrorA;

            // Caculate error in area
            decErrorA = (decimal)Math.Abs(decAreaCirc - A) / decAreaCirc;

            // Display result in read-only textbox with unicode percent symbol
            if (cboPrecision.SelectedIndex == 0)
            {
                txtErrorArea.Text = decErrorA.ToString() + "\u0025";
            }
            else
            {
                txtErrorArea.Text = decErrorA.ToString("n" + cboPrecision.SelectedIndex.ToString()) + "\u0025";
            }
        }

        /*~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        ' Name:             CentralAngle()
        ' Description:
        ' 
        ' Method that calculates the central angle (in radians, represented
        ' in degrees) of the user defined polygon.
        ' 
        ' Parameter:        int n
        ' Return:           void
        ' Date:             10/13/2020
        ' Author:           Laura Waite
        ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~*/
        private void CentralAngle(int n)
        {
            // Declare variable
            decimal decCtrAngle;
            const decimal CIRCLE_DEGREES = 360.0m;

            // Calculate degree of central angle of polygon
            decCtrAngle = CIRCLE_DEGREES / n;

            // Display result in read-only textbox with unicode degree symbol based on selected precision
            if (cboPrecision.SelectedIndex == 0)
            {
                txtCtrAngle.Text = decCtrAngle.ToString() + "\u00B0";
            }
            else
            {
                txtCtrAngle.Text = decCtrAngle.ToString("n" + cboPrecision.SelectedIndex.ToString()) + "\u00B0";
            }
        }

        /*~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        ' Name:             DistinctDiagonals()
        ' Description:
        ' 
        ' Method that calculates the distinct diagonals (lines intersecting
        ' two non-adjacent vertices) of the user defined polygon.
        ' 
        ' Parameter:        int n
        ' Return:           void
        ' Date:             10/13/2020
        ' Author:           Laura Waite
        ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~*/
        private void DistinctDiagonals(int n)
        {
            // Declare variable
            decimal decDiagonals;

            // Calculate the number of distinct diagonals in polygon - cast to decimal to prevent overflow for large numbers
            decDiagonals = (decimal)n * (n - 3.0m) / 2.0m;

            // Display result in read-only textbox as whole number based on selected precision
            txtDiagonals.Text = decDiagonals.ToString("n" + cboPrecision.SelectedIndex.ToString());
        }

        /*~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        ' Name:             btnDraw_Click()
        ' Description:
        ' 
        ' Event handler for the GUI button 'Draw'. Hides the logo image then
        ' calls the DrawPoly function and sets returned bitmap as the image property 
        ' of the picDraw picturebox control, then disables the Draw button, shows the 
        ' logo image and sets focus to the first user input and selects all text to
        ' allow user to quickly begin next calculation.
        ' 
        ' Parameter:        object sender
        ' Parameter:        EventArgs e
        ' Return:           void
        ' Date:             10/13/2018
        ' Author:           Laura Waite
        ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~*/
        private void btnDraw_Click(object sender, EventArgs e)
        {
            // Hide logo
            picPoly.Visible = false;

            // Call DrawPoly function, return to picturebox image property
            picDraw.Image = DrawPoly(ref n);

            // Disable Draw button to avoid clicks without new calculation
            btnDraw.Enabled = false;

            // Set focus and select all text for next calculation
            txtNumberSides.Focus();
            txtNumberSides.SelectAll();
        }

        /*~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        ' Name:             DrawPoly()
        ' Description:
        ' 
        ' Function that calculates the location of each vertex of a user-
        ' defined regular polygon by setting a point and then "rotating" by 
        ' the central angle to determine the x,y coordinates of the next vertex
        ' until all vertices for the shape are set. Next, the function creates a
        ' new bitmap and then calls the built-in DrawPolygon C# method to draw the shape
        ' at a constant radius of 100px, in black with a 3pt line weight, then returns the
        ' new bitmap to the btnDraw_Click event which called it.
        ' 
        ' Parameter:        int n (by reference)
        ' Return:           Bitmap bmpPoly
        ' Date:             10/13/2020
        ' Author:           Laura Waite
        ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~*/
        private Bitmap DrawPoly(ref int n)
        {
            // Declare constants 
            const int POLY_RADIUS = 100; // Constant for image radius, 100px to fit in given picturebox control
            const int IMG_OFFSET = 160; // Constant for pixel offset for point of origin to center drawing in 320x320px picturebox control

            // Create array to hold vertices for polygon per C# Graphics.DrawPolygon(Pen, Point[]) method
            var points = new Point[n];

            // Create bitmap size variable, polygon radius * number of sides
            var bmpSize = POLY_RADIUS * n;

            // Define new bitmap with size given above
            var bmpPoly = new Bitmap(bmpSize, bmpSize);

            // Create graphics variable as bitmap image
            Graphics g = Graphics.FromImage(bmpPoly);
            {
                // Loop through each index of array of vertices
                for (var i = 0; i < points.Length; i++)
                {
                    // Map X and Y coordinates of a given point based on the central angle of the polygon
                    double dblCtrAngle = Math.PI * 2 * i / n;
                    points[i].X = (int)(Math.Cos(dblCtrAngle) * POLY_RADIUS + IMG_OFFSET);
                    points[i].Y = (int)(Math.Sin(dblCtrAngle) * POLY_RADIUS + IMG_OFFSET);
                }

                // Call DrawPolygon method with black pen, 3px in line weight
                g.DrawPolygon(new Pen(Color.Black, 3), points);

                // Return new bitmap image
                return bmpPoly;
            }
        }

        /*~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        ' Name:             btnClear_Click()
        ' Description:
        ' 
        ' Event handler for the GUI button 'Clear'. Clears the user input
        ' textboxes and sets the combobox to default, clears output textboxes,
        ' disables the Draw button, shows the logo image and sets focus to
        ' the first user input.
        ' 
        ' Parameter:        object sender
        ' Parameter:        EventArgs e
        ' Return:           void
        ' Date:             10/13/2018
        ' Author:           Laura Waite
        ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~*/
        private void btnClear_Click(object sender, EventArgs e)
        {
            // Clear the inputs and outputs, disable Draw button, show logo image, and set focus to number of sides textbox
            txtIntAngle.Text = "";
            txtCircumradius.Text = "";
            txtApothem.Text = "";
            txtPerimeter.Text = "";
            txtArea.Text = "";
            txtCircCirc.Text = "";
            txtCircArea.Text = "";
            txtErrorPerimeter.Text = "";
            txtErrorArea.Text = "";
            txtCtrAngle.Text = "";
            txtDiagonals.Text = "";
            txtLengthSides.Text = "";
            txtNumberSides.Text = "";
            cboPrecision.SelectedIndex = 0;
            txtNumberSides.Focus();
            btnDraw.Enabled = false;
            picPoly.Visible = true;

        }

        /*~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        ' Name:             mnuFileClear_Click()
        ' Description:
        ' 
        ' Event handler for the GUI menu option File > Clear.
        ' Calls the Clear button on-click event handler.
        ' 
        ' Parameter:        object sender
        ' Parameter:        EventArgs e
        ' Return:           void
        ' Date:             10/13/2018
        ' Author:           Laura Waite
        ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~*/
        private void mnuFileClear_Click(object sender, EventArgs e)
        {
            // Call Clear button method
            btnClear_Click(sender, e);
        }

        /*~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        ' Name:             btnPrint_Click()
        ' Description:
        ' 
        ' Event handler for the GUI button 'Print'. Calls the CaptureScreen method
        ' then generates a new instance of the print page dialog form, passing the 
        ' pdPolygons print document in landscape mode for user to send to a printer 
        ' of their choice.
        ' 
        ' Parameter:        object sender
        ' Parameter:        EventArgs e
        ' Return:           void
        ' Date:             10/13/2018
        ' Author:           Laura Waite
        ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~*/
        private void btnPrint_Click(object sender, EventArgs e)
        {
            // Print GUI
            CaptureScreen();
            ppdPolygons.StartPosition = FormStartPosition.CenterParent;
            ppdPolygons.ClientSize = new Size(900, 600);
            ppdPolygons.PrintPreviewControl.Zoom = 1.0;
            ppdPolygons.Document.DefaultPageSettings.Landscape = true;
            ppdPolygons.Document = pdPolygons;
            ppdPolygons.ShowDialog();
        }

        /*~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        ' Name:             pdPolygons_PrintPage()
        ' Description:
        ' 
        ' Event handler for the print event for the print document pdPolygons.
        ' Acts as a middleman between print buttons and CaptureScreen method.
        ' 
        ' Parameter:        object sender
        ' Parameter:        EventArgs e
        ' Return:           void
        ' Date:             10/13/2018
        ' Author:           Laura Waite
        ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~*/
        private void pdPolygons_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            // Create print document
            e.Graphics.DrawImage(memoryImage, 0, 0);
        }

        /*~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        ' Name:             CaptureScreen()
        ' Description:
        ' 
        ' Method that mimics the screenshot function in windows to create a
        ' bitmap image that will act as the document to be printed.
        ' 
        ' Parameter:        null
        ' Return:           void
        ' Date:             10/13/2018
        ' Author:           Laura Waite
        ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~*/
        private void CaptureScreen()
        {
            // Capture screen image for printing
            Graphics myGraphics = this.CreateGraphics();
            Size s = this.Size;
            memoryImage = new Bitmap(s.Width, s.Height, myGraphics);
            Graphics memoryGraphics = Graphics.FromImage(memoryImage);
            memoryGraphics.CopyFromScreen(this.Location.X, this.Location.Y, 0, 0, s);

        }

        /*~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        ' Name:             mnuFilePrint_Click()
        ' Description:
        ' 
        ' Event handler for the menu option File > Print. Calls the Print button
        ' on-click event handler to mimic function.
        ' 
        ' Parameter:        object sender
        ' Parameter:        EventArgs e
        ' Return:           void
        ' Date:             10/13/2018
        ' Author:           Laura Waite
        ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~*/
        private void mnuFilePrint_Click(object sender, EventArgs e)
        {
            // Call Print button method
            btnPrint_Click(sender, e);
        }

        /*~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        ' Name:             mnuHelpAbout_Click()
        ' Description:
        ' 
        ' Event handler for the menu option Help > About. Creates a new instance
        ' of the AboutPolys template form.
        ' 
        ' Parameter:        object sender
        ' Parameter:        EventArgs e
        ' Return:           void
        ' Date:             10/13/2018
        ' Author:           Laura Waite
        ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~*/
        private void mnuHelpAbout_Click(object sender, EventArgs e)
        {
            // Show About page
            (new AboutPolys()).ShowDialog();
        }

        /*~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        ' Name:             btnExit_Click()
        ' Description:
        ' 
        ' Event handler for the GUI button 'Exit'. Closes the application and
        ' all of its forms.
        ' 
        ' Parameter:        object sender
        ' Parameter:        EventArgs e
        ' Return:           void
        ' Date:             10/13/2018
        ' Author:           Laura Waite
        ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~*/
        private void btnExit_Click(object sender, EventArgs e)
        {
            // Exit application
            Application.Exit();
        }

        /*~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        ' Name:             mnuFileExit_Click()
        ' Description:
        ' 
        ' Event handler for the menu option File > Exit. Closes the application and
        ' all of its forms.
        ' 
        ' Parameter:        object sender
        ' Parameter:        EventArgs e
        ' Return:           void
        ' Date:             10/13/2018
        ' Author:           Laura Waite
        ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~*/
        private void mnuFileExit_Click(object sender, EventArgs e)
        {
            // Exit application
            Application.Exit();
        }
    }
}
