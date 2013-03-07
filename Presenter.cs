using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using Model.Patients;

namespace DentistryClient
{
    public class Presenter
    {
        public Image ReadImage()
        {
            var ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                return Image.FromFile(ofd.FileName);
            }
            return null;
        }

        public PatientsInfo Dt2PatientsInfo(DataTable dt)
        {
           return new PatientsInfo
                {
                    CaseNo = dt.Rows[0][0].ToString(),
                    Name = dt.Rows[0][1].ToString(),
                    Sex = dt.Rows[0][2].ToString() == "1" ? Convert.ToByte(1) : Convert.ToByte(0),
                    Age = int.Parse(dt.Rows[0][3].ToString()),
                    From = dt.Rows[0][4].ToString(),
                    Birthtime = Convert.ToDateTime(dt.Rows[0][5].ToString()),
                    Folk = dt.Rows[0][6].ToString(),
                    Phone = dt.Rows[0][7].ToString(),
                    Mobilephone = dt.Rows[0][8].ToString(),
                    School = dt.Rows[0][9].ToString(),
                    Address = dt.Rows[0][10].ToString(),
                    Email = dt.Rows[0][11].ToString(),
                    FavorMatter = dt.Rows[0][12].ToString(),
                    DislikeMatter = dt.Rows[0][13].ToString(),
                    Cooperation = dt.Rows[0][14].ToString(),
                    SelfControl = dt.Rows[0][15].ToString(),
                    Other = dt.Rows[0][16].ToString(),
                    Picture = dt.Rows[0][19].ToString()
                };
        }
    }
}