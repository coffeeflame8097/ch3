namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }



        private void button1_Click_1(object sender, EventArgs e)
        {
            Worker worker = new Worker();

            worker.name = comboBox1.Text;
            switch (comboBox1.SelectedIndex)
            {
                case 0:
                    MessageBox.Show(String.Format("Призёр: {0} \nЗанял : {1} \nРезультат: {2} баллов",
                worker.name, worker.imkas(), worker.rezkas()));
                    break;
                 case 1:
                    MessageBox.Show(String.Format("Призёр: {0} \nЗанял: {1} \nРезультат: {2} баллов",
             worker.name, worker.imchok(), worker.rezchok()));
                    break ;
                case 2:
                    MessageBox.Show(String.Format("Призёр: {0}  \nРезультат: {1} баллов",
                worker.name,  worker.rezabr()));
                    break;
                case 3:
                    MessageBox.Show(String.Format("Призёр: {0} \nЗанял: {1} \nРезультат: {2} баллов",
             worker.name, worker.imkan(), worker.rezkan()));
                    break;
                case 4:
                    MessageBox.Show(String.Format("Призёр: {0}  \nРезультат: {1} баллов",
                worker.name, worker.rezsmi()));
                    break;
                case 5:
                    MessageBox.Show(String.Format("Призёр: {0}  \nРезультат: {1} баллов",
             worker.name, worker.rezbur()));
                    break;
            }




        }
    }
}