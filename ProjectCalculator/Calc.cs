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
            //기록 폼 할당
            fHistory = new formHistory();

            //일부 계산 버튼 Text변경
            //e^n
            btnEpowN.Text = "e"+ "\u207F";
            //x^n
            btnXpowN.Text = "x" + "\u207F";
            //x^2
            btnXpow2.Text = "x" + "\u00B2";

            //열기, 저장 대화상자 초기 경로 설정
            string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            ofdLoad.InitialDirectory = desktopPath;
            sfdSave.InitialDirectory = desktopPath;

            //타이머 활성화
            presentTime.Text = DateTime.Now.ToString("yyyy년 MM월 dd일(ddd) H시 mm분 ss초");
            presentTimer.Enabled = true;
        }

        //시간 표시 타이머
        private void presentTimer_Tick(object sender, EventArgs e)
        {
            DateTime now = DateTime.Now;
            string today = now.ToString("yyyy년 MM월 dd일(ddd) H시 mm분 ss초");
            presentTime.Text = today;
        }

        //메뉴 옵션
        //기록보기
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

        //파일 열기
        private void tsmLoadFile_Click(object sender, EventArgs e)
        {
            string path = "";
            if (ofdLoad.ShowDialog() == DialogResult.OK)
                path = ofdLoad.FileName;

            if (File.Exists(path))
            {
                //해당 경로에서 파일내용을 읽어 리스트뷰에 추가합니다.
                using (StreamReader sr = new StreamReader(path))
                {
                    string Expression = "", Result = "=";
                    //기존 기록 클리어
                    fHistory.ClearItems();

                    while (!sr.EndOfStream)
                    {
                        Expression += sr.ReadLine();
                        Result += sr.ReadLine();
                        if (Expression == null || Result == null)
                            break;
                        sr.ReadLine(); //구분용 선
                        fHistory.AddItem(Expression, Result);
                        //초기화
                        Expression = "";
                        Result = "=";
                    }
                }
            }
            else
            {
                MessageBox.Show("열기에 실패했습니다.", "에러",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //파일 저장
        private void tsmSaveFile_Click(object sender, EventArgs e)
        {
            string path = "";
            bool append = false;

            if (MessageBox.Show("기록을 이어서 하시겠습니까?", "알림",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                append = true;
            else
                append = false;

            if (sfdSave.ShowDialog() == DialogResult.OK)
                path = sfdSave.FileName;

            try
            {
                //리스트뷰에 있는 내용을 파일에 저장합니다.
                //이어 쓰기(append = true)
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
                MessageBox.Show("저장에 성공했습니다.", "알림",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch{
                MessageBox.Show("저장에 실패했습니다.","에러",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        //삼각함수
        private void rbNormal_CheckedChanged(object sender, EventArgs e)
        {
            btnSin.Text = "sin";
            btnCos.Text = "cos";
            btnTan.Text = "tan";
        }

        //역삼각함수
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

            //취소 케이스
            int i = txtCalcLine.Text.LastIndexOf("(0-");
            if (length - 3 == (i == -1 ? -100 : i) ) 
            {
                txtCalcLine.Text = txtCalcLine.Text.Substring(0, length - 3);
                this.txtResultLine.Text = "=";
                return;
            }

            if (check >= 0) //index를 받은 경우
            {
                //문자열 분할
                string splitLeft = txtCalcLine.Text.Substring(0, check);
                string splitRight = txtCalcLine.Text.Substring(check);

                //취소 케이스
                i = txtCalcLine.Text.LastIndexOf("(0-"); 
                if (splitLeft.Length - 3 == (i == -1 ? -100 : i)) //찾는 값이 없는 경우 -1대신 -100
                {
                    txtCalcLine.Text = splitLeft.Substring(0, splitLeft.Length - 3) + splitRight;
                }
                else //삽입
                {
                    txtCalcLine.Text = splitLeft + "(0-" + splitRight;
                }
            }
            else if (check == -1) // (0- 기본 케이스
                txtCalcLine.Text += "(0-";
            else if (check == -2) // x(0- 곱셈 케이스
                txtCalcLine.Text += "x(0-";
            else if (check == -3)
            {
                //취소 케이스
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
            //기본
            if (check == 0)
            {
                this.txtCalcLine.Text += normal;
            }
            else if (check == 1) //연산자가 앞에 있는 경우
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
            //기본
            if (check == 0)
            {
                this.txtCalcLine.Text += normal;
            }
            else if (check == 1) //연산자가 앞에 있는 경우
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
            //기본
            if (check == 0)
            {
                this.txtCalcLine.Text += normal;
            }
            else if (check == 1) //연산자가 앞에 있는 경우
            {
                int length = this.txtCalcLine.Text.Length;
                this.txtCalcLine.Text = this.txtCalcLine.Text.Substring(0, length - 1) + normal;
            }
            else
                //nothing..
                this.txtResultLine.Text = "=";
        }

        //button ÷
        private void btnDivide_Click(object sender, EventArgs e)
        {
            string normal = "÷";
            int check = algorithms.checkOper(txtCalcLine.Text);
            //기본
            if (check == 0)
            {
                this.txtCalcLine.Text += normal;
            }
            else if (check == 1) //연산자가 앞에 있는 경우
            {
                int length = this.txtCalcLine.Text.Length;
                this.txtCalcLine.Text = this.txtCalcLine.Text.Substring(0, length - 1) + normal;
            }
            else
                //nothing..
                this.txtResultLine.Text = "=";
        }

        //button √
        private void btnRoot_Click(object sender, EventArgs e)
        {
            string normal = "√(";
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
            //기존 수식에 대한 괄호 검사 불만족할 때만
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

            //기본
            if (algorithms.checkFunc(txtCalcLine.Text) == 0)
                txtCalcLine.Text += normal;
            else if(algorithms.checkFunc(txtCalcLine.Text) == 1) //곱셈적용
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
            string normal = "1÷";
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
            if (algorithms.checkFunc(txtCalcLine.Text) == 1) //숫자나 오른쪽 괄호
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

        //button π
        private void btnPi_Click(object sender, EventArgs e)
        {
            string normal = "π";
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
                //History에서 바로 이전 계산 기록을 가져옴
                ListViewItem lvi = fHistory.getItem(index - 1);
                txtCalcLine.Text = lvi.SubItems[0].Text;
                txtResultLine.Text = lvi.SubItems[1].Text;
            }
            else
                MessageBox.Show("이전 기록이 없습니다.", "에러",
                   MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        //button =
        private void btnEqual_Click(object sender, EventArgs e)
        {
            //0으로 나누기 검사
            if (txtCalcLine.Text.IndexOf("÷0") != -1)
            {
                MessageBox.Show("0으로 나눌 수 없습니다.", "에러",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.txtCalcLine.Text = "";
                return;
            }

            //괄호 검사
            if(!algorithms.checkBracket(txtCalcLine.Text))
            {
                MessageBox.Show("괄호를 맞춰주세요.", "에러",
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
                MessageBox.Show("수식을 완성해주세요.", "에러",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}