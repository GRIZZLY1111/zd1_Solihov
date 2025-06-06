using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace zd1_Solihov
{
    public partial class Zad2 : Form
    {
        Shop shop = new Shop();
        public Zad2()
        {
            InitializeComponent();
        }

        private void Zad2_Load(object sender, EventArgs e)
        {

        }
        //Добавляет товар в заданном количестве
        private void button3_Click(object sender, EventArgs e)
        {
            string name = textBox1.Text.Trim();
            int count = int.Parse(textBox3.Text);
            //Проверяет чтобы количество не было меньше ноля и не было равно нулю
            if (count <= 0)
            {
                MessageBox.Show("Количество не может быть равным нулю или меньше");
                return;
            }
            shop.Add(name, count);
            MessageBox.Show("Товар добавлен!");
            shop.WriteAllProducts(listBox1);
        }
        //Создает товар в заданном количестве
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string name = textBox1.Text.Trim();
                decimal price = decimal.Parse(textBox2.Text);
                int count = int.Parse(textBox3.Text);
                //проверяет чтобы цена и количество небыли меньше одного
                if (price <= 0 || count <= 0)
                {
                    MessageBox.Show("Количество или цена не могут быть равны нулю или меньше");
                    return;
                }
                shop.CreateProduct(name, price, count);
                MessageBox.Show("Товар добавлен!");
                shop.WriteAllProducts(listBox1);
            }
            catch
            {
                MessageBox.Show("Ошибка ввода. Укажите корректные данные.");
            }
        }
        //Продает товар в заданном колличестве
        private void button2_Click(object sender, EventArgs e)
        {
            string name = textBox1.Text.Trim();
            int count = Convert.ToInt32(textBox3.Text);
            if (!string.IsNullOrEmpty(name))
            {
                shop.Sell(name, count);
                shop.WriteAllProducts(listBox1);
            }
            else
            {
                MessageBox.Show("Введите наименование товара для продажи.");
            }
        }
    }
}
