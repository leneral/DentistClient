using System.Data;
using Model.Database;

namespace Model.Template
{
    public class TemplateService
    {
        public DataTable SelectTemplate(int id)
        {
            string cmd = null;
            switch (id)
            {
                case 0:
                    cmd = @"Select * from [sickhistorytemplate]";
                    break;
                case 1:
                    cmd = @"Select * from [checktemplate]";
                    break;
                case 2:
                    cmd = @"Select * from [diagnosetemplate]";
                    break;
                case 3:
                    cmd = @"Select * from [curetemplate]";
                    break;
            }
            return DbSingleton.Instance.RunQuery(cmd);
        }
    }
}
