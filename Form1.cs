using CalcOperations;


namespace FlirCalc
{
    public partial class Form1 : Form
    {
        private float CalcValue = 0;
        private float CalcValueDisplay= 0;
        private float CalcValueafterOPerator = 0;
        private float CalcMemValue = 0;
        private string Operator = string.Empty;
        private bool OpCompleted = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            tbValDisplay.Text = "0";
            CalcMemValue = 0;
            labelMem.Visible = false;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Operator = "add";            
            CalcValueafterOPerator = CalcValue;
            labelAddString.Text = string.Format("{0}{1}", tbValDisplay.Text, "+");
            tbValDisplay.Text = "0";
        }

        private void btnSubtract_Click(object sender, EventArgs e)
        {
            Operator = "sub";
            CalcValueafterOPerator = CalcValue;
            labelAddString.Text = string.Format("{0}{1}", tbValDisplay.Text, "-");
            tbValDisplay.Text = "0";
        }

        private void btnMultiply_Click(object sender, EventArgs e)
        {
            Operator = "multiply";
            CalcValueafterOPerator = CalcValue;
            labelAddString.Text = string.Format("{0}{1}", tbValDisplay.Text, "*");
            tbValDisplay.Text = "0";
        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            Operator = "div";
            CalcValueafterOPerator = CalcValue;
            labelAddString.Text = string.Format("{0}{1}", tbValDisplay.Text, "/");
            tbValDisplay.Text = "0";
        }

        private void btnEquals_Click(object sender, EventArgs e)
        {
            EqualsActions();
        }

        private void EqualsActions()
        {
            labelAddString.Text = string.Format("{0}{1}", labelAddString.Text, tbValDisplay.Text);
            CalcValueDisplay = selOperator(Operator);
            tbValDisplay.Text = CalcValueDisplay.ToString(); 
            OpCompleted = true;
        }
        private void NumberRestartAction()
        {
            tbValDisplay.Text = "0";
            CalcValue = 0;
            OpCompleted = false;
        }

        private float selOperator(string opin)
        {
            CalcOperations.CalcOps co = new CalcOps();
            switch (opin)
            {
                case "add":
                    CalcValue = co.addition(CalcValueafterOPerator, CalcValue);
                    //CalcValue += CalcValueafterOPerator;
                break;
                case "sub":
                    //CalcValue -= CalcValueafterOPerator;
                    CalcValue = co.subtraction(CalcValueafterOPerator, CalcValue);
                    break;
                case "multiply":
                    //CalcValue *= CalcValueafterOPerator; 
                    CalcValue = co.multiplication(CalcValueafterOPerator, CalcValue);
                    break;
                case "div":
                    //CalcValue /= CalcValueafterOPerator;
                    CalcValue = co.division(CalcValueafterOPerator, CalcValue);
                    break;
                default:
                    break;
            }
            return CalcValue;
        }

        private void btnOne_Click(object sender, EventArgs e)
        {
            if (OpCompleted)
            {
                NumberRestartAction();
            }

            if (tbValDisplay.Text.Equals("0"))
            {
                tbValDisplay.Text = string.Format("{0}", "1");
                CalcValue = float.Parse(tbValDisplay.Text);
            }
            else
            {
                tbValDisplay.Text = string.Format("{0}{1}", tbValDisplay.Text, "1");
                CalcValue = float.Parse(tbValDisplay.Text);
            }
              
        }

        private void btnTwo_Click(object sender, EventArgs e)
        {
            if (OpCompleted)
            {
                NumberRestartAction();
                OpCompleted = false;
            }            
            
            if (tbValDisplay.Text.Equals("0"))
            {
                tbValDisplay.Text = string.Format("{0}", "2");
                CalcValue = float.Parse(tbValDisplay.Text);
            }
            else
            {
                tbValDisplay.Text = string.Format("{0}{1}", tbValDisplay.Text, "2");
                CalcValue = float.Parse(tbValDisplay.Text);
            }
        }

        private void btnThree_Click(object sender, EventArgs e)
        {
            if (OpCompleted)
            {
                NumberRestartAction();
                OpCompleted = false;
            }
            if (tbValDisplay.Text.Equals("0"))
            {
                tbValDisplay.Text = string.Format("{0}", "3");
                CalcValue = float.Parse(tbValDisplay.Text);
            }
            else
            {
                tbValDisplay.Text = string.Format("{0}{1}", tbValDisplay.Text, "3");
                CalcValue = float.Parse(tbValDisplay.Text);
            }
           
        }

        private void btnFour_Click(object sender, EventArgs e)
        {
            if (OpCompleted)
            {
                NumberRestartAction();
                OpCompleted = false;
            }
            if (tbValDisplay.Text.Equals("0"))
                {
                    tbValDisplay.Text = string.Format("{0}", "4");
                    CalcValue = float.Parse(tbValDisplay.Text);
                }
                else
                {
                    tbValDisplay.Text = string.Format("{0}{1}", tbValDisplay.Text, "4");
                    CalcValue = float.Parse(tbValDisplay.Text);
                }
            
        }

        private void btnFive_Click(object sender, EventArgs e)
        {
            if (OpCompleted)
            {
                NumberRestartAction();
                OpCompleted = false;
            }
            if (tbValDisplay.Text.Equals("0"))
            {
                tbValDisplay.Text = string.Format("{0}", "5");
                CalcValue = float.Parse(tbValDisplay.Text);
            }
            else
            {
                tbValDisplay.Text = string.Format("{0}{1}", tbValDisplay.Text, "5");
                CalcValue = float.Parse(tbValDisplay.Text);
            }
          
        }

        private void btnSix_Click(object sender, EventArgs e)
        {
            if (OpCompleted)
            {
                NumberRestartAction();
                OpCompleted = false;
            }
            if (tbValDisplay.Text.Equals("0"))
            {
                tbValDisplay.Text = string.Format("{0}", "6");
                CalcValue = float.Parse(tbValDisplay.Text);
            }
            else
            {
                tbValDisplay.Text = string.Format("{0}{1}", tbValDisplay.Text, "6");
                CalcValue = float.Parse(tbValDisplay.Text);
            }
        
        }

        private void btnSeven_Click(object sender, EventArgs e)
        {
            if (OpCompleted)
            {
                NumberRestartAction();
                OpCompleted = false;
            }
            if (tbValDisplay.Text.Equals("0"))
            {
                tbValDisplay.Text = string.Format("{0}", "7");
                CalcValue = float.Parse(tbValDisplay.Text);
            }
            else
            {
                tbValDisplay.Text = string.Format("{0}{1}", tbValDisplay.Text, "7");
                CalcValue = float.Parse(tbValDisplay.Text);
            }
          
        }

        private void btnEight_Click(object sender, EventArgs e)
        {
            if (OpCompleted)
            {
                NumberRestartAction();
                OpCompleted = false;
            }
            if (tbValDisplay.Text.Equals("0"))
            {
                tbValDisplay.Text = string.Format("{0}", "8");
                CalcValue = float.Parse(tbValDisplay.Text);
            }
            else
            {
                tbValDisplay.Text = string.Format("{0}{1}", tbValDisplay.Text, "8");
                CalcValue = float.Parse(tbValDisplay.Text);
            }
         
        }

        private void btnNine_Click(object sender, EventArgs e)
        {
            if (OpCompleted)
            {
                NumberRestartAction();
                OpCompleted = false;
            }
            if (tbValDisplay.Text.Equals("0"))
            {
                tbValDisplay.Text = string.Format("{0}", "9");
                CalcValue = float.Parse(tbValDisplay.Text);
            }
            else
            {
                tbValDisplay.Text = string.Format("{0}{1}", tbValDisplay.Text, "9");
                CalcValue = float.Parse(tbValDisplay.Text);
            }
         
        }

        private void btnZero_Click(object sender, EventArgs e)
        {
            if (OpCompleted)
            {
                NumberRestartAction();
                OpCompleted = false;
            }
            if (tbValDisplay.Text.Equals("0"))
            {
                tbValDisplay.Text = string.Format("{0}", "0");
                CalcValue = float.Parse(tbValDisplay.Text);
            }
            else
            {
                tbValDisplay.Text = string.Format("{0}{1}", tbValDisplay.Text, "0");
                CalcValue = float.Parse(tbValDisplay.Text);
            }
           
        }

        private void btnMemAdd_Click(object sender, EventArgs e)
        {
            CalcMemValue = CalcValue;
            labelMem.Visible = true;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            CalcValue = 0;
            CalcValueafterOPerator = 0;
            labelAddString.Text = ""; 
            tbValDisplay.Text = "0";
        }

        private void btnMemClr_Click(object sender, EventArgs e)
        {
            CalcMemValue = 0;
            labelMem.Visible = false;
            tbValDisplay.Text = "0";
            labelAddString.Text = "";
        }

        private void btnMemRecall_Click(object sender, EventArgs e)
        {
             CalcValue = CalcMemValue;
            tbValDisplay.Text = CalcValue.ToString();
        }
    }
}