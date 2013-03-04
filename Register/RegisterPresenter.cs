using System;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using Model.ImageManager;
using Model.Message;
using Model.Patients;
using Model.Util;

namespace DentistryClient.Register
{
    public class RegisterPresenter : Presenter
    {
        private readonly ViewLoader _loader = new ViewLoader();
        private bool _saved;
        public IRegisterView View { get; set; }

        public void GenNewCaseno()
        {
            DataTable dt = PatientsService.QueryCaseNo();

            UInt32 maxVal = 0;
            foreach (DataRow r in dt.Rows)
            {
                UInt32 val = Convert.ToUInt32(r[0].ToString());
                if (val > maxVal)
                    maxVal = val;
            }
            View.CaseNo = Numeric.UInt2String(maxVal + 1);
        }

        public void OnSave()
        {
            var reg = new Regex("^[0-9]+$");  
            if (View.CaseNo == string.Empty)
            {
                MessageA.ShowMessage("对不起, 病例号不能为空！");
                return;
            }
            if (View.PatientsName == string.Empty)
            {
                MessageA.ShowMessage("对不起，姓名不能为空！");
                return;
            }
            if (View.From == string.Empty)
            {
                MessageA.ShowMessage("对不起，诊所或医院不能为空！");
                return;
            }
            var ma = reg.Match(View.CaseNo);
            if (!ma.Success)
            {
                MessageA.ShowMessage("病历号必须全为数字！");
                return;
            }

            var dt = PatientsService.QueryCaseNo();
            if (dt.Rows.Cast<DataRow>().Any(dr => dr[0].ToString() == View.CaseNo))
            {
                MessageA.ShowMessage("病历号已存在，请从新输入！");
                return;
            }

            var patientsInfo = new PatientsInfo
                {
                    CaseNo = View.CaseNo,
                    Name = View.PatientsName,
                    Age = View.Age,
                    Birthtime = View.BirthTime,
                    From = View.From,
                    Sex = View.Sex,
                    Folk = View.Folk,
                    School = View.School,
                    Phone = View.Phone,
                    Mobilephone = View.Mobilephone,
                    Email = View.Email,
                    Address = View.Address,
                    FavorMatter = View.FavorMatter,
                    DislikeMatter = View.DislikeMatter,
                    Cooperation = View.Cooperation,
                    SelfControl = View.SelfControl,
                    Other = View.Other,
                };
            if (View.Picture != null)
            {
                patientsInfo.Picture = Convert.ToBase64String(ImageManager.GetBytes(View.Picture));
            }

            _saved = PatientsService.SavePersonalInfo(new Patients(patientsInfo));
            if (_saved)
            {
                MessageA.ShowMessage("保存成功");
                View.RegisterCallback();
                View.Exit();
            }
            else
            {
                MessageA.ShowMessage("对不起，保存失败");
            }
        }

        public void ShowPatientInfoDlg(PatientsInfo info)
        {
            View.CaseNo = info.CaseNo;
            View.PatientsName = info.Name;
            View.Sex = info.Sex;
            View.Age = info.Age;
            View.BirthTime = info.Birthtime;
            View.Folk = info.Folk;
            View.School = info.School;
            View.Phone = info.Phone;
            View.Mobilephone = info.Mobilephone;
            View.Email = info.Email;
            View.Address = info.Address;
            View.FavorMatter = info.FavorMatter;
            View.DislikeMatter = info.DislikeMatter;
            View.Cooperation = info.Cooperation;
            View.SelfControl = info.SelfControl;
            View.Other = info.Other;

            if (info.Picture != string.Empty)
            {
                //var imageInfo = ToHashtable.FromBase64String(info.Picture);
                //View.Picture = Image.FromStream(new MemoryStream(imageInfo));
            }
            _loader.ModifyRegisterView(info);
        }

        public void OnClose()
        {
            if (_saved)
                View.Exit();
            else if (View.PatientsName != string.Empty)
            {
                DialogResult dlgResult = MessageA.ShowMessage(
                    "您还没有保存数据，现在关闭将丢失数据，是否确定关闭？",
                    "提示",
                    MessageBoxButtons.OKCancel,
                    MessageBoxIcon.Question
                    );
                if (dlgResult == DialogResult.OK)
                    View.Exit();
            }
            else
            {
                View.Exit();
            }
        }

        public Image GetDefaultImage(string path)
        {
            return File.Exists(path) ? Image.FromFile(path) : null;
        }
    }
}