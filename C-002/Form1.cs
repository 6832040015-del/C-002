using System.Xml.Linq;

namespace C_002
{
    public partial class Form1 : Form
    {
        // สร้าง List ไว้เก็บข้อมูลพนักงาน (อยู่นอก Method เพื่อให้ทุกส่วนเรียกใช้ได้)
        List<Employee> employeeList = new List<Employee>();

        public Form1()
        {
            InitializeComponent();
            // เพิ่มตัวเลือกใน ComboBox ตอนเปิดโปรแกรม
            comboBoxType.Items.Add("พนักงานประจำ");
            comboBoxType.Items.Add("พนักงานพาร์ทไทม์");
            comboBoxType.SelectedIndex = 0;
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            // --- ส่วนนี้คือ Logic การรับค่าจากหน้าจอ ---
            Employee emp;
            if (comboBoxType.SelectedItem.ToString() == "พนักงานประจำ")
                emp = new FullTimeEmployee();
            else
                emp = new PartTimeEmployee();

            emp.ID = txtID.Text;
            emp.Name = txtName.Text;
            emp.Rate = double.Parse(txtRate.Text);

            employeeList.Add(emp);

            // แสดงผลใน DataGridView และคำนวณยอดรวม
            dgvDisplay.Rows.Add(emp.ID, emp.Name, comboBoxType.Text, emp.CalculateBonus().ToString("N2"));
            lblTotal.Text = "ยอดรวมพิเศษ: " + employeeList.Sum(x => x.CalculateBonus()).ToString("N2");
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtID_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblTotal_Click(object sender, EventArgs e)
        {

        }
    } // <--- ปีกกาปิดของ Form1

    // ############################################################
    // ### วางโครงสร้างคลาส (Logic การคำนวณ) ไว้ตรงนี้ครับ (นอก Form1) ###
    // ############################################################

    public abstract class Employee
    {
        public string ID { get; set; }
        public string Name { get; set; }
        public double Rate { get; set; }
        public abstract double CalculateBonus();
    }

    public class FullTimeEmployee : Employee
    {
        // พนักงานประจำ: เงินเดือน * 1.2
        public override double CalculateBonus() => Rate * 1.2;
    }

    public class PartTimeEmployee : Employee
    {
        // พนักงานพาร์ทไทม์: ค่าจ้างรายวัน * 5 วัน
        public override double CalculateBonus() => Rate * 5;
    }
} // <--- ปีกกาปิดของ Namespace