using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.PerformanceData;
using System.Numerics;
using System.Xml.Linq;
using System.Text.Json;
using Newtonsoft.Json;
using System.Windows.Forms;


namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        XDocument xdoc;
        XDocument xdoc_;
        string documentName;
        string documentName_;
        public static List<List<string>> listData_tabPage1;
        public static List<List<string>> listData_tabPage2;

        static public int countPatients;
        private int countOperation;

        string path;
        string jsonString;

        private JsonBody? jsonBody;

        string filePath;

        public Form1()
        {
            InitializeComponent();
            jsonBody = new JsonBody();

            path = Path.Combine(Environment.CurrentDirectory, "setting.json");

            if (File.Exists(path))
                jsonString = File.ReadAllText(path);
            else 
                jsonString = Newtonsoft.Json.JsonConvert.SerializeObject(jsonBody);

            jsonBody = Newtonsoft.Json.JsonConvert.DeserializeObject<JsonBody>(jsonString);

            xdoc = new XDocument();
            xdoc_ = new XDocument();

            listData_tabPage1 = new List<List<string>>();
            listData_tabPage2 = new List<List<string>>();

            GetCurrentInfo();

            countPatients = jsonBody.countPatients;
            countOperation = jsonBody.countOperations;

            dataGridView1.RowCount = 13;

            filePath = jsonBody.fileNamePath;
        }

        private void CreateDocument(out string documentName)
        {
            DateTime date = DateTime.Today.Date;
            string shortYear = date.ToString("yy");
            string shortMonth = date.ToString("MM");

            documentName = $"HM450001T45_{shortYear}{shortMonth}I{countOperation}"; // временно. нужно создавать новое название

            XElement zl_list = new XElement("ZL_LIST");

            XElement zglv = new XElement("ZGLV");
            XElement version = new XElement("VERSION", 2.2);
            XElement data = new XElement("DATA", DateTime.Today.Date.ToString("yyyy-MM-dd"));
            XElement fileName = new XElement("FILENAME", documentName);

            zglv.Add(version);
            zglv.Add(data);
            zglv.Add(fileName);

            XElement schet = new XElement("SCHET");
            XElement code = new XElement("CODE", 18730);
            XElement code_mo = new XElement("CODE_MO", 450001);
            XElement year = new XElement("YEAR", shortYear);
            XElement month = new XElement("MONTH", shortMonth);

            schet.Add(code);
            schet.Add(code_mo);
            schet.Add(year);
            schet.Add(month);

            zl_list.Add(zglv);
            zl_list.Add(schet);

            xdoc.Add(zl_list);
        }

        private void CreateDocument_(out string documentName_)
        {
            DateTime date = DateTime.Today.Date;
            string shortYear = date.ToString("yy");
            string shortMonth = date.ToString("MM");

            documentName_ = $"LM450001T45_{shortYear}{shortMonth}I{countOperation}"; // временно. нужно создавать новое название

            XElement pers_list = new XElement("PERS_LIST");

            XElement zglv = new XElement("ZGLV");
            XElement version = new XElement("VERSION", 2.2);
            XElement data = new XElement("DATA", DateTime.Today.Date.ToString("yyyy-MM-dd"));
            XElement fileName = new XElement("FILENAME", documentName);
            XElement fileName1 = new XElement("FILENAME1", documentName_);

            zglv.Add(version);
            zglv.Add(data);
            zglv.Add(fileName);
            zglv.Add(fileName1);

            pers_list.Add(zglv);

            xdoc_.Add(pers_list);
        }

        private void CreateBodyDocument()
        {
            AddToTable();

            for (int i = 0; i < listData_tabPage1.Count; ++i)
            {
                CreateBlock(i);
            }

            for (int i = 0; i < listData_tabPage2.Count; ++i)
            {
                CreateBlock_(i);
            }

            listData_tabPage1.Clear();
            listData_tabPage2.Clear();
        }

        private void AddToTable()
        {
            if (listData_tabPage1.Count == 0 || listData_tabPage1[0].Count == 0) return;

            for (int i = 0; i < listData_tabPage1.Count; ++i)
            {
                for (int j = 0; j < listData_tabPage1[0].Count; ++j)
                {
                    dataGridView1.Rows[i].Cells[j].Value = listData_tabPage1[i][j];
                }
            }
        }

        public void IncreaseRows()
        {
            if (dataGridView1.RowCount <= countPatients)
                for (int i = 0; i < countPatients - dataGridView1.RowCount; ++i)
                    dataGridView1.Rows.Add();
        }

        private void CreateBlock(int index)
        {
            XElement zap = new XElement("ZAP");

            XElement n_zap = new XElement("N_ZAP", listData_tabPage1[index][0]);
            XElement pr_now = new XElement("PR_NOW", listData_tabPage1[index][1]);

            XElement pacient = new XElement("PACIENT");
            XElement id_pac = new XElement("ID_PAC", listData_tabPage1[index][2]);
            XElement vpolis = new XElement("VPOLIS", listData_tabPage1[index][3]);
            XElement mpolis = new XElement("MPOLIS", listData_tabPage1[index][4]);
            XElement st_okato = new XElement("ST_OKATO", listData_tabPage1[index][5]);
            XElement novor = new XElement("NOVOR", listData_tabPage1[index][6]);

            XElement sluch = new XElement("SLUCH");
            XElement idcase = new XElement("IDCASE", listData_tabPage1[index][7]);
            XElement date_1 = new XElement("DATE_1", listData_tabPage1[index][8]);
            XElement date_2 = new XElement("DATE_2", listData_tabPage1[index][9]);
            XElement usl_ok = new XElement("USL_OK", listData_tabPage1[index][10]);

            pacient.Add(id_pac);
            pacient.Add(vpolis);
            pacient.Add(mpolis);
            pacient.Add(st_okato);
            pacient.Add(novor);

            sluch.Add(idcase);
            sluch.Add(date_1);
            sluch.Add(date_2);
            sluch.Add(usl_ok);

            zap.Add(n_zap);
            zap.Add(pr_now);
            zap.Add(pacient);
            zap.Add(sluch);

            xdoc.Root.Add(zap);
        }

        private void CreateBlock_(int index)
        {
            XElement pers = new XElement("PERS");

            XElement id_pac = new XElement("ID_PAC", listData_tabPage1[index][2]);

            XElement fam = new XElement("FAM", listData_tabPage2[index][0]);
            XElement im = new XElement("IM", listData_tabPage2[index][1]);
            XElement ot = new XElement("OT", listData_tabPage2[index][2]);
            XElement w = new XElement("W", listData_tabPage2[index][3] == "ћ" ? 1 : 2);
            XElement dr = new XElement("DR", listData_tabPage2[index][4]);
            XElement doctype = new XElement("DOCTYPE", listData_tabPage2[index][5]);
            XElement docser = new XElement("DOCSER", listData_tabPage2[index][6]);
            XElement docnum = new XElement("DOCNUM", listData_tabPage2[index][7]);
            XElement snils = new XElement("SNILS", listData_tabPage2[index][8]);
            XElement otatog = new XElement("OKATOG", listData_tabPage2[index][9]);
            XElement okatop = new XElement("OKATOP", listData_tabPage2[index][10]);
            XElement kladrg = new XElement("KLADRG", listData_tabPage2[index][11]);
            XElement kladrp = new XElement("KLADRP", listData_tabPage2[index][12]);

            pers.Add(id_pac);
            pers.Add(fam);
            pers.Add(im);
            pers.Add(ot);
            pers.Add(w);
            pers.Add(dr);
            pers.Add(doctype);
            pers.Add(docser);
            pers.Add(docnum);
            pers.Add(snils);
            pers.Add(otatog);
            pers.Add(okatop);
            pers.Add(kladrg);
            pers.Add(kladrp);

            xdoc_.Root.Add(pers);
        }

        private void SaveDocument()
        {
            xdoc.Save($"{filePath}\\{documentName}.xml");
            xdoc_.Save($"{filePath}\\{documentName_}.xml");

            MessageBox.Show($"{filePath}\\{documentName}.xml");

            SaveCurrentInfo();
        }

        private async void SaveCurrentInfo()
        {
            jsonBody.countPatients = countPatients;
            jsonBody.countOperations = ++countOperation;

            jsonString = Newtonsoft.Json.JsonConvert.SerializeObject(jsonBody);
            File.WriteAllText(path, jsonString);
        }

        private async void GetCurrentInfo()
        {
            countPatients = jsonBody.countPatients;
            countOperation = jsonBody.countOperations;
        }

        private void открытьћесто’ранени€ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("explorer.exe", filePath);
        }

        private void задатьѕапку—охранени€ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.Cancel)
                return;
            // получаем выбранный файл
            filePath = folderBrowserDialog1.SelectedPath;

            jsonBody.fileNamePath = filePath;
            jsonString = Newtonsoft.Json.JsonConvert.SerializeObject(jsonBody);
            File.WriteAllText(path, jsonString);
        }

        private void добавить«аписьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 addPacient = new Form2();
            addPacient.ShowDialog();
            if (listData_tabPage1.Count > 0)
                AddToTable();
        }

        private void сгенерироватьXMLToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CreateDocument(out documentName);
            CreateDocument_(out documentName_);
            CreateBodyDocument();
            SaveDocument();
        }
    }
}