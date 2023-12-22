using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace AppTrackVSProj
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            dataGridView.RowsAdded += DataGridView_RowsAdded;
            dataGridView.RowsRemoved += DataGridView_RowsRemoved;
        }

        //private void DataGridView_RowsRemoved(object? sender, DataGridViewRowsRemovedEventArgs e)
        //{
        //    throw new NotImplementedException();
        //}

        //private void DataGridView_RowsAdded(object? sender, DataGridViewRowsAddedEventArgs e)
        //{
        //    throw new NotImplementedException();
        //}

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var myForm = new Form2();
            myForm.Show();
            myForm.ButtonSaveClicked += form2_saveRequest;
        }

        private void form2_saveRequest(object sender, EventArgs e)
        {
            //TODO : this can be improved in multiple ways.
            string id = Guid.NewGuid().ToString();
            dataGridView.Rows.Add(Form2.position, Form2.company, Form2.date, Form2.status, Form2.details , id);
            //DB operation = add
            SentApplication item = new SentApplication();
            item.Id = id; // we will use guid for id generation
            item.PositionName = Form2.position;
            item.Company = Form2.company;
            item.Date = Form2.date;
            item.Status = Form2.status;
            item.Details = Form2.details;
            repo.InsertItem(item);
            //end of DB operation
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow item in this.dataGridView.SelectedRows)
            {
                //DB operation = delete
                repo.DeleteItem(item.Cells[5].Value.ToString());
                //end of DB operation
                dataGridView.Rows.RemoveAt(item.Index);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if(dataGridView.SelectedRows.Count != 1)
            {
                MessageBox.Show("You can update only 1 selected row");
            }
            else
            {
                DataGridViewRow selectedRow = dataGridView.SelectedRows[0];
                switch (selectedRow.Cells[3].Value.ToString())
                {
                    case "Application sent":
                        selectedRow.Cells[3].Value = "First interview scheduled";
                        break;
                    case "First interview scheduled":
                        selectedRow.Cells[3].Value = "Technical interview scheduled";
                        break;
                    case "Technical interview scheduled":
                        selectedRow.Cells[3].Value = "Contract negotiations scheduled";
                        break;
                    case "Contract negotiations scheduled":
                        selectedRow.Cells[3].Value = "Reciveded offer";
                        break;
                    case "Reciveded offer":
                        selectedRow.Cells[3].Value = "Accepted offer";
                        break;
                }
                //TODO : this can be improved in multiple ways
                //DB-Operation :
                SentApplication dbEntry = new SentApplication(selectedRow.Cells[5].Value.ToString(),
                                                              selectedRow.Cells[0].Value.ToString(),
                                                              selectedRow.Cells[1].Value.ToString(),
                                                              selectedRow.Cells[2].Value.ToString(),
                                                              selectedRow.Cells[3].Value.ToString(),
                                                              selectedRow.Cells[4].Value.ToString());
                repo.UpdateItem(dbEntry);

            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow item in this.dataGridView.Rows)
            {
                bool possibleFind = false;
                for (int i =1; i<5; i++)
                {
                    if (item.Cells[i].Value.ToString() == searchTextBox.Text)
                    {
                        possibleFind = true;
                    }
                }
                if(!possibleFind) 
                {
                    item.Visible = false;
                }
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow item in this.dataGridView.Rows)
            {
                item.Visible = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView.Rows.Add(1, 1, 1, "Application sent", 1);
            dataGridView.Rows.Add(2, 2, 2, "Application sent", 2);
            dataGridView.Rows.Add(3, 3, 3, "Application sent", 3);
            dataGridView.Rows.Add(4, 4, 4, "Application sent", 4);
            dataGridView.Rows.Add(5, 5, 5, "Application sent", 5);
            dataGridView.Rows.Add(6, 6, 6, "Application sent", 6);
            dataGridView.Rows.Add(7, 7, 7, "Application sent", 7);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            List<SentApplication> dbData = repo.GetAllItems();
            foreach(SentApplication elem in dbData)
            {
                dataGridView.Rows.Add(elem.PositionName, elem.Company, elem.Date, elem.Status, elem.Details, elem.Id) ;
                progressBar.Increment(1);
            }
            if(dbData.Count < 25 ) { progressBar.Maximum = 25; }
            else if (dbData.Count >= 25 && dbData.Count < 50) { progressBar.Maximum = 50; } 
            else if (dbData.Count >= 50 && dbData.Count < 100) { progressBar.Maximum = 100; }
            else if (dbData.Count >= 100 && dbData.Count < 200) { progressBar.Maximum = 200; }
            else if (dbData.Count >= 200 && dbData.Count < 250) { progressBar.Maximum = 250; }
            else if (dbData.Count >= 250 && dbData.Count < 500) { progressBar.Maximum = 500; }
            else if (dbData.Count >= 500 && dbData.Count < 750) { progressBar.Maximum = 750; }
            else if (dbData.Count >= 750 && dbData.Count < 1000) { progressBar.Maximum = 1000; }

            progressBarHighVal.Text = progressBar.Maximum.ToString();
        }
        public int getNextProgressMaximum(int oldMax)
        {
            switch (oldMax)
            {
                case 25:
                    return 50;
                    break;
                case 50:
                    return 100;
                    break;
                case 100:
                    return 200;
                    break;
                case 200:
                    return 250;
                    break;
                case 250:
                    return 500;
                    break;
                case 500:
                    return 750;
                    break;
                case 750:
                    return 1000;
                    break;
                default:
                    return 1000;
            }
        }
        private void DataGridView_RowsAdded(object? sender, DataGridViewRowsAddedEventArgs e)
        {
            progressBar.Increment(1);
            if(progressBar.Value >= progressBar.Maximum)
            {
                progressBar.Maximum = getNextProgressMaximum(progressBar.Maximum);
                progressBarHighVal.Text = progressBar.Maximum.ToString();
            }
        }

        private void DataGridView_RowsRemoved(object? sender, DataGridViewRowsRemovedEventArgs e)
        {
            int newVal = progressBar.Value - 1 ;
            progressBar.Value = newVal;
        }

        private void buttonProgressBarTest_Click(object sender, EventArgs e)
        {
        
                dataGridView.Rows.Add(1, 1, 1, "Application sent", 1);
                dataGridView.Rows.Add(2, 2, 2, "Application sent", 2);
                dataGridView.Rows.Add(3, 3, 3, "Application sent", 3);
                dataGridView.Rows.Add(4, 4, 4, "Application sent", 4);
                dataGridView.Rows.Add(5, 5, 5, "Application sent", 5);
                dataGridView.Rows.Add(6, 6, 6, "Application sent", 6);
                dataGridView.Rows.Add(7, 7, 7, "Application sent", 7);
        }
    }
}