namespace DinazorOyunu
{
    public partial class Form1 : Form
    {

        bool ziplanabilirmi;
        public Form1()
        {
            this.DoubleBuffered = true;
            InitializeComponent();
            dinozor.Image = Resource1.deneme3;
            dinozor.BackgroundImageLayout = ImageLayout.Stretch;
            ziplanabilirmi = true;
            dinozor.BackColor = Color.Transparent;
            KaktusOlustur();
            timer1.Start();
        }
        int skor;
        private void timer1_Tick(object sender, EventArgs e)
        {
            skor++;
            kaktusolusturucu++;
            if (skor % 2 == 0)
            {
                lbl_skor.Text = skor.ToString();

            }

            foreach (PictureBox item in clouds)
            {
                item.Location = new Point(item.Location.X - 10, item.Location.Y);

                if (item.Location.X == (this.Right + 50) - 10 * 40 && skor % 2 == 0) 
                {
                    BackColor = Color.FromArgb(new Random().Next(255), new Random().Next(255), new Random().Next(255));
                    KaktusOlustur();
                }

                if (item.Location.X < -60)
                {
                    item.Dispose();

                    GC.Collect(); //  Garbage Collector(çöp toplayýcýsý)
                    GC.WaitForPendingFinalizers(); // Çöpleri yok et
                }
            }

            foreach (PictureBox item in Kaktusler)
            {
                item.Location = new Point(item.Location.X - 11, item.Location.Y);

                if (item.Location.X < -60)
                {
                    item.Dispose();       
                }
            }

            foreach (PictureBox item in Kaktusler)
            {
                if (dinozor.Bounds.IntersectsWith(item.Bounds))
                {
                    timer2.Stop();
                    timer1.Stop();
                    MessageBox.Show("Kaybettiniz");
                }
            }


        }

        List<PictureBox> clouds = new List<PictureBox>();
        int cloudid;
        private void BulutOlustur()
        {
            clouds.Add(new PictureBox()
            {
                Width = 100,
                Height = 79,
                Location = new Point(this.Right + 50, new Random().Next(10,(this.Height/3))),
                BackgroundImage = Resource1.Cloud,
                BackgroundImageLayout = ImageLayout.Stretch,

            });
            KaktusOlustur();
            this.Controls.Add(clouds[cloudid]);
            cloudid++;
        }
        List<PictureBox> Kaktusler = new List<PictureBox>();
        int kaktusid = 0;
        private void KaktusOlustur()
        {
            Kaktusler.Add(new PictureBox()
            {
                Width = 35,
                Height = 55,
                Location = new Point(this.Right + 30, panel1.Top - 55),
                BackgroundImage = Resource1.Cactus,
                BackgroundImageLayout = ImageLayout.Stretch,
            });
            this.Controls.Add(Kaktusler[kaktusid]);
            kaktusid++;
        }

        int kaktusolusturucu;
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            kaktusolusturucu++;
            if (e.KeyCode == Keys.Space && ziplanabilirmi == true || e.KeyCode == Keys.W)
            {
                ziplanabilirmi = false;
                dinozor.Image = Resource1.ziplamak;
                timer2.Start();
            }
        }
        int a;
        private void timer2_Tick(object sender, EventArgs e)
        {
            a++;

            if (a <= 20)
            {
                dinozor.Location = new Point(dinozor.Location.X, dinozor.Location.Y - 6);

            }
            else if (a > 22 && a<=42)
            {
                dinozor.Location = new Point(dinozor.Location.X, dinozor.Location.Y + 6);

            }
            else if (a >= 42)
            {
                ziplanabilirmi = true;
                a = 0;
                timer2.Stop();
                dinozor.Image = Resource1.deneme3;
                BulutOlustur();
                KaktusOlustur();

            }
        }
    }
}
