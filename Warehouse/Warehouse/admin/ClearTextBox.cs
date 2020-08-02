using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Warehouse
{
    class ClearTextBox
    {
        private TextBox textBoxName;
        private TextBox textBoxForname;
        private TextBox textBoxLogin;
        private TextBox textBoxPassword;
        private List<string> textBoxList;
        public ClearTextBox(TextBox textBoxName, TextBox textBoxForname, TextBox textBoxLogin, TextBox textBoxPassword, List<string> textBoxList)
        {
            this.textBoxName = textBoxName;
            this.textBoxForname = textBoxForname;
            this.textBoxLogin = textBoxLogin;
            this.textBoxPassword = textBoxPassword;
            this.textBoxList = textBoxList;
        }

        public void clearText()
        {
            textBoxName.Clear();
            textBoxForname.Clear();
            textBoxLogin.Clear();
            textBoxPassword.Clear();
        }

        public void addTextBoxToList()
        {
            textBoxList.Add(textBoxName.Text);
            textBoxList.Add(textBoxForname.Text);
            textBoxList.Add(textBoxLogin.Text);
            textBoxList.Add(textBoxPassword.Text);
        }


    }
}
