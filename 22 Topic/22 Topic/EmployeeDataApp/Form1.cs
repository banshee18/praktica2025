using System;
using System.Text;
using System.Windows.Forms;

namespace EmployeeDataApp
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!ValidateInput())
            {
                MessageBox.Show("Пожалуйста, заполните все обязательные поля", "Ошибка",
                              MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            SaveEmployeeData();
            MessageBox.Show("Данные сотрудника успешно сохранены!", "Успех",
                          MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private bool ValidateInput()
        {
            if (string.IsNullOrWhiteSpace(txtLastName.Text) ||
                string.IsNullOrWhiteSpace(txtFirstName.Text) ||
                string.IsNullOrWhiteSpace(txtDay.Text) ||
                cmbMonth.SelectedIndex == -1 ||
                string.IsNullOrWhiteSpace(txtYear.Text))
            {
                return false;
            }
            return true;
        }

        private void SaveEmployeeData()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("=== Анкетные данные сотрудника ===");
            sb.AppendLine($"ФИО: {txtLastName.Text} {txtFirstName.Text} {txtMiddleName.Text}");
            sb.AppendLine($"Дата рождения: {txtDay.Text} {cmbMonth.SelectedItem} {txtYear.Text}");
            sb.AppendLine($"Место проживания: {txtLocation.Text}");
            sb.AppendLine($"Email: {txtEmail.Text}");
            sb.AppendLine($"Телефон: {cmbOperator.Text} {txtPhone.Text}");

            sb.Append("Опыт работы: ");
            if (rbExpNone.Checked) sb.AppendLine("Прежде не работал");
            else if (rbExp1to5.Checked) sb.AppendLine("От 1 года до 5 лет");
            else if (rbExp5to9.Checked) sb.AppendLine("От 5 до 9 лет");
            else if (rbExp10plus.Checked) sb.AppendLine("10 лет и более");
            else if (rbExpLess1.Checked) sb.AppendLine("Меньше 1 года");

            sb.Append("Другие сведения: ");
            if (chkHasCar.Checked) sb.Append("Наличие личного авто; ");
            if (chkHasLicense.Checked) sb.Append("Водительское удостоверение; ");

            sb.Append("Категория прав: ");
            if (chkCategoryA.Checked) sb.Append("A ");
            if (chkCategoryB.Checked) sb.Append("B ");
            if (chkCategoryC.Checked) sb.Append("C ");
            if (chkCategoryD.Checked) sb.Append("D ");
            sb.AppendLine();

            sb.AppendLine($"Зарплата: от {numSalaryFrom.Value} до {numSalaryTo.Value}");

            sb.Append("График работы: ");
            if (rbFullTime.Checked) sb.AppendLine("полная занятость");
            else if (rbPartTime.Checked) sb.AppendLine("частичная занятость");
            else if (rbHomeWork.Checked) sb.AppendLine("работа на дому");
            else if (rbShiftWork.Checked) sb.AppendLine("посменная работа");

            sb.AppendLine($"Резюме: {txtSummary.Text}");

            // В реальном приложении здесь было бы сохранение в БД или файл
            Console.WriteLine(sb.ToString());
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Вы действительно хотите очистить все поля?",
                              "Подтверждение",
                              MessageBoxButtons.YesNo,
                              MessageBoxIcon.Question) == DialogResult.Yes)
            {
                ClearForm();
            }
        }

        private void ClearForm()
        {
            txtLastName.Clear();
            txtFirstName.Clear();
            txtMiddleName.Clear();
            txtDay.Clear();
            cmbMonth.SelectedIndex = -1;
            txtYear.Clear();
            txtLocation.Clear();
            txtEmail.Clear();
            cmbOperator.SelectedIndex = -1;
            txtPhone.Clear();
            txtSummary.Clear();
            numSalaryFrom.Value = numSalaryFrom.Minimum;
            numSalaryTo.Value = numSalaryTo.Minimum;

            rbExpNone.Checked = false;
            rbExp1to5.Checked = false;
            rbExp5to9.Checked = false;
            rbExp10plus.Checked = false;
            rbExpLess1.Checked = false;

            chkHasCar.Checked = false;
            chkHasLicense.Checked = false;
            chkCategoryA.Checked = false;
            chkCategoryB.Checked = false;
            chkCategoryC.Checked = false;
            chkCategoryD.Checked = false;

            rbFullTime.Checked = false;
            rbPartTime.Checked = false;
            rbHomeWork.Checked = false;
            rbShiftWork.Checked = false;

            txtLastName.Focus();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Вы действительно хотите закрыть приложение?",
                              "Подтверждение",
                              MessageBoxButtons.YesNo,
                              MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void txtDay_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '\b')
                e.Handled = true;
        }

        private void txtYear_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '\b')
                e.Handled = true;
        }

        private void txtPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) &&
                e.KeyChar != '(' && e.KeyChar != ')' &&
                e.KeyChar != '+' && e.KeyChar != '-' &&
                e.KeyChar != '\b')
            {
                e.Handled = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(this, helpProvider1.HelpNamespace);
        }
    }
}