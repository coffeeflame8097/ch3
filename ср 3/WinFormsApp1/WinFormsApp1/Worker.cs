using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    internal class Worker
    {
        public string name = "";
        string kasim = "1 место";
        double kasrez = 230.00;
        string chokim = "2 место";
        double chokrez = 210.00;
        string abrim = "4 место";
        double abrrez = 168.00;
        string kanim = "3 место";
        double kanrez = 195.00;
        string smiim = "6 место";
        double smirez = 19.00;
        string burim = "5 место";
        double burrez = 99.00;
        public void SetEat(double eda)
        {

        }
        public string imkas()
        {
            return kasim;
        }
        public double rezkas()
        {
            return kasrez;
        }
        public string imchok()
        {
            return chokim;
        }
        public double rezchok()
        {
            return chokrez;
        }
        public string imabr()
        {
            return abrim;
        }
        public double rezabr()
        {
            return abrrez;
        }
        public string imkan()
        {
            return kanim;
        }
        public double rezkan()
        {
            return kanrez;
        }
        public string imsmi()
        {
            return smiim;
        }
        public double rezsmi()
        {
            return smirez;
        }
        public string imbur()
        {
            return burim;
        }
        public double rezbur()
        {
            return burrez;

        }
    }
}
