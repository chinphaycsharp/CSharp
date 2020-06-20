using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace readXML
{
    public partial class Service1 : ServiceBase
    {
        public MySqlConnection conn;
        public MySqlDataAdapter adapter;
        public DataSet dt = new DataSet();

        public Service1()
        {
            InitializeComponent();
        }

        protected override void OnStart(string[] args)
        {
        }

        protected override void OnStop()
        {
        }

        public void search(Service1 obj)
        {
            obj.OnStart(null);           
            conn = new MySqlConnection("server=localhost;user id=root;database=medical;pwd=123456");
            Console.Read();
            dt.ReadXml(@"D:\mySQL\report_his\20200604_55981.xml",XmlReadMode.Auto);
            int userID = 0;
            string result = "";
            string proposal = "";
            string descttext = "";
            DateTime aprotime = DateTime.Now;
            int aprovebyID = 0;
            foreach (DataRow item in dt.Tables[0].Rows)
            {
                userID = (int)item["MaBacSiKetLuan"];
                result = item["KetLuan"].ToString();
                proposal = item["DeNghi"].ToString();
                descttext = item["MoTa"].ToString();
                aprotime = (DateTime)item["ThoiGianThucHien"];
                aprovebyID = (int)item["MaBacSiKetLuan"];
            }
            conn.Open();
            var queryselect = "select * from m_study where OrgCode = " + userID;
            MySqlCommand mySql = new MySqlCommand(queryselect,conn);
            int id = mySql.ExecuteNonQuery();
            if(id > 0)
            {
                conn.Close();
                conn = new MySqlConnection("server=localhost;user id=root;database=medical;pwd=123456");
                var query = "insert into m_study(UserID,Result,Proposal,DescTxt,AproTime,AproveByID) values (UserID = '" + userID + "',Result = '" + result + "',Proposal = '" + proposal + "',DescTxt ='" + descttext + "',AproTime = '" + aprotime + "',AproveByID = '" + aprovebyID + "')";
            }
            else
            {

            }
        }

        //private void readFileXML()
        //{
        //    //var path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
        //    var path = @"D:\mySQL\report_his";

        //    foreach (var file in System.IO.Directory.GetFiles(path))
        //    {
        //        ProcessFile(file);
        //    }
        //}

        //static void ProcessFile(string Filename)
        //{
        //    // do processing here...

        //}

        internal void StartService()
        {
            /* 
                This is the true composition root for a service,
                so initialize everything in here
            */
            Console.WriteLine("Starting service");
        }
    }
}
