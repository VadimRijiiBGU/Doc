using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Office.Interop.Word;

namespace WindowsFormsApp1
{
    public partial class DocForm : Form
    {
        Microsoft.Office.Interop.Word.Application app = new Microsoft.Office.Interop.Word.Application();
        Document doc;

        public struct My_Row
        {
            public string name;
            public string number;
            public DateTime date;
            public int result;
        }

        DateTimePicker dtp = new DateTimePicker();
        System.Drawing.Rectangle _Rectangle;

        List<My_Row> rows_list = new List<My_Row>();

        public DocForm()
        {
            InitializeComponent();
            dataGridView1.Controls.Add(dtp);
            dtp.Visible = false;
            dtp.Format = DateTimePickerFormat.Custom;
            dtp.TextChanged += new EventHandler(dtp_TextChange);

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void openDoc_Click(object sender, EventArgs e)
        {
            var fileContent = string.Empty;
            var filePath = string.Empty;

            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = @"E:\Study\BankBusiness";
                openFileDialog.Filter = "Office Files|*.docx;*.dotx";
                //  openFileDialog.FilterIndex = 2;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    //Get the path of specified file
                    filePath = openFileDialog.FileName;

                    doc = app.Documents.Add(filePath);

                }
            }

        }

        private void createDoc_Click(object sender, EventArgs e)
        {
            // ConsoleManager.Show();
            Table table = doc.Tables[1];
            My_Row[] my_Rows;



            Console.WriteLine(dataGridView1.Rows.Count);
            for (int rows = 0; rows < dataGridView1.Rows.Count - 1; rows++)
            {
                My_Row row_adding;
                row_adding.number = dataGridView1.Rows[rows].Cells["AttestateNum"].Value.ToString();
                row_adding.name = dataGridView1.Rows[rows].Cells["DisciplineName"].Value.ToString();
                row_adding.result = Int32.Parse(dataGridView1.Rows[rows].Cells["Result"].Value.ToString());
                row_adding.date = DateTime.Parse(dataGridView1.Rows[rows].Cells["Date"].Value.ToString());
                rows_list.Add(row_adding);
            }
            for (int j = 0; j < rows_list.Count - 1; j++)
            {
                table.Rows.Add(table.Rows[table.Rows.Count]);
            }

            my_Rows = rows_list.ToArray();



            int i = -1;

            foreach (Row row in table.Rows)
            {
                foreach (Cell cell in row.Cells)
                {
                    Console.WriteLine(i);
                    if (cell.RowIndex != 1)
                    {
                        switch (cell.ColumnIndex)
                        {
                            case 1:
                                {
                                    cell.Range.Text = my_Rows[i].number;
                                    break;
                                }
                            case 2:
                                {
                                    cell.Range.Text = my_Rows[i].name;

                                    break;
                                }
                            case 3:
                                {
                                    cell.Range.Text = my_Rows[i].result.ToString();
                                    break;
                                }
                            case 4:
                                {
                                    cell.Range.Text = my_Rows[i].date.ToString().Substring(0, 10);
                                    break;
                                }
                        }
                        cell.VerticalAlignment = WdCellVerticalAlignment.wdCellAlignVerticalCenter;
                    }

                }
                i++;
            }
            foreach (Microsoft.Office.Interop.Word.FormField field in doc.FormFields)
            {
                switch (field.Name)
                {
                    case "number":
                        field.Range.Text = numberTextBox.Text;
                        break;
                            
                    case "date":
                        field.Range.Text = dateTimePicker1.Value.ToString().Substring(0,10);
                        break;

                    case "personName":
                        field.Range.Text = nameTextBox.Text;
                        break;

                    default:
                        break;
                }
            }
        
            app.Visible = true;
    
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            doc.Save();
            doc.Close();
            app.Quit();
            try
            {
               
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
               // app.Quit();
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void nameLabel_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            switch (dataGridView1.Columns[e.ColumnIndex].Name)
            {
                case "Date":
                    _Rectangle = dataGridView1.GetCellDisplayRectangle(e.ColumnIndex, e.RowIndex, true);
                    dtp.Size = new Size(_Rectangle.Width, _Rectangle.Height);
                    dtp.Location = new System.Drawing.Point(_Rectangle.X, _Rectangle.Y);
                    dtp.Visible = true;

                    break;
            }
        }

        private void dtp_TextChange(object sender, EventArgs e)
        {
            dataGridView1.CurrentCell.Value = dtp.Text.ToString();
        }

        private void dataGridView1_ColumnWidthChanged(object sender, DataGridViewColumnEventArgs e)
        {
            dtp.Visible = false;
        }

        private void dataGridView1_Scroll(object sender, ScrollEventArgs e)
        {
            dtp.Visible = false;
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void generate_Click(object sender, EventArgs e)
        {
            int counter = -1;
            if (!Int32.TryParse(generateCountTextBox.Text, out counter))
            {

            }

            Console.WriteLine(counter);

            dataGridView1.RowCount = counter + 1;

            Random random = new Random();
            for (int j = 0; j < counter; j++)
            {
                int res = random.Next(0, counter - 1);
                int name_int = random.Next(0, counter - 1);
                DateTime start = new DateTime(1995, 1, 1);
                int range = (DateTime.Today - start).Days;
                int price = random.Next(1, 100000);

                dataGridView1.Rows[j].Cells[0].Value = random.Next(0, counter - 1);
                dataGridView1.Rows[j].Cells[1].Value = "name" + name_int.ToString();
                dataGridView1.Rows[j].Cells[2].Value = random.Next(1, 10);
                dataGridView1.Rows[j].Cells[3].Value = start.AddDays(random.Next(range)).ToString().Substring(0, 10);

            }
        }

        private void numberTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void generateCountLabel_Click(object sender, EventArgs e)
        {

        }

        private void dateLabel_Click(object sender, EventArgs e)
        {

        }

        private void numberLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
