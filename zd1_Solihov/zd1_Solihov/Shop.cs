using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace zd1_Solihov
{
    class Shop
    {
        private Dictionary<Product, int> products;
        //Инициализирует словарь
        public Shop()
        {
            products = new Dictionary<Product, int>();
        }
        //Добавляет товар в заданном количестве
        public void AddProduct(Product product, int count)
        {
            if (products.ContainsKey(product))
            {
                products[product] += count;
            }
            else
            {
                MessageBox.Show("Товар не найден!");
            }
        }
        //Ищет товар с заданным именем чтобы после добавить товар
        public void Add(string ProductName, int count)
        {
            Product Add = FindByName(ProductName);
            if (Add != null)
            {
                this.AddProduct(Add, count);
            }
            else
            {
                MessageBox.Show("Товар не найден!");
            }
        }
        //Создает товар с заданным названием, ценой и количеством
        public void CreateProduct(string name, decimal price, int count)
        {
            products.Add(new Product(name, price), count);
        }
        //Выводит в листбокс список товаров
        public void WriteAllProducts(ListBox listBox)
        {
            listBox.Items.Clear();
            listBox.Items.Add("Список продуктов:");
            foreach (var item in products)
            {
                listBox.Items.Add($"{item.Key.GetInfo()}; Количество: {item.Value}");
            }
        }
        //Продает товар в заданном количестве
        public void Sell(Product product, int count)
        {
            if (products.ContainsKey(product))
            {
                if (products[product] == 0)
                {
                    MessageBox.Show("Нет в наличии!");
                }
                else if (products[product] < count)
                {
                    MessageBox.Show($"В наличии только {products[product]}");
                }
                else
                {
                    products[product]-=count;
                }
            }
            else
            {
                MessageBox.Show("Товар не найден!");
            }
        }
        //Ищет товар с заданным именем чтобы после продать его
        public void Sell(string ProductName , int count)
        {
            Product ToSell = FindByName(ProductName);
            if (ToSell != null)
            {
                this.Sell(ToSell, count);
            }
            else
            {
                MessageBox.Show("Товар не найден!");
            }
        }
        //Ищет товар по имени
        public Product FindByName(string name)
        {
            foreach (var product in products.Keys)
            {
                if (product.Name == name)
                {
                    return product;
                }
            }
            return null;
        }
    }
}
