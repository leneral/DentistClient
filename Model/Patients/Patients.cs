using System;

namespace Model.Patients
{
    public class Patients
    {
        public Patients(PatientsInfo patients)
        {
            CaseNo = patients.CaseNo;
            PatientsName = patients.Name;
            Sex = patients.Sex;
            Age = patients.Age;
            From = patients.From;
            Birthtime = patients.Birthtime;
            Folk = patients.Folk;
            School = patients.School;
            Phone = patients.Phone;
            Mobilephone = patients.Mobilephone;
            Email = patients.Email;
            Address = patients.Address;
            FavorMatter = patients.FavorMatter;
            DislikeMatter = patients.DislikeMatter;
            Cooperation = patients.Cooperation;
            SelfControl = patients.SelfControl;
            Other = patients.Other;
        }

        public string CaseNo { get; set; }
        public string PatientsName { get; set; }
        public int Sex { get; set; }
        public int Age { get; set; }
        public string From { get; set; }
        public DateTime Birthtime { get; set; }
        public string Folk { get; set; }
        public string School { get; set; }
        public string Phone { get; set; }
        public string Mobilephone { get; set; }
        public string Email{ get; set; }
        public string Address { get; set; }
        public string FavorMatter { get; set; }
        public string DislikeMatter { get; set; }
        public string Cooperation { get; set; }
        public string SelfControl { get; set; }
        public string Other { get; set; }
        public string Picture { get; set; }
    }
}
