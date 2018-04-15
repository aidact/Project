using System;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using System.Diagnostics;

namespace Project
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Day today = new Day();
        public int openClose = 0;
        private void btnAddClick(object sender, EventArgs e)
        {
            
            Storage storage = Storage.Instance;

            Food f = new Food();
            f.calories = 20;
            f.name = "egg";
            f.category = 1; storage.Foods.Add(f);

            Food f2 = new Food();
            f2.calories = 20;
            f2.name = "meat";
            f2.category = 2; storage.Foods.Add(f2);

            Food f3 = new Food();
            f3.calories = 20;
            f3.name = "fish";
            f3.category = 3; storage.Foods.Add(f3);

            string input = textBoxInput.Text;

            Food food = storage.GetFood(input);
            if (food != null)
            {
                if (radioButtonBreakfast.Checked)
                {
                    Period breakfast = new Period(PeriodType.Breakfast);
                    breakfast.foods.Add(food);
                    listBoxBreakfast.Items.Add(food.name);            
                    today.periods.Add(breakfast);
                }
                else if (radioButtonLunch.Checked)
                {
                    Period lunch = new Period(PeriodType.Lunch);
                    lunch.foods.Add(food);
                    listBoxLunch.Items.Add(food.name);
                    today.periods.Add(lunch);
                }
                else if (radioButtonDinner.Checked)
                {
                    Period dinner = new Period(PeriodType.Dinner);
                    dinner.foods.Add(food);
                    listBoxDinner.Items.Add(food.name);
                    today.periods.Add(dinner);
                }
                textBoxInput.Text = "";
            }

        }

        private void btnAnalyzeClick(object sender, EventArgs e)
        {
            foreach(Period d in today.periods)
            {
                listBoxResult.Items.Add(d.type+" " + d.foods);
            }

            Statistics st = Statistics.Instance;
            st.Days.Add(today);

            today.periods.Clear();
            listBoxDinner.Items.Clear();
            listBoxBreakfast.Items.Clear();
            listBoxLunch.Items.Clear();
            
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void profileBtn_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            Day d = new Day();
           // Storage store = new Storage();
            if (groupBox2.Visible)
            {
                groupBox2.Hide();
            }
            else
            {
                groupBox2.Show();

               // pictureBox1.BackgroundImage = store.GetUser().bmp;
                label2.Text = "Name Surname";
                label3.Text += "100";

                label1.Text += d.GetCalories();
            }
        }

        private void statBtn_Click(object sender, EventArgs e)
        {
            
            Day d = new Day();
            Chart ch = new Chart();
            ch.Series.Add("Series1");
            ch.Series["Series1"].Points.Clear();

            foreach (Period p in d.periods)
            { 
                ch.Series["Series1"].Points.AddXY(p.getType(), p.GetCoef());

            }

            openClose++;
            if (openClose % 2 == 0)
            {
                ch.Hide();
                ch.Visible = false;
            }
            else
            {
                ch.Show();
                Controls.Add(ch);
                ch.Show();
                ch.BringToFront();
                
            }
            //ch.Location = e.Location(300, 80);
            
            
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
    }
}
