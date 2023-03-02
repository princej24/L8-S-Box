using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace L8
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<Students> students = new List<Students>();
        Students selectedstudent = null;
        public MainWindow()
        {
            InitializeComponent();
            preload();
            DisplayToListBox();
            DisplaytocbDisplay();

           lbDisplayInfo.SelectedIndex = 0;
            cbDisplayinfo.SelectedIndex = 0;
        }
        public void preload()
        {
            Students student = new Students("prince", "mutur", 100, 90);
            students.Add(student);
            students.Add(new Students("jeff", "muturi", 100, 100));
            students.Add(new Students("jostin", "Diaz", 80, 90));
            students.Add(new Students("jace", "martino", 70, 96));
            students.Add(new Students("jeffry", "Abdil", 88, 90));
            students.Add(new Students("jack", "solo", 89, 79));

        }
        public void DisplayToListBox()
        {
            lbDisplayInfo.Items.Clear();
            for (int i = 0; i < students.Count; i++)
            {
                string firstName = students[i].FirstName;
                string lastName = students[i].LastName;
                string FullName = firstName + " " + lastName;
                lbDisplayInfo.Items.Add(FullName);

            }


        }

        public void DisplaytocbDisplay()
        {
            cbDisplayinfo.Items.Clear();
            for (int i = 0; i < students.Count; i++)
            {
                string firstName = students[i].FirstName;
                string lastName = students[i].LastName;
                string FullName = firstName + " " + lastName;
                cbDisplayinfo.Items.Add(FullName);

            }


        }


        private void Button_Click(object sender, RoutedEventArgs e)
        {
           
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            int selectedIndex = lbDisplayInfo.SelectedIndex;

            if(selectedIndex < 0)
            {
                MessageBox.Show("please select a name from the list box ");
            }
            else
            {
                DisplayStudentsInformation(selectedstudent);
            }





        }
        public void DisplayStudentsInformation(Students student)
        {
            txtFirstName.Text = student.FirstName;
            txtLastName.Text = student.LastName;
            txtCsiGrade.Text = student.CSIgrade.ToString();
            txtGenEdGrade.Text = student.GenEdgrade.ToString();

        }

        private void btnAddStudent_Click(object sender, RoutedEventArgs e)
        {
                string fName = txtFirstName.Text;
                string lName = txtLastName.Text;
                string csi = txtCsiGrade.Text;
                string genEd = txtGenEdGrade.Text;

            int CSIGrade = int.Parse(csi);
            int GenEdGrade = int.Parse(genEd);


             students.Add(new Students(fName,lName, CSIGrade, GenEdGrade));

            DisplayToListBox();
        }

        private void btnRemovestd_Click(object sender, RoutedEventArgs e)
        {
            int selectedIndex = lbDisplayInfo.SelectedIndex;
            students.Remove(selectedstudent);
            DisplayToListBox ();
        }
        private void DisplayUpdatedInformation(int SelectedIndex)
        {


            selectedstudent = students[SelectedIndex];
            DisplayStudentsInformation(selectedstudent);
        }

        private void cbDisplayinfo_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            DisplayUpdatedInformation(cbDisplayinfo.SelectedIndex);
            DisplayStudentsInformation(selectedstudent);


        }

        private void lbDisplayInfo_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            DisplayUpdatedInformation(lbDisplayInfo.SelectedIndex);
            DisplayStudentsInformation(selectedstudent);

        }
    }
}
