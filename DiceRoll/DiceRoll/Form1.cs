using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DiceRoll
{
    public partial class form_stdDist : Form
    {
        int[,] chart1Rolls;
        int[] chart1Differences = new int[11];
        int[,] f3Data = new int[2,36];

        Dictionary<int, int> dif = new Dictionary<int, int>();

        Histogram chart11 = new Histogram();
        Histogram chart12 = new Histogram();

        Histogram chart21 = new Histogram();

        Histogram chart31 = new Histogram();
        Histogram chart32 = new Histogram();

        static Random r = new Random();
        static Random r1;
        int seed = -999, numDice, numRolls, lastRoll;
        static String strSeed;

        aDie die1;
        FormSub formSub;
        Form3 f3;
        Form4 f4;

        public form_stdDist()
        {
            InitializeComponent();
            setFormPosition();

            f4 = new Form4(this);
            formSub = new FormSub(this);
            f3 = new Form3(this);

            die1 = new aDie();

            //initilize dictionary dif for form2
            for(int i = 0; i < 12; i++){
                dif.Add(i-5, i);
            }
            

        }
        /// <summary>
        /// Class aDie contains method:
        /// roll()
        /// </summary>
        /// <returns></returns>
        public class aDie: Random{

            private int face;

            
            
            public aDie()
            {
                
            }

            public aDie(int seed):base(seed)
            {

            }
            
            /// <summary>
            /// Returns number between 1 and 6 inclusive
            /// </summary>
            /// <returns></returns>
            /// 
            /*
            public int roll()
            {
                //if seed is null, use random seed
                if (string.IsNullOrWhiteSpace(strSeed)){
                    return r.Next(1, 7);
                }
                else{
                        return r1.Next(1, 7);
                }
                //return this.Next(1, 7);
            }
            */
            public int Face
            {
                get
                {
                    return this.Next(1, 7);
                }
                set
                {
                    //face = value;
                }
            }
        }

        public class Histogram : Dictionary<int, int>
        {
            public int update(int face)
            {
                if (!this.ContainsKey(face))
                {
                    this.Add(face, 1);
                }
                else
                {
                    this[face]++;
                }
                return this[face];
            }

        }

        public void setFormPosition()
        {
            int screenWidth, screenHeight;

            screenWidth = Screen.PrimaryScreen.Bounds.Width;
            screenHeight = Screen.PrimaryScreen.Bounds.Height;
            Console.WriteLine(screenWidth/this.Width);


            this.Location = new Point(
                                    (int)(screenWidth / 2 - this.Width / 2), 
                                    (int)(screenHeight /2 - this.Height));
        }

        /// <summary>
        /// Clears histogram and progress bar
        /// </summary>
        public void clear()
        {
            progressBar.Value = 0;

            //chart1.Series.Clear();
            //chart1.Series.Add("RollSet1");

            try
            {
                f4.chart1.Series["N d1 sum"].Points.Clear();
                f4.chart1.Series["N x d1 face"].Points.Clear();
            }
            catch { Console.WriteLine("form4 data failed clear"); }
            try
            {
                formSub.chart1.Series["d1 - d2"].Points.Clear();
            }catch{};

            try{
                f3.chart1.Series["die1 squared"].Points.Clear();
                f3.chart1.Series["die1 * die2"].Points.Clear();
            }
            catch { Console.WriteLine("chart3 failed clear"); };
            try{
                Array.Clear(chart1Rolls, 0, chart1Rolls.Length);
                Array.Clear(chart1Differences, 0, chart1Differences.Length);
                Array.Clear(f3Data, 0, f3Data.Length);

                chart11.Clear();
                chart12.Clear();
                chart21.Clear();
                chart31.Clear();
                chart32.Clear();
            }
            catch { Console.WriteLine("clear arrays error"); };
        }

        /// <summary>
        /// Checks if user input a seed
        /// </summary>
        public int getSeed()
        {
            if (!string.IsNullOrWhiteSpace(txt_seed.Text))
            {
                try
                {
                    if (seed != int.Parse(txt_seed.Text))
                    {
                       // r1 = new Random(Int32.Parse(txt_seed.Text));
                        seed = Int32.Parse(txt_seed.Text);
                        die1 = new aDie(seed);
                    }

                    
                    return 1;
                }
                catch 
                { 
                    MessageBox.Show("Invalid seed");
                    return -1;
                }
            }
            else
            {
                //seed = -999;
                die1 = new aDie();
            }
            return 1;
        }

        /// <summary>
        /// Manages progress bar
        /// </summary>
        public void setUpProgressBar()
        {
            if (progressBar.Value != 0)
            {
                progressBar.Value = 0;
            }
            try
            {
                progressBar.Maximum = int.Parse(txt_numRolls.Text);
                progressBar.Value = int.Parse(txt_numRolls.Text);
            }
            catch { }
        }

        /// <summary>
        /// Error check number of dicde (1-32) inclusive
        /// Set up chart1 2d array based off of numDice
        /// </summary>
        public bool errorCheckNumDice()
        {
            //if number of dice is blank, insert 1
            if (string.IsNullOrWhiteSpace(txt_numDice.Text))
            {
                txt_numDice.Text = "1";
            }

            if (Int32.TryParse(txt_numDice.Text, out numDice))
            {
                Console.WriteLine(numDice);
                if (numDice > 0 && numDice < 33)
                {
                    chart1Rolls = new int[2, numDice * 6];
                    return true;
                }
            }
            MessageBox.Show("Invalid number of dice");
            return false;
        }

        /// <summary>
        /// Error check number of rolls, display error message if necessary
        /// </summary>
        /// <returns></returns>
        public bool errorCheckNumRolls()
        {
            //if number of rolls is blank, insert 1 roll
            if (string.IsNullOrWhiteSpace(txt_numRolls.Text))
            {
                txt_numRolls.Text = "1";
            }

            if (int.TryParse(txt_numRolls.Text.ToString(), out numRolls))
            {
                if (numRolls > 0)
                    return true;
            }
            txt_lastRoll.Text = "err";
            MessageBox.Show("invalid number of rolls");
            lastRoll = -1;
            return false;
        }

        public void manageSubForm()
        {
            //form4 location and vis
            f4.Location = new Point(
                                            this.Location.X - f4.Width ,
                                            this.Location.Y
                                        );

            if (!f4.Visible)
            {
                f4 = new Form4(this);
                f4.Show();
            }

            //form2 manage location and visibility
            formSub.Location = new Point(
                                            this.Location.X + this.Width,
                                            this.Location.Y
                                        );
            
            
            if (!formSub.Visible)
            {
                formSub = new FormSub(this);
                formSub.Show();
            }
            
            //form3 manage location and visibility
            f3.Location = new Point(
                                        this.Location.X - 528,
                                        this.Location.Y + this.Height
                                    );
            if (!f3.Visible)
            {
                f3 = new Form3(this);
                f3.Show();
            }
                    
        }

        public void linqUpdate(Histogram hist, int key)
        {
            var update = from x in hist
                         where x.Key == key
                         select x;

            foreach (var y in update)
            {
                Console.WriteLine(y.Key);
                Console.WriteLine();
            }

            if (!update.Any())
            {
                hist.Add(key, 1);
            }
            else
            {/*
                foreach (var y in update)
                {
                    hist[y.Key]++;
                }*/
                hist[key]++;
            }
        }

        /// <summary>
        /// Controls iteration through number of rolls input
        /// </summary>
        public void loopThroughRolls()
        {
            int count = 0, sum = 0, face_x_dieNum, difference, die1xdie2, nextRoll, rollSquared;
            
            //loop through number of rolls
            while (numRolls > count)
            {
                count++;
                for (int i = 0; i < numDice; i++)
                {
                    strSeed = txt_seed.Text.ToString();
                    //die1.Face = die1.roll();
                    lastRoll = die1.Face;
                    sum += lastRoll;
                }

                face_x_dieNum = lastRoll * numDice;
                nextRoll = die1.Face;
                difference = lastRoll - nextRoll;
                die1xdie2 = lastRoll * nextRoll;
                rollSquared = lastRoll * lastRoll;

                //linq not checked
                if (!cb_linq.Checked)
                {
                    //form1 data - f4
                    /*
                    chart1Rolls[0, sum - 1] += 1;
                    chart1Rolls[1, face_x_dieNum - 1] += 1;
                    f4.chart1.Series["N d1 sum"].Points.AddXY(sum, chart1Rolls[0, sum - 1]);
                    f4.chart1.Series["N x d1 face"].Points.AddXY(face_x_dieNum, chart1Rolls[1, face_x_dieNum - 1]);
                    */

                    f4.chart1.Series["N d1 sum"].Points.AddXY(sum, chart11.update(sum));
                    f4.chart1.Series["N x d1 face"].Points.AddXY(face_x_dieNum, chart12.update(face_x_dieNum));

                    //form2 data
                    //die1.Face = die1.roll();
                    /*
                    nextRoll = die1.Face;
                    difference = lastRoll - nextRoll;
                    chart1Differences[dif[difference]] += 1;
                    formSub.chart1.Series["d1 - d2"].Points.AddXY(difference, chart1Differences[dif[difference]]);
                    */

                    
                    formSub.chart1.Series["d1 - d2"].Points.AddXY(difference, chart21.update(difference));

                    //form3 data
                    /*
                    f3Data[0, die1xdie2 - 1] += 1;
                    f3Data[1, rollSquared - 1] += 1;
                    f3.chart1.Series["die1 * die2"].Points.AddXY(die1xdie2, f3Data[0, die1xdie2 - 1]);
                    f3.chart1.Series["die1 squared"].Points.AddXY(rollSquared, f3Data[1, rollSquared - 1]);
                    */

                    f3.chart1.Series["die1 * die2"].Points.AddXY(die1xdie2, chart31.update(die1xdie2));
                    f3.chart1.Series["die1 squared"].Points.AddXY(rollSquared, chart32.update(rollSquared));
                }
                else
                {
                    linqUpdate(chart11, sum);
                    f4.chart1.Series["N d1 sum"].Points.AddXY(sum, chart11[sum]);
                    linqUpdate(chart12, face_x_dieNum);
                    f4.chart1.Series["N x d1 face"].Points.AddXY(face_x_dieNum, chart12[face_x_dieNum]);
                    linqUpdate(chart21, difference);
                    formSub.chart1.Series["d1 - d2"].Points.AddXY(difference, chart21[difference]);
                    linqUpdate(chart31, die1xdie2);
                    f3.chart1.Series["die1 * die2"].Points.AddXY(die1xdie2, chart31[die1xdie2]);
                    linqUpdate(chart32, rollSquared);
                    f3.chart1.Series["die1 squared"].Points.AddXY(rollSquared, chart32[rollSquared]);
                }

                //real time update
                if (!cb_linq.Checked)
                {
                    f4.chart1.Update();
                    formSub.chart1.Update();
                    f3.chart1.Update();

                }

                txt_lastRoll.Text = nextRoll.ToString();
                txt_2ndlastroll.Text = lastRoll.ToString();
                txt_lastRoll.Update();
                txt_2ndlastroll.Update();

                progressBar.Increment(1);
                sum = 0;
            }
        }

        /// <summary>
        /// Go button control
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_go_Click(object sender, EventArgs e)
        {
            int isSeedValid;

            clear();
            
            //get seed if one is present
            isSeedValid = getSeed();
            //if valid seed, sets total number of ticks progress bar has accroding to # of rolls
            if (isSeedValid == 1 && errorCheckNumDice() && errorCheckNumRolls())
            {
                manageSubForm();
                setUpProgressBar();
                loopThroughRolls();
                
            }
            
        }
        
        

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        
    }
}
