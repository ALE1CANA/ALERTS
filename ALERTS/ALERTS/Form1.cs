namespace ALERTS
{
    public partial class Form1 : Form
    {
        //MessageBox.Show("Chissa");
        private int n;
        public Form1()
        {
            InitializeComponent();
            MessageBox.Show("Costruttore del form", "DEBUG");
            //non esistono ancora i componenti del form
            /*inizializzazione degli attributi form*/
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Thread.Sleep(5000);
            //MessageBox.Show("LOAD");
        }

        private void oneMessage(object obj)
        {
            Parametro arg=(Parametro)obj;
            MessageBox.Show(arg.Numero.ToString(), arg.Caption);
        }
        private void messaggio(object obj)
        {
            Thread[] mes = new Thread[3];
            for(int i=0;i<3;i++)
            {
                mes[i] = new Thread(oneMessage);
                mes[i].Start(obj);
            }
        //    Parametro arg=(Parametro)obj;
        //    MessageBox.Show(arg.Numero.ToString(), arg.Caption);

        //   Parametro argomento=obj as Parametro;
        //    MessageBox.Show(argomento.Numero.ToString(), argomento.Caption);
            
        //    MessageBox.Show(((Parametro)obj).Numero.ToString(), ((Parametro)obj).Caption);
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            Parametro uno = new Parametro(1, "CIAO");
            Parametro due = new Parametro(2, "HELLO");

            Thread esecutore=new Thread(messaggio);
            esecutore.Start(uno);
            Thread esecutore2 = new Thread(messaggio);
            esecutore2.Start(due);
            //messaggio();
        }
    }
}
