using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BonesAndStones
{
    public interface iMessages
    {
        void ShowMessage(string message);
        void ShowExclamation(string exclamation);
        void ShowError(string error);

    }
    public class сMessages : iMessages
    {
        public void ShowMessage(string message)
        {
            MessageBox.Show(message, "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public void ShowExclamation(string exclamation)
        {
            MessageBox.Show(exclamation, "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        public void ShowError(string error)
        {
            MessageBox.Show(error, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
