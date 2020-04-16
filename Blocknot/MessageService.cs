using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Blocknot
{
    public interface IMessageService
    {
        void ShowMessage(string message);
        void ShowExalamation(string exalamation);

        void ShowError(string error);
    }
    class MessageService: IMessageService
    {
        public void ShowMessage(string message)
        {
            MessageBox.Show(message, "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);


        }

        public void ShowExalamation (string exalamation)
        {
            MessageBox.Show(exalamation, "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        public void ShowError(string error)
        {
            MessageBox.Show(error, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
