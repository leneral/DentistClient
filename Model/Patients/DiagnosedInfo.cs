using System.Collections;

namespace Model.Patients
{
    //治疗信息
    public struct DiagnosedInfo
    {
        public string CaseNo;
        public string PatientName;
        public string Writer;
        public string Filltime;

        public string Type;
        public string Score;

        public string PersonalContext ;
        public string SickHistoryNow;
        public string SickHistoryBefore;
        public string KeyWords;

        public string CheckInfo;
        public string DiagnoseInfo;
        public string CureInfo;

        public string Picture;

        public Hashtable ToHashtable()
        {
            var hs = new Hashtable();
            if (PersonalContext != string.Empty)
            {
                hs.Add("主诉:", PersonalContext);
            }
            if (SickHistoryBefore != string.Empty)
            {
                hs.Add("既往史:", SickHistoryBefore);
            }
            if (SickHistoryNow != string.Empty)
            {
                hs.Add("现病史:", SickHistoryNow);
            }
            if (KeyWords != string.Empty)
            {
                hs.Add("关键字:", KeyWords);
            }
            if (DiagnoseInfo != string.Empty)
            {
                hs.Add("诊断:", DiagnoseInfo);
            }
            if (CheckInfo != string.Empty)
            {
                hs.Add("检查:", CheckInfo);
            }
            if (CureInfo != string.Empty)
            {
                hs.Add("治疗:", CureInfo);
            }
            return hs;
        }
    }
}
