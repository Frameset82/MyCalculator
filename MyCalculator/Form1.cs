using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// 21.09.08 Lee SeungHyun Wemade
namespace MyCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            valueInitializing();
        }

        private bool errFlag = false;    // 에러 존재 여부 변수
        private bool opFlag = false;     // 피연산자 존재 여부 변수
        private double savedValue = 0;   // 피연산자 저장 변수
        private double savedOpCount = 0; // 연속 연산 카운트 변수
        private char op = '=';           // 현재 연산자 변수

        // 에러텍스트 처리 메서드
        private void errorHandling()
        {
            if (errFlag == true)
            {
                resTxt.Text = "";
                errFlag = false;
            }
        }

        // 숫자 버튼 클릭 메서드
        private void btnNumber_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;

            if (resTxt.Text == "0" || opFlag == true){
                resTxt.Text = btn.Text;
                opFlag = false;
            }
            else {
                errorHandling();
                resTxt.Text = resTxt.Text + btn.Text;
            }
            double v = Double.Parse(resTxt.Text);
            resTxt.Text = commaProcedure(v, resTxt.Text);

        }

        // 콤마 생성 메서드
        private static string commaProcedure(double v, string s)
        {
            int pos = 0;
            if (s.Contains("."))
            {
                pos = s.Length - s.IndexOf('.');
              if (pos == 1)   // 맨 뒤에 소수점이 있으면 그대로 리턴
                    return s;
                string formatStr = "{0:N" + (pos - 1) + "}";
                s = string.Format(formatStr, v);
            }
            else
                s = string.Format("{0:N0}", v);
            return s;
        }

        // 소수점 버튼 클릭 메서드
        private void btnDot_Click(object sender, EventArgs e)
        {
            if (resTxt.Text.Contains("."))
                return;
            else
                resTxt.Text += ".";
        }

        // 부호 변경 버튼 클릭 메서드
        private void btnChange_Click(object sender, EventArgs e)
        {
            if (errFlag == true) return;
            double v = Double.Parse(resTxt.Text);
            resTxt.Text = (-v).ToString();
        }

        // 더하기 버튼 클릭 메서드
        private void btnPlus_Click(object sender, EventArgs e)
        {
            if (errFlag == true) return;
            savedOpCount++;
            if (savedOpCount >= 2) {
                runCalculation();
                savedValue = Double.Parse(resTxt.Text);
                expTxt.Text = resTxt.Text + " + ";
                op = '+';
                opFlag = true;
            }
            else {
                savedValue = Double.Parse(resTxt.Text);
                expTxt.Text = resTxt.Text + " + ";
                op = '+';
                opFlag = true;
            }
        }

        // 빼기 버튼 클릭 메서드
        private void btnMinus_Click(object sender, EventArgs e)
        {
            if (errFlag == true) return;
            savedOpCount++;
            if (savedOpCount >= 2) {
                runCalculation();
                savedValue = Double.Parse(resTxt.Text);
                expTxt.Text = resTxt.Text + " - ";
                op = '-';
                opFlag = true;
            }
            else {
                savedValue = Double.Parse(resTxt.Text);
                expTxt.Text = resTxt.Text + " - ";
                op = '-';
                opFlag = true;
            }
        }

        // 곱하기 버튼 클릭 메서드
        private void btnMulti_Click(object sender, EventArgs e)
        {
            if (errFlag == true) return;
            savedOpCount++;
            if (savedOpCount >= 2)
            {
                runCalculation();
                savedValue = Double.Parse(resTxt.Text);
                expTxt.Text = resTxt.Text + " × ";
                op = '*';
                opFlag = true;
            }
            else {
                savedValue = Double.Parse(resTxt.Text);
                expTxt.Text = resTxt.Text + " × ";
                op = '*';
                opFlag = true;
            }
        }

        // 나누기 버튼 클릭 메서드
        private void btnDiv_Click(object sender, EventArgs e)
        {
            if (errFlag == true) return;
            savedOpCount++;
            if (savedOpCount >= 2)
            {
                runCalculation();
                savedValue = Double.Parse(resTxt.Text);
                expTxt.Text = resTxt.Text + " ÷ ";
                op = '/';
                opFlag = true;
            }
            else {
                savedValue = Double.Parse(resTxt.Text);
                expTxt.Text = resTxt.Text + " ÷ ";
                op = '/';
                opFlag = true;
            }
        }

        // 등호 버튼 클릭 메서드
        private void btnEqual_Click(object sender, EventArgs e)
        {
            if (errFlag == true) return;
            runCalculation(); // 계산 실행 호출
            savedOpCount = 0;
        }

        // 계산 처리 메서드
        private void runCalculation()
        {
            Double x = Double.Parse(resTxt.Text);
            switch (op)
            {
                case '+':
                    resTxt.Text = (savedValue + x).ToString();
                    break;
                case '-':
                    resTxt.Text = (savedValue - x).ToString();
                    break;
                case '*':
                    resTxt.Text = (savedValue * x).ToString();
                    break;
                case '/':
                    resTxt.Text = (savedValue / x).ToString();
                    break;
            }
            expTxt.Text = "";
            double v = Double.Parse(resTxt.Text);
            resTxt.Text = commaProcedure(v, resTxt.Text);
            savedValue = 0;
        }

        // 역수 연산 버튼 클릭 메서드
        private void btnRecip_Click(object sender, EventArgs e)
        {
            // 0값 연산 예외처리
            if (resTxt.Text.Equals("0") || errFlag == true) {
                resTxt.Text = "0으로 나눌 수 없습니다.";
                errFlag = true;
                //MessageBox.Show("0으로 나눌 수 없습니다.", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            expTxt.Text = "1 / (" + resTxt.Text + ") ";
            resTxt.Text = (1 / Double.Parse(resTxt.Text)).ToString();
        }

        // 퍼센트 연산 버튼 클릭 메서드
        private void btnPercent_Click(object sender, EventArgs e)
        {
            //if (errFlag == true) return;
            if (expTxt.Text == "") resTxt.Text = "0";
            double res = savedValue * (Double.Parse(resTxt.Text) / 100);
            resTxt.Text = res.ToString();
        }

        // 제곱 버튼 클릭 메서드
        private void btnSqr_Click(object sender, EventArgs e)
        {
            if (errFlag == true) return;
            expTxt.Text = "sqr(" + resTxt.Text + ") ";
            resTxt.Text = (Double.Parse(resTxt.Text) * Double.Parse(resTxt.Text)).ToString();
        }

        // 제곱근 버튼 클릭 메서드
        private void btnSqrt_Click(object sender, EventArgs e)
        {
            if (errFlag == true) return;
            expTxt.Text = "√(" + resTxt.Text + ") ";
            resTxt.Text = Math.Sqrt(Double.Parse(resTxt.Text)).ToString();
        }

        // 입력된 값 지우기(CE) 버튼 클릭 메서드
        private void btnCE_Click(object sender, EventArgs e)
        {
            resTxt.Text = "0";
        }

        // 초기화(C) 버튼 클릭 메서드
        private void btnC_Click(object sender, EventArgs e)
        {
            valueInitializing();
        }

        // 초기화 실행
        private void valueInitializing()
        {
            resTxt.Text = "0";
            expTxt.Text = "";
            savedValue = 0;
            op = '\0';
            opFlag = false;
        }

        // 지우기 버튼 클릭 메서드
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (errFlag == true) valueInitializing();
            resTxt.Text = resTxt.Text.Remove(resTxt.Text.Length - 1);
            if (resTxt.Text.Length == 0)
                resTxt.Text = "0";
        }
    }
}
