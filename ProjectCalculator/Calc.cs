using System.ComponentModel;
using System.Collections;
using System.IO;
using System.Security.Cryptography;

namespace ProjectCalculator
{
    public partial class formCalc : Form
    {
        private formHistory fHistory = null;
        private Algorithms algorithms;
        public formCalc()
        {
            InitializeComponent();
            algorithms = new Algorithms();
        }

        private void formCalc_Load(object sender, EventArgs e)
        {
            //��� �� �Ҵ�
            fHistory = new formHistory();

            //�Ϻ� ��� ��ư Text����
            //e^n
            btnEpowN.Text = "e"+ "\u207F";
            //x^n
            btnXpowN.Text = "x" + "\u207F";
            //x^2
            btnXpow2.Text = "x" + "\u00B2";

            //����, ���� ��ȭ���� �ʱ� ��� ����
            string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            ofdLoad.InitialDirectory = desktopPath;
            sfdSave.InitialDirectory = desktopPath;

            //Ÿ�̸� Ȱ��ȭ
            presentTime.Text = DateTime.Now.ToString("yyyy�� MM�� dd��(ddd) H�� mm�� ss��");
            presentTimer.Enabled = true;
        }

        //�ð� ǥ�� Ÿ�̸�
        private void presentTimer_Tick(object sender, EventArgs e)
        {
            DateTime now = DateTime.Now;
            string today = now.ToString("yyyy�� MM�� dd��(ddd) H�� mm�� ss��");
            presentTime.Text = today;
        }

        //�޴� �ɼ�
        //��Ϻ���
        private void tsmView_Click(object sender, EventArgs e)
        {
            if (fHistory.ShowDialog() == DialogResult.Cancel) {
                if (fHistory.FocusedItem != null)
                {
                    txtCalcLine.Text = fHistory.FocusedItem.SubItems[0].Text;
                    txtResultLine.Text = fHistory.FocusedItem.SubItems[1].Text;
                }
                return;
            }
        }

        //���� ����
        private void tsmLoadFile_Click(object sender, EventArgs e)
        {
            string path = "";
            if (ofdLoad.ShowDialog() == DialogResult.OK)
                path = ofdLoad.FileName;

            if (File.Exists(path))
            {
                //�ش� ��ο��� ���ϳ����� �о� ����Ʈ�信 �߰��մϴ�.
                using (StreamReader sr = new StreamReader(path))
                {
                    string Expression = "", Result = "=";
                    //���� ��� Ŭ����
                    fHistory.ClearItems();

                    while (!sr.EndOfStream)
                    {
                        Expression += sr.ReadLine();
                        Result += sr.ReadLine();
                        if (Expression == null || Result == null)
                            break;
                        sr.ReadLine(); //���п� ��
                        fHistory.AddItem(Expression, Result);
                        //�ʱ�ȭ
                        Expression = "";
                        Result = "=";
                    }
                }
            }
            else
            {
                MessageBox.Show("���⿡ �����߽��ϴ�.", "����",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //���� ����
        private void tsmSaveFile_Click(object sender, EventArgs e)
        {
            string path = "";
            bool append = false;

            if (MessageBox.Show("����� �̾ �Ͻðڽ��ϱ�?", "�˸�",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                append = true;
            else
                append = false;

            if (sfdSave.ShowDialog() == DialogResult.OK)
                path = sfdSave.FileName;

            try
            {
                //����Ʈ�信 �ִ� ������ ���Ͽ� �����մϴ�.
                //�̾� ����(append = true)
                using (StreamWriter sw = new StreamWriter(path,append))
                {
                    string Expression = "", Result = "", Split = "-----------";
                    for (int i = 0; i < fHistory.ItemCnt(); ++i)
                    {
                        ListViewItem lvi = fHistory.getItem(i);
                        Expression = lvi.SubItems[0].Text;
                        Result = lvi.SubItems[1].Text;
                        Result = Result.Substring(1, Result.Length - 1);
                        sw.WriteLine(Expression);
                        sw.WriteLine(Result);
                        sw.WriteLine(Split);
                    }
                }
                MessageBox.Show("���忡 �����߽��ϴ�.", "�˸�",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch{
                MessageBox.Show("���忡 �����߽��ϴ�.","����",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        //�ﰢ�Լ�
        private void rbNormal_CheckedChanged(object sender, EventArgs e)
        {
            btnSin.Text = "sin";
            btnCos.Text = "cos";
            btnTan.Text = "tan";
        }

        //���ﰢ�Լ�
        private void rbArc_CheckedChanged(object sender, EventArgs e)
        {
            btnSin.Text = "sin" + "\u207B" + "\u00B9";
            btnCos.Text = "cos" + "\u207B" + "\u00B9";
            btnTan.Text = "tan" + "\u207B" + "\u00B9";
        }

        //Button C
        private void btnCancle_Click(object sender, EventArgs e)
        {
            this.txtCalcLine.Text = "";
            this.txtResultLine.Text = "=";
        }

        //Button Del
        private void btnDelete_Click(object sender, EventArgs e)
        {
            this.txtResultLine.Text = "=";
            string temp = this.txtCalcLine.Text;
            if (temp.Length > 0)
                this.txtCalcLine.Text = temp.Substring(0, temp.Length - 1);
        }

        //button0
        private void btn0_Click(object sender, EventArgs e)
        {
            string normal = "0";
            if (algorithms.checkNumber(txtCalcLine.Text))
                this.txtCalcLine.Text += normal;
            else
                this.txtCalcLine.Text += "x" + normal;
            this.txtResultLine.Text = "=";
        }

        //button1
        private void btn1_Click(object sender, EventArgs e)
        {
            string normal = "1";
            if (algorithms.checkNumber(txtCalcLine.Text))
                this.txtCalcLine.Text += normal;
            else
                this.txtCalcLine.Text += "x" + normal;
            this.txtResultLine.Text = "=";
        }

        //button2
        private void btn2_Click(object sender, EventArgs e)
        {
            string normal = "2";
            if (algorithms.checkNumber(txtCalcLine.Text))
                this.txtCalcLine.Text += normal;
            else
                this.txtCalcLine.Text += "x" + normal;
            this.txtResultLine.Text = "=";
        }

        //button3
        private void btn3_Click(object sender, EventArgs e)
        {
            string normal = "3";
            if (algorithms.checkNumber(txtCalcLine.Text))
                this.txtCalcLine.Text += normal;
            else
                this.txtCalcLine.Text += "x" + normal;
            this.txtResultLine.Text = "=";
        }

        //button4
        private void btn4_Click(object sender, EventArgs e)
        {
            string normal = "4";
            if (algorithms.checkNumber(txtCalcLine.Text))
                this.txtCalcLine.Text += normal;
            else
                this.txtCalcLine.Text += "x" + normal;
            this.txtResultLine.Text = "=";
        }

        //button5
        private void btn5_Click(object sender, EventArgs e)
        {
            string normal = "5";
            if (algorithms.checkNumber(txtCalcLine.Text))
                this.txtCalcLine.Text += normal;
            else
                this.txtCalcLine.Text += "x" + normal;
            this.txtResultLine.Text = "=";
        }

        //button6
        private void btn6_Click(object sender, EventArgs e)
        {
            string normal = "6";
            if (algorithms.checkNumber(txtCalcLine.Text))
                this.txtCalcLine.Text += normal;
            else
                this.txtCalcLine.Text += "x" + normal;
            this.txtResultLine.Text = "=";
        }

        //button7
        private void btn7_Click(object sender, EventArgs e)
        {
            string normal = "7";
            if (algorithms.checkNumber(txtCalcLine.Text))
                this.txtCalcLine.Text += normal;
            else
                this.txtCalcLine.Text += "x" + normal;
            this.txtResultLine.Text = "=";
        }

        //button8
        private void btn8_Click(object sender, EventArgs e)
        {
            string normal = "8";
            if (algorithms.checkNumber(txtCalcLine.Text))
                this.txtCalcLine.Text += normal;
            else
                this.txtCalcLine.Text += "x" + normal;
            this.txtResultLine.Text = "=";
        }

        //button9
        private void btn9_Click(object sender, EventArgs e)
        {
            string normal = "9";
            if (algorithms.checkNumber(txtCalcLine.Text))
                this.txtCalcLine.Text += normal;
            else
                this.txtCalcLine.Text += "x" + normal;
            this.txtResultLine.Text = "=";
        }

        //button .
        private void btnDot_Click(object sender, EventArgs e)
        {
            string normal;
            if (algorithms.checkDot(txtCalcLine.Text) == 0)
                normal = "0.";
            else if (algorithms.checkDot(txtCalcLine.Text) == 1)
                normal = "x0.";
            else if (algorithms.checkDot(txtCalcLine.Text) == 2)
                normal = ".";
            else
                normal = "";
            this.txtCalcLine.Text += normal;
            this.txtResultLine.Text = "=";
        }

        //button +/-
        private void btnSign_Click(object sender, EventArgs e)
        {
            int check = algorithms.checkSign(txtCalcLine.Text);
            int length = txtCalcLine.Text.Length;

            //��� ���̽�
            int i = txtCalcLine.Text.LastIndexOf("(0-");
            if (length - 3 == (i == -1 ? -100 : i) ) 
            {
                txtCalcLine.Text = txtCalcLine.Text.Substring(0, length - 3);
                this.txtResultLine.Text = "=";
                return;
            }

            if (check >= 0) //index�� ���� ���
            {
                //���ڿ� ����
                string splitLeft = txtCalcLine.Text.Substring(0, check);
                string splitRight = txtCalcLine.Text.Substring(check);

                //��� ���̽�
                i = txtCalcLine.Text.LastIndexOf("(0-"); 
                if (splitLeft.Length - 3 == (i == -1 ? -100 : i)) //ã�� ���� ���� ��� -1��� -100
                {
                    txtCalcLine.Text = splitLeft.Substring(0, splitLeft.Length - 3) + splitRight;
                }
                else //����
                {
                    txtCalcLine.Text = splitLeft + "(0-" + splitRight;
                }
            }
            else if (check == -1) // (0- �⺻ ���̽�
                txtCalcLine.Text += "(0-";
            else if (check == -2) // x(0- ���� ���̽�
                txtCalcLine.Text += "x(0-";
            else if (check == -3)
            {
                //��� ���̽�
                i = txtCalcLine.Text.LastIndexOf("(0-"); 
                if (length - 4 == (i==-1 ? -100 : i))
                {
                    char c = txtCalcLine.Text[length - 1];
                    txtCalcLine.Text = txtCalcLine.Text.Substring(0, length - 4) + c;
                }
                else
                {
                    char c = txtCalcLine.Text[length - 1];
                    txtCalcLine.Text = txtCalcLine.Text.Substring(0, length - 1) + "(0-" + c;
                }
            }
            this.txtResultLine.Text = "=";
        }

        //button +
        private void btnPlus_Click(object sender, EventArgs e)
        {
            string normal = "+";
            int check = algorithms.checkOper(txtCalcLine.Text);
            //�⺻
            if (check == 0)
            {
                this.txtCalcLine.Text += normal;
            }
            else if (check == 1) //�����ڰ� �տ� �ִ� ���
            {
                int length = this.txtCalcLine.Text.Length;
                this.txtCalcLine.Text = this.txtCalcLine.Text.Substring(0, length - 1) + normal;
            }
            else if (check == 2)
            {
                this.txtCalcLine.Text += "0" + normal;
            }
            else
                //nothing..
            this.txtResultLine.Text = "=";
        }

        //button -
        private void btnMinus_Click(object sender, EventArgs e)
        {
            string normal = "-";
            int check = algorithms.checkOper(txtCalcLine.Text);
            //�⺻
            if (check == 0)
            {
                this.txtCalcLine.Text += normal;
            }
            else if (check == 1) //�����ڰ� �տ� �ִ� ���
            {
                int length = this.txtCalcLine.Text.Length;
                this.txtCalcLine.Text = this.txtCalcLine.Text.Substring(0, length - 1) + normal;
            }
            else if (check == 2)
            {
                this.txtCalcLine.Text += "0" + normal;
            }
            else
                //nothing..
                this.txtResultLine.Text = "=";
        }

        //button x
        private void btnMultiply_Click(object sender, EventArgs e)
        {
            string normal = "x";
            int check = algorithms.checkOper(txtCalcLine.Text);
            //�⺻
            if (check == 0)
            {
                this.txtCalcLine.Text += normal;
            }
            else if (check == 1) //�����ڰ� �տ� �ִ� ���
            {
                int length = this.txtCalcLine.Text.Length;
                this.txtCalcLine.Text = this.txtCalcLine.Text.Substring(0, length - 1) + normal;
            }
            else
                //nothing..
                this.txtResultLine.Text = "=";
        }

        //button ��
        private void btnDivide_Click(object sender, EventArgs e)
        {
            string normal = "��";
            int check = algorithms.checkOper(txtCalcLine.Text);
            //�⺻
            if (check == 0)
            {
                this.txtCalcLine.Text += normal;
            }
            else if (check == 1) //�����ڰ� �տ� �ִ� ���
            {
                int length = this.txtCalcLine.Text.Length;
                this.txtCalcLine.Text = this.txtCalcLine.Text.Substring(0, length - 1) + normal;
            }
            else
                //nothing..
                this.txtResultLine.Text = "=";
        }

        //button ��
        private void btnRoot_Click(object sender, EventArgs e)
        {
            string normal = "��(";
            if (algorithms.checkFunc(txtCalcLine.Text) == 0)
                txtCalcLine.Text += normal;
            else if (algorithms.checkFunc(txtCalcLine.Text) == 1)
                txtCalcLine.Text += "x" + normal;
            this.txtResultLine.Text = "=";
        }

        //button (
        private void btnLBracket_Click(object sender, EventArgs e)
        {
            string normal = "(";
            if (algorithms.checkFunc(txtCalcLine.Text) == 0)
                txtCalcLine.Text += normal;
            else if (algorithms.checkFunc(txtCalcLine.Text) == 1)
                txtCalcLine.Text += "x" + normal;
            this.txtResultLine.Text = "=";
        }

        //button )
        private void btnRBracket_Click(object sender, EventArgs e)
        {
            string normal = ")";
            //���� ���Ŀ� ���� ��ȣ �˻� �Ҹ����� ����
            if(!algorithms.checkBracket(txtCalcLine.Text))
                this.txtCalcLine.Text += normal;
            this.txtResultLine.Text = "=";
        }

        //button sin
        private void btnSin_Click(object sender, EventArgs e)
        {
            string normal = "sin(";
            string arc = "sin" + "\u207B" + "\u00B9" + "(";

            if (rbArc.Checked)
                normal = arc;

            //�⺻
            if (algorithms.checkFunc(txtCalcLine.Text) == 0)
                txtCalcLine.Text += normal;
            else if(algorithms.checkFunc(txtCalcLine.Text) == 1) //��������
                txtCalcLine.Text += "x"+normal;
            this.txtResultLine.Text = "=";
        }

        //button cos
        private void btnCos_Click(object sender, EventArgs e)
        {
            string normal = "cos(";
            string arc = "cos" + "\u207B" + "\u00B9" + "(";
            if (rbArc.Checked)
                normal = arc;

            if (algorithms.checkFunc(txtCalcLine.Text) == 0)
                txtCalcLine.Text += normal;
            else if (algorithms.checkFunc(txtCalcLine.Text) == 1)
                txtCalcLine.Text += "x" + normal;
            this.txtResultLine.Text = "=";
        }

        //button tan
        private void btnTan_Click(object sender, EventArgs e)
        {
            string normal = "tan(";
            string arc = "tan" + "\u207B" + "\u00B9" + "(";
            if (rbArc.Checked)
                normal = arc;

            if (algorithms.checkFunc(txtCalcLine.Text) == 0)
                txtCalcLine.Text += normal;
            else if (algorithms.checkFunc(txtCalcLine.Text) == 1)
                txtCalcLine.Text += "x" + normal;
            this.txtResultLine.Text = "=";
        }

        //button ln
        private void btnLogE_Click(object sender, EventArgs e)
        {
            string normal = "ln(";
            if (algorithms.checkFunc(txtCalcLine.Text) == 0)
                txtCalcLine.Text += normal;
            else if (algorithms.checkFunc(txtCalcLine.Text) == 1)
                txtCalcLine.Text += "x" + normal;
            this.txtResultLine.Text = "=";
        }

        //button Log
        private void btnLog_Click(object sender, EventArgs e)
        {
            string normal = "log(";
            if (algorithms.checkFunc(txtCalcLine.Text) == 0)
                txtCalcLine.Text += normal;
            else if (algorithms.checkFunc(txtCalcLine.Text) == 1)
                txtCalcLine.Text += "x" + normal;
            this.txtResultLine.Text = "=";
        }

        //button 1/x
        private void btn1DivideX_Click(object sender, EventArgs e)
        {
            string normal = "1��";
            if (algorithms.checkFunc(txtCalcLine.Text) == 0)
                txtCalcLine.Text += normal;
            else if (algorithms.checkFunc(txtCalcLine.Text) == 1)
                txtCalcLine.Text += "x" + normal;
            this.txtResultLine.Text = "=";
        }

        //button e^n
        private void btnEpowN_Click(object sender, EventArgs e)
        {
            string normal = "e^(";
            if (algorithms.checkFunc(txtCalcLine.Text) == 0)
                txtCalcLine.Text += normal;
            else if (algorithms.checkFunc(txtCalcLine.Text) == 1)
                txtCalcLine.Text += "x" + normal;
            this.txtResultLine.Text = "=";
        }

        //button x^2
        private void btnXpow2_Click(object sender, EventArgs e)
        {
            string normal = "^(2)";
            if (algorithms.checkFunc(txtCalcLine.Text) == 1) //���ڳ� ������ ��ȣ
            {
                this.txtCalcLine.Text += normal;
                this.txtResultLine.Text = "=";
            }
        }

        //button x^n
        private void btnXpowN_Click(object sender, EventArgs e)
        {
            string normal = "^(";
            if (algorithms.checkFunc(txtCalcLine.Text) == 1) 
            {
                this.txtCalcLine.Text += normal;
               this.txtResultLine.Text = "=";
            }
        }

        //button |x|
        private void btnAbsX_Click(object sender, EventArgs e)
        {
            string normal = "abs(";
            if (algorithms.checkFunc(txtCalcLine.Text) == 0)
                txtCalcLine.Text += normal;
            else if (algorithms.checkFunc(txtCalcLine.Text) == 1)
                txtCalcLine.Text += "x" + normal;
            this.txtResultLine.Text = "=";
        }

        //button ��
        private void btnPi_Click(object sender, EventArgs e)
        {
            string normal = "��";
            if (algorithms.checkFunc(txtCalcLine.Text) == 0)
                txtCalcLine.Text += normal;
            else if (algorithms.checkFunc(txtCalcLine.Text) == 1)
                txtCalcLine.Text += "x" + normal;
            this.txtResultLine.Text = "=";
        }

        //button e
        private void btnE_Click(object sender, EventArgs e)
        {
            string normal = "e";
            if (algorithms.checkFunc(txtCalcLine.Text) == 0)
                txtCalcLine.Text += normal;
            else if (algorithms.checkFunc(txtCalcLine.Text) == 1)
                txtCalcLine.Text += "x" + normal;
            this.txtResultLine.Text = "=";
        }

        //button Back
        private void btnBack_Click(object sender, EventArgs e)
        {
            int index = fHistory.ItemCnt();
            if (index > 0)
            {
                //History���� �ٷ� ���� ��� ����� ������
                ListViewItem lvi = fHistory.getItem(index - 1);
                txtCalcLine.Text = lvi.SubItems[0].Text;
                txtResultLine.Text = lvi.SubItems[1].Text;
            }
            else
                MessageBox.Show("���� ����� �����ϴ�.", "����",
                   MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        //button =
        private void btnEqual_Click(object sender, EventArgs e)
        {
            //0���� ������ �˻�
            if (txtCalcLine.Text.IndexOf("��0") != -1)
            {
                MessageBox.Show("0���� ���� �� �����ϴ�.", "����",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.txtCalcLine.Text = "";
                return;
            }

            //��ȣ �˻�
            if(!algorithms.checkBracket(txtCalcLine.Text))
            {
                MessageBox.Show("��ȣ�� �����ּ���.", "����",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                algorithms.Parsing(txtCalcLine.Text);
                algorithms.InfixToPostfix();
                this.txtResultLine.Text = "=" + algorithms.getResult(rbRadToDeg.Checked).ToString();
                fHistory.AddItem(txtCalcLine.Text, txtResultLine.Text);
            }
            catch
            {
                MessageBox.Show("������ �ϼ����ּ���.", "����",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}