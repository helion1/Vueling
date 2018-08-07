using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ServiceStack.Redis;
using ServiceStack.Redis.Generic;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace RedisCRUD {
    public partial class Form1 : MetroFramework.Forms.MetroForm {
        public Form1() {
            InitializeComponent();
        }

        void Edit(bool value) {
            textBox1.ReadOnly = value;
            textBox2.ReadOnly = value;
            textBox3.ReadOnly = value;
        }

        private void Form1_Load(object sender, EventArgs e) {
            using (RedisClient client = new RedisClient("localhost", 6379)) {
                IRedisTypedClient<Phone> phone = client.As<Phone>();
                phoneBindingSource.DataSource = phone.GetAll();
                Edit(true);//Read only
            }
        }

        private void label1_Click(object sender, EventArgs e) {

        }

        private void button1_Click(object sender, EventArgs e) {
            Edit(true);//Read only
            phoneBindingSource.ResetBindings(false);
            ClearText();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e) {

        }

        private void button3_Click(object sender, EventArgs e) {
            Edit(false);//Allow edit
            textBox1.Focus();
        }

        private void button4_Click(object sender, EventArgs e) {





            phoneBindingSource.Add(new Phone());
            phoneBindingSource.MoveLast();
            Edit(false);//Allow edit
            textBox1.Focus();
        }

        private void button2_Click(object sender, EventArgs e) {
            if (MetroFramework.MetroMessageBox.Show(this, "Are you sure want to delete this record ?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) {
                Phone p = phoneBindingSource.Current as Phone;//Get current object
                if (p != null) {
                    //Connect to your redis cache
                    using (RedisClient client = new RedisClient("localhost", 6379)) {
                        IRedisTypedClient<Phone> phone = client.As<Phone>();
                        phone.DeleteById(p.ID);//Delete data by id
                        phoneBindingSource.RemoveCurrent();
                    }
                }
            }
        }

        private void button5_Click(object sender, EventArgs e) {

        }
    }
}
