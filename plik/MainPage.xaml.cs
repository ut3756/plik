namespace plik
{
    public partial class MainPage : ContentPage
    {

        class Samochod
        {
            public int id { get; set; }
            public string marka { get; private set; }
            public string model { get; private set; }
            public string kolor { get; private set; }
            public int rocznik { get; private set; }
            public int przebieg { get; private set; }
            public int cena { get; private set; }
            public string grafika { get; private set; }

            public Samochod(int id, string marka, string model, string kolor, int rocznik, int przebieg, int cena, string grafika)
            {
                this.id = id;
                this.marka = marka;
                this.model = model;
                this.kolor = kolor;
                this.rocznik = rocznik;
                this.przebieg = przebieg;
                this.cena = cena;
                this.grafika = grafika;
            }
        }
        
        List<Samochod> samochody = new List<Samochod>();
        public MainPage()
        {
            InitializeComponent();
            samochody.Add(new Samochod(123, "a", "b", "c", 5, 4, 6, "a"));
            using (TextReader r = File.OpenText(@"C:\Users\m\source\repos\plik\plik\Resources\Images\pojazd.txt"))
            {
                //   string s = r.ReadLine();
                // string[] t = s.Split(";");


                while(r.Peek() > 0)
                {
                    string[] s = r.ReadLine().ToString().Split(";");

                    Samochod sam = new Samochod(int.Parse(s[0]), s[1], s[2], s[3], int.Parse(s[4]), int.Parse(s[5]), int.Parse(s[6]), s[7]);

                    samochody.Add(sam);
                }

                lblMarkaModel.Text = samochody[1].marka + " " + samochody[1].model;
                zdj.Source = samochody[1].grafika;
                lblTekst.Text = $"Kolor {samochody[1].kolor}, przebieg {samochody[1].przebieg}km. Rocznik {samochody[1].rocznik}.";
                lblCena.Text = $"CENA {samochody[1].cena}zł.";
                lblId.Text = samochody[1].id.ToString();
            }
        }

        private void prevThing(object sender, EventArgs e)
        {
            int i = int.Parse(lblId.Text);
            i--;
            if (i < 1) i = 10;

            lblMarkaModel.Text = samochody[i].marka + " " + samochody[i].model;
            zdj.Source = samochody[i].grafika;
            lblTekst.Text = $"Kolor {samochody[i].kolor}, przebieg {samochody[i].przebieg}km. Rocznik {samochody[i].rocznik}.";
            lblCena.Text = $"CENA {samochody[i].cena}zł.";
            lblId.Text = samochody[i].id.ToString();

        }
        
        private void nextThing(object sender, EventArgs e)
        {
            int i = int.Parse(lblId.Text);
            i++;
            if (i > 10) i = 1;

            lblMarkaModel.Text = samochody[i].marka + " " + samochody[i].model;
            zdj.Source = samochody[i].grafika;
            lblTekst.Text = $"Kolor {samochody[i].kolor}, przebieg {samochody[i].przebieg}km. Rocznik {samochody[i].rocznik}.";
            lblCena.Text = $"CENA {samochody[i].cena}zł.";
            lblId.Text = samochody[i].id.ToString();
        }


    }

}
