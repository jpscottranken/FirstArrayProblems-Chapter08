using System;
using System.Linq;
using System.Windows.Forms;
using Microsoft.VisualBasic;

/*
 *      A GUI-based C# Array Program
 */

namespace GUIApp1
{
    public partial class frmArrayGUI : Form
    {
        //  Declare and initialize program constants
        const int SIZE = 25;
        const int MIN = 0;
        const int MAX = 100;

        //  Declare and initialize class variables
        int[] numbers = new int[SIZE];
        int[] copy = new int[SIZE];
        int searchValue = 0;

        public frmArrayGUI()
        {
            InitializeComponent();
        }

        private void btnOrginalArray_Click(object sender, EventArgs e)
        {
            ClearListBox();
            DisplayArray(numbers);
        }

        private void DisplayArray(int[] arr)
        {
            for (int lcv = 0; lcv < arr.Length; lcv++)
            {
                //  Add current array element
                //  value to the listbox
                lstNumbers.Items.Add(arr[lcv]);
            }
        }

        private void ClearListBox()
        {
            //  Clear out whatever is currently
            //  int the lstNumbers listbox.
            for (int lcv = 0; lcv < numbers.Length; lcv++)
            {
                lstNumbers.Items.Clear();
            }
        }

        private void frmArrayGUI_Load(object sender, EventArgs e)
        {
            FillArray();
        }

        private void FillArray()
        {
            //  "Seed" the rand
            Random rand = new Random();

            ClearListBox();

            //  Fill up both arrays with the
            //  same 25 random #s between 0 - 100.
            //  Then, fill up the listbox.
            for (int lcv = 0; lcv < numbers.Length; lcv++)
            {
                numbers[lcv] = rand.Next(MIN, (MAX + 1));
                copy[lcv] = numbers[lcv];
                lstNumbers.Items.Add(numbers[lcv]);
            }
        }

        private void btnSortAscending_Click(object sender, EventArgs e)
        {
            SortArrayAscending();
        }

        private void SortArrayAscending()
        {
            ClearListBox();
            Array.Sort(copy);
            DisplayArray(copy);
        }

        private void btnSortDescending_Click(object sender, EventArgs e)
        {
            SortArrayDescending();
        }

        private void SortArrayDescending()
        {
            ClearListBox();
            Array.Sort(copy);
            Array.Reverse(copy);
            DisplayArray(copy);
        }

        private void btnSmallestElement_Click(object sender, EventArgs e)
        {
            FindSmallestArrayElement();
        }

        private void FindSmallestArrayElement()
        {
            SortArrayAscending();
            ShowMessage("The Smallest Array Element:\t" + copy[0],
                        "SMALLEST ARRAY ELEMENT");
        }

        private void FindLargestArrayElement()
        {
            SortArrayDescending();
            ShowMessage("The Largest Array Element:\t" + copy[0],
                        "LARGEST ARRAY ELEMENT");
        }

        private void ShowMessage(string msg, string title)
        {
            MessageBox.Show(msg, title,
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
        }

        private void btnLargestElement_Click(object sender, EventArgs e)
        {
            FindLargestArrayElement();
        }

        private void btnSumOfElements_Click(object sender, EventArgs e)
        {
            SumOfArrayElements(1);
        }

        private void btnAvgOfElements_Click(object sender, EventArgs e)
        {
            SumOfArrayElements(2);
        }

        private void SumOfArrayElements(int num)
        {
            int sum = 0;
            decimal avg = 0.00m;

            for (int lcv = 0; lcv < numbers.Length; lcv++)
            {
                sum += copy[lcv];
            }

            if (num == 1)
            {
                ShowMessage("The Sum Of All Array Elements: " + sum.ToString(),
                            "SUM OF ALL ARRAY ELEMENTS");
            }
            else if (num == 2)
            {
                avg = (decimal)sum / copy.Length;

                ShowMessage("The Avg Of All Array Elements: " + avg.ToString("n2"),
                            "AVG OF ALL ARRAY ELEMENTS");
            }
        }

        private void btnRange_Click(object sender, EventArgs e)
        {
            DisplayArrayRange();
        }

        private void DisplayArrayRange()
        {
            int range;

            ClearListBox();
            Array.Sort(copy);
            DisplayArray(copy);

            range = copy[copy.Length - 1] - copy[0];

            ShowMessage("The Range Of All Array Elements: " + range.ToString(),
                        "RANGE OF ALL ARRAY ELEMENTS");
        }

        private void btnMedian_Click(object sender, EventArgs e)
        {
            FindMedianArrayElement();
        }

        private void FindMedianArrayElement()
        {
            int median;

            ClearListBox();
            SortArrayAscending();

            median = copy[12];

            ShowMessage("The Median Of All Array Elements: " + median.ToString(),
                        "MEDIAN OF ALL ARRAY ELEMENTS");
        }

        private void btnVisualBasicSearch_Click(object sender, EventArgs e)
        {
            bool keepGoing = PrepareForSeach(1);
            if (!keepGoing)
            {
                return;
            }

            PerformVBSearch();
            return;
        }

        private void PerformVBSearch()
        {
            //  Perform manual search for value
            for (int lcv = 0; lcv < copy.Length; ++lcv)
            {
                string sv = searchValue.ToString();
                if (copy[lcv].ToString().Contains(sv))
                {
                    ShowMessage("The number " + searchValue.ToString() +
                                " IS in the array!",
                                "NUMBER FOUND");
                    return;
                }
            }

            ShowMessage("The number " + searchValue.ToString() +
                            " IS NOT in the array!",
                            "NUMBER FOUND");
        }

        private void btnCSharpSearch_Click(object sender, EventArgs e)
        {
            bool keepGoing = PrepareForSeach(2);
            if (!keepGoing)
            {
                return;
            }

            PerformCSharpSearch();
        }

        private void PerformCSharpSearch()
        {
            int index = Array.BinarySearch(copy, searchValue);
            if (index < 0)
            {
                ShowMessage("The number " + searchValue.ToString() +
                " IS NOT in the array!",
                "NUMBER NOT FOUND");
                return;
            }
            else
            {
                ShowMessage("The number " + searchValue.ToString() +
                            " IS in the array!",
                            "NUMBER FOUND");
            }
        }

        private bool PrepareForSeach(int num)
        {
            ClearListBox();
            SortArrayAscending();

            string message = "Enter Number To Search For";
            string title = "";

            title = (num == 1) ? "VB SEARCH FOR ARRAY ELEMENT"
                               : "C# SEARCH FOR ARRAY ELEMENT";

            string svStr = Interaction.InputBox(message, title,
                                                default, 825, 450);

            bool result;

            try
            {
                //  Check for no input in MessageBox
                if (svStr == "")
                {
                    throw new ArgumentNullException();
                }

                //  Check for non-numeric input in MessageBox
                result = Int32.TryParse(svStr, out searchValue);
                if (!result)
                {
                    throw new FormatException();
                }

                //  Check for out-of-range input in MessageBox
                if (searchValue < MIN || searchValue > MAX)
                {
                    throw new ArgumentOutOfRangeException();
                }

                return true;
            }
            catch (ArgumentNullException ane)
            {
                ShowMessage("System Message:\t" + ane.Message + "\n\n" +
                            "You Must Enter A Search Value!",
                            "ARGUMENTNULLEXCEPTION");
                return false;
            }
            catch (FormatException fe)
            {
                ShowMessage("System Message:\t" + fe.Message + "\n\n" +
                            "You Must Enter A Number For Search Value!",
                            "FORMATEXCEPTION");
                return false;
            }
            catch (ArgumentOutOfRangeException aoore)
            {
                ShowMessage("System Message:\t" + aoore.Message + "\n\n" +
                            "You Must Enter A Number Between " +
                            MIN + " And " + MAX + " For The Search Value!",
                            "ARGUMENTOUTOFRANGEEXCEPTION");
                return false;
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearForm();
        }

        private void ClearForm()
        {
            ClearListBox();
            FillArray();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            ExitProgramOrNot();
        }

        private void ExitProgramOrNot()
        {
            DialogResult dialog = MessageBox.Show(
                        "Do You Really Want To Exit The Program?",
                        "EXIT NOW?",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question);

            if (dialog == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
