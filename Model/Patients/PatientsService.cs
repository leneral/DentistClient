using System;
using System.Configuration;
using System.Data;
using System.Data.Common;
using System.Data.OleDb;
using System.Data.SqlClient;
using Model.Database;

namespace Model.Patients
{
    public class PatientsService
    {
        public static bool SavePersonalInfo(Patients patients)
        {
            string cmd =
                string.Format(
                    @"INSERT INTO patientInfo(caseno, patientname, sex, age, fromHosp, birthday, folk, phone, mobilephone, school, address, email, favorMatter, dislikeMatter, cooperation, selfregulating, other, registerDate, registerHour,photo) " +
                    @"VALUES ('{0}', '{1}', {2}, {3}, '{4}', '{5}', '{6}', '{7}', '{8}','{9}', '{10}', '{11}','{12}', '{13}', '{14}', '{15}', '{16}','{17}','{18}', '{19}')",
                    patients.CaseNo, patients.PatientsName, patients.Sex, patients.Age, patients.From,
                    patients.Birthtime.ToString("MM/dd/yyyy"),
                    patients.Folk, patients.Phone, patients.Mobilephone,
                    patients.School, patients.Address, patients.Email,
                    patients.FavorMatter, patients.DislikeMatter,
                    patients.Cooperation, patients.SelfControl,
                    patients.Other, DateTime.Now.Date.ToShortDateString(),
                    DateTime.Now.Hour, patients.Picture);

            RunNoQuery(cmd);

            return true;
        }

        public static bool SavePreliminaryInfo(PreliminaryInfo info)
        {
            string cmd =
                string.Format(
                    @"INSERT INTO info(caseno, patientname, facewoundhistory,iscuring, type, degree, phase, caseexcluded, datetimepreliminary)" +
                    @"VALUES ('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}', '{8}')",
                    info.CaseNo,
                    info.PatientName,
                    info.FaceWoundHistory,
                    info.IsCuring,
                    info.Type,
                    info.Extent,
                    info.Periods,
                    info.ExludedCases,
                    info.PreliminaryDate.ToString("MM/dd/yyyy"));
            RunNoQuery(cmd);

            return true;
        }

        public static bool SaveDiagnosedInfo(DiagnosedInfo info)
        {
            string cmd =
                string.Format(
                    @"INSERT INTO info(caseno, patientname, writer, filltime, type, score, personalcontext, sickhistorynow,sickhistorybefore,keywords,checkinfo,diagnoseinfo,cureinfo,picture)" +
                    @"VALUES ('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}','{9}', '{10}', '{11}','{12}', '{13}')",
                    info.CaseNo, info.PatientName, info.Writer, info.Filltime, info.Type, info.Score,
                    info.PersonalContext, info.SickHistoryNow,
                    info.SickHistoryBefore, info.KeyWords,
                    info.CheckInfo, info.DiagnoseInfo, info.CureInfo, info.Picture);

           RunNoQuery(cmd);
            return true;
        }

        public static bool SaveOrderInfo(OrderInfo info)
        {
            string cmd = string.Format(
                @"INSERT INTO orderInfo(caseno, patientname, doctorname, ndays, orderdatetime, ordercontext, mobilephone, msgstate, orderstate)" +
                @"VALUES ('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}')",
                info.CaseNo,
                info.PatientName,
                info.DoctorName,
                info.NDays,
                info.OrderDatetime,
                info.OrderContext,
                info.MobilePhone,
                info.MsgState,
                info.OrderState);
            RunNoQuery(cmd);
            return true;
        }

        public static bool DeleteOrder(string caseno)
        {
            string cmd = string.Format(
                @"DELETE FROM orderInfo WHERE caseno = '{0}'", caseno);

            RunNoQuery(cmd);
            return true;
        }

        public static bool ModifyOrderInfo(OrderInfo info)
        {
            string cmd = string.Format(
                @"UPDATE orderInfo SET doctorname = '{0}', orderdatetime = '{1}', ordercontext = '{2}' WHERE caseno = '{3}'",
                info.DoctorName, info.OrderDatetime, info.OrderContext, info.CaseNo);

           RunNoQuery(cmd);

            return true;
        }

        public static bool ModifyOrderState(string caseno, string state)
        {
            string cmd = string.Format(@"UPDATE orderInfo SET orderstate = '{0}' WHERE caseno = '{1}'", state, caseno);
            RunNoQuery(cmd);

            return true;
        }

        public static DataTable QuerOrders(DateTime fromDate, DateTime toDate, string doctor, string patientname)
        {
            string cmd = "SELECT * FROM [orderInfo]";

            cmd += string.Format(@" WHERE orderdatetime >= '{0}' and orderdatetime <= '{1}'",
                                 fromDate.ToLocalTime().ToString(), toDate.ToLocalTime().ToString());
            if (!string.IsNullOrEmpty(doctor))
            {
                cmd += string.Format(@" AND doctorname LIKE '%{0}%'", doctor);
            }
            if (!string.IsNullOrEmpty(patientname))
            {
                cmd += string.Format(@" AND patientname LIKE '%{0}%'", patientname);
            }

            return RunQuery(cmd);
        }

        public static DataTable QueryCaseNo()
        {
            string cmd = string.Format(@"SELECT caseno FROM [patientInfo]");
            return RunQuery(cmd);
        }

        public static DataTable QueryOrders(string item = "", string value = "")
        {
            string cmd = item != string.Empty
                             ? string.Format(@"SELECT * FROM [orderInfo] WHERE {0} like '%{1}%'  ", item, value)
                             : string.Format(@"SELECT * FROM [orderInfo]");

            return RunQuery(cmd);
        }

        public static DataTable QueryPatients(string item = "", string value = "")
        {
            string cmd = item != string.Empty
                             ? string.Format(@"SELECT * FROM [patientInfo] WHERE {0} like '%{1}%'  ", item, value)
                             : string.Format(@"SELECT * FROM [patientInfo]");

            return RunQuery(cmd);
        }

        public static DataTable EasyQueryPatients(string name, string caseno, byte sex, int age, string hospital)
        {
            var cond = new string[5];
            string cmd = @"SELECT * FROM [patientInfo]";

            if (!string.IsNullOrEmpty(name))
                cond[0] = string.Format(@" patientname LIKE '%{0}%'", name);
            if (!string.IsNullOrEmpty(caseno))
                cond[1] = string.Format(@" caseno = '{0}'", caseno);
            if (sex != 255)
                cond[2] = string.Format(@" sex = {0}", sex);
            if (age >= 0)
                cond[3] = string.Format(@" age = {0}", age);
            if (string.IsNullOrEmpty(hospital))
                cond[4] = string.Format(@" fromHosp LIKE '%{0}%'", hospital);

            bool flag = false;
            for (int i = 0; i < 5; i++)
            {
                if (!string.IsNullOrEmpty(cond[i]) && !flag)
                {
                    cmd += " WHERE";
                    flag = true;

                    cmd += cond[i];
                }
                else if (!string.IsNullOrEmpty(cond[i]))
                {
                    cmd += " AND" + cond[i];
                }
            }

            return RunQuery(cmd);
        }

        public static DataTable QueryPreliminaryInfo(string item, string value)
        {
            string cmd =
                string.Format(@"SELECT * FROM [preliminaryInfo] WHERE {0} = '%{1}%'", item, value);
            return RunQuery(cmd);
        }

        public static DataTable QueryDiagnosedInfo(string item, string value)
        {
            string cmd =
                string.Format(@"SELECT * FROM  [diagnosedInfo] WHERE  {0} LIKE '%{1}%'", item, value);
            return RunQuery(cmd);
        }

        public static void SaveSalaryInfo(SalaryInfo info)
        {
            string cmd = string.Format(
                @"INSERT INTO salaryInfo(caseno, generalCharge, cleanCharge,inmouthCharge,pulltoothCharge, surgeryCharge, 
                fixrestoreCharge, restoreCharge, orthodonticCharge, emitCharge, drugCharge, foreignmedicineCharge, planttoothCharge, otherCharge)" +
                @"VALUES('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}', '{7}', '{8}', '{9}', '{10}', '{11}', '{12}', '{13}')",
                info.CaseNo, info.GeneralCharge, info.CleanCharge, info.InMouthCharge,
                info.PullToothCharge, info.SurgeryCharge, info.FixRestoreCharge, 
                info.RestoreCharge, info.OrthodonticCharge, info.EmitCharge,
                info.DrugCharge, info.ForeignMedicineCharge, info.PlantToothCharge, info.OtherCharge);

            RunNoQuery(cmd);
        }

        public static DataTable QueryPrescriptions()
        {
            string cmd = string.Format(@"Select * From [prescriptiontemplate]");
            return RunQuery(cmd);
        }

        private static DataTable RunQuery(string cmd)
        {
            return DbSingleton.Instance.RunQuery(cmd);
        }

        private static void RunNoQuery(string cmd)
        {
            DbSingleton.Instance.RunNoQuery(cmd);
        }
    }
}