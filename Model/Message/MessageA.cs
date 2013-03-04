using System.Windows.Forms;

namespace Model.Message
{
    public class MessageA
    {
        public static DialogResult ShowMessage(string msg)
        {
            return MessageBox.Show(msg);
        }

        public static DialogResult ShowMessage(string text, string caption, MessageBoxButtons buttons, MessageBoxIcon icon)
        {
            return MessageBox.Show(text, caption, buttons, icon);
        }
    }
}