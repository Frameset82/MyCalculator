
namespace MyCalculator
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.changeBtn = new System.Windows.Forms.Button();
            this.btn0 = new System.Windows.Forms.Button();
            this.dotBtn = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn1 = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btn9 = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.btn7 = new System.Windows.Forms.Button();
            this.equalBtn = new System.Windows.Forms.Button();
            this.plusBtn = new System.Windows.Forms.Button();
            this.minusBtn = new System.Windows.Forms.Button();
            this.mulBtn = new System.Windows.Forms.Button();
            this.divBtn = new System.Windows.Forms.Button();
            this.sqrtBtn = new System.Windows.Forms.Button();
            this.squBtn = new System.Windows.Forms.Button();
            this.recipBtn = new System.Windows.Forms.Button();
            this.delBtn = new System.Windows.Forms.Button();
            this.cBtn = new System.Windows.Forms.Button();
            this.ceBtn = new System.Windows.Forms.Button();
            this.persentBtn = new System.Windows.Forms.Button();
            this.resTxt = new System.Windows.Forms.TextBox();
            this.expTxt = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // changeBtn
            // 
            this.changeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.changeBtn.Font = new System.Drawing.Font("맑은 고딕", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.changeBtn.Location = new System.Drawing.Point(10, 385);
            this.changeBtn.Name = "changeBtn";
            this.changeBtn.Size = new System.Drawing.Size(70, 50);
            this.changeBtn.TabIndex = 0;
            this.changeBtn.Text = "±";
            this.changeBtn.UseVisualStyleBackColor = true;
            this.changeBtn.Click += new System.EventHandler(this.btnChange_Click);
            // 
            // btn0
            // 
            this.btn0.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn0.Font = new System.Drawing.Font("맑은 고딕", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn0.Location = new System.Drawing.Point(86, 385);
            this.btn0.Name = "btn0";
            this.btn0.Size = new System.Drawing.Size(70, 50);
            this.btn0.TabIndex = 1;
            this.btn0.Text = "0";
            this.btn0.UseVisualStyleBackColor = true;
            this.btn0.Click += new System.EventHandler(this.btnNumber_Click);
            // 
            // dotBtn
            // 
            this.dotBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dotBtn.Font = new System.Drawing.Font("맑은 고딕", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.dotBtn.Location = new System.Drawing.Point(162, 385);
            this.dotBtn.Name = "dotBtn";
            this.dotBtn.Size = new System.Drawing.Size(70, 50);
            this.dotBtn.TabIndex = 2;
            this.dotBtn.Text = ".";
            this.dotBtn.UseVisualStyleBackColor = true;
            this.dotBtn.Click += new System.EventHandler(this.btnDot_Click);
            // 
            // btn3
            // 
            this.btn3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn3.Font = new System.Drawing.Font("맑은 고딕", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn3.Location = new System.Drawing.Point(162, 329);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(70, 50);
            this.btn3.TabIndex = 5;
            this.btn3.Text = "3";
            this.btn3.UseVisualStyleBackColor = true;
            this.btn3.Click += new System.EventHandler(this.btnNumber_Click);
            // 
            // btn2
            // 
            this.btn2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn2.Font = new System.Drawing.Font("맑은 고딕", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn2.Location = new System.Drawing.Point(86, 329);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(70, 50);
            this.btn2.TabIndex = 4;
            this.btn2.Text = "2";
            this.btn2.UseVisualStyleBackColor = true;
            this.btn2.Click += new System.EventHandler(this.btnNumber_Click);
            // 
            // btn1
            // 
            this.btn1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn1.Font = new System.Drawing.Font("맑은 고딕", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn1.Location = new System.Drawing.Point(10, 329);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(70, 50);
            this.btn1.TabIndex = 3;
            this.btn1.Text = "1";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.btnNumber_Click);
            // 
            // btn6
            // 
            this.btn6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn6.Font = new System.Drawing.Font("맑은 고딕", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn6.Location = new System.Drawing.Point(162, 273);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(70, 50);
            this.btn6.TabIndex = 8;
            this.btn6.Text = "6";
            this.btn6.UseVisualStyleBackColor = true;
            this.btn6.Click += new System.EventHandler(this.btnNumber_Click);
            // 
            // btn5
            // 
            this.btn5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn5.Font = new System.Drawing.Font("맑은 고딕", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn5.Location = new System.Drawing.Point(86, 273);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(70, 50);
            this.btn5.TabIndex = 7;
            this.btn5.Text = "5";
            this.btn5.UseVisualStyleBackColor = true;
            this.btn5.Click += new System.EventHandler(this.btnNumber_Click);
            // 
            // btn4
            // 
            this.btn4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn4.Font = new System.Drawing.Font("맑은 고딕", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn4.Location = new System.Drawing.Point(10, 273);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(70, 50);
            this.btn4.TabIndex = 6;
            this.btn4.Text = "4";
            this.btn4.UseVisualStyleBackColor = true;
            this.btn4.Click += new System.EventHandler(this.btnNumber_Click);
            // 
            // btn9
            // 
            this.btn9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn9.Font = new System.Drawing.Font("맑은 고딕", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn9.Location = new System.Drawing.Point(162, 217);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(70, 50);
            this.btn9.TabIndex = 11;
            this.btn9.Text = "9";
            this.btn9.UseVisualStyleBackColor = true;
            this.btn9.Click += new System.EventHandler(this.btnNumber_Click);
            // 
            // btn8
            // 
            this.btn8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn8.Font = new System.Drawing.Font("맑은 고딕", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn8.Location = new System.Drawing.Point(86, 217);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(70, 50);
            this.btn8.TabIndex = 10;
            this.btn8.Text = "8";
            this.btn8.UseVisualStyleBackColor = true;
            this.btn8.Click += new System.EventHandler(this.btnNumber_Click);
            // 
            // btn7
            // 
            this.btn7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn7.Font = new System.Drawing.Font("맑은 고딕", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn7.Location = new System.Drawing.Point(10, 217);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(70, 50);
            this.btn7.TabIndex = 9;
            this.btn7.Text = "7";
            this.btn7.UseVisualStyleBackColor = true;
            this.btn7.Click += new System.EventHandler(this.btnNumber_Click);
            // 
            // equalBtn
            // 
            this.equalBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.equalBtn.Font = new System.Drawing.Font("맑은 고딕", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.equalBtn.Location = new System.Drawing.Point(238, 385);
            this.equalBtn.Name = "equalBtn";
            this.equalBtn.Size = new System.Drawing.Size(70, 50);
            this.equalBtn.TabIndex = 12;
            this.equalBtn.Text = "＝";
            this.equalBtn.UseVisualStyleBackColor = true;
            this.equalBtn.Click += new System.EventHandler(this.btnEqual_Click);
            // 
            // plusBtn
            // 
            this.plusBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.plusBtn.Font = new System.Drawing.Font("맑은 고딕", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.plusBtn.Location = new System.Drawing.Point(238, 329);
            this.plusBtn.Name = "plusBtn";
            this.plusBtn.Size = new System.Drawing.Size(70, 50);
            this.plusBtn.TabIndex = 13;
            this.plusBtn.Text = "＋";
            this.plusBtn.UseVisualStyleBackColor = true;
            this.plusBtn.Click += new System.EventHandler(this.btnPlus_Click);
            // 
            // minusBtn
            // 
            this.minusBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.minusBtn.Font = new System.Drawing.Font("맑은 고딕", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.minusBtn.Location = new System.Drawing.Point(238, 273);
            this.minusBtn.Name = "minusBtn";
            this.minusBtn.Size = new System.Drawing.Size(70, 50);
            this.minusBtn.TabIndex = 14;
            this.minusBtn.Text = "－";
            this.minusBtn.UseVisualStyleBackColor = true;
            this.minusBtn.Click += new System.EventHandler(this.btnMinus_Click);
            // 
            // mulBtn
            // 
            this.mulBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.mulBtn.Font = new System.Drawing.Font("맑은 고딕", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.mulBtn.Location = new System.Drawing.Point(238, 217);
            this.mulBtn.Name = "mulBtn";
            this.mulBtn.Size = new System.Drawing.Size(70, 50);
            this.mulBtn.TabIndex = 15;
            this.mulBtn.Text = "×";
            this.mulBtn.UseVisualStyleBackColor = true;
            this.mulBtn.Click += new System.EventHandler(this.btnMulti_Click);
            // 
            // divBtn
            // 
            this.divBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.divBtn.Font = new System.Drawing.Font("맑은 고딕", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.divBtn.Location = new System.Drawing.Point(238, 161);
            this.divBtn.Name = "divBtn";
            this.divBtn.Size = new System.Drawing.Size(70, 50);
            this.divBtn.TabIndex = 19;
            this.divBtn.Text = "÷";
            this.divBtn.UseVisualStyleBackColor = true;
            this.divBtn.Click += new System.EventHandler(this.btnDiv_Click);
            // 
            // sqrtBtn
            // 
            this.sqrtBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sqrtBtn.Font = new System.Drawing.Font("맑은 고딕", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.sqrtBtn.Location = new System.Drawing.Point(162, 161);
            this.sqrtBtn.Name = "sqrtBtn";
            this.sqrtBtn.Size = new System.Drawing.Size(70, 50);
            this.sqrtBtn.TabIndex = 18;
            this.sqrtBtn.Text = "2√x";
            this.sqrtBtn.UseVisualStyleBackColor = true;
            this.sqrtBtn.Click += new System.EventHandler(this.btnSqrt_Click);
            // 
            // squBtn
            // 
            this.squBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.squBtn.Font = new System.Drawing.Font("맑은 고딕", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.squBtn.Location = new System.Drawing.Point(86, 161);
            this.squBtn.Name = "squBtn";
            this.squBtn.Size = new System.Drawing.Size(70, 50);
            this.squBtn.TabIndex = 17;
            this.squBtn.Text = "x^2";
            this.squBtn.UseVisualStyleBackColor = true;
            this.squBtn.Click += new System.EventHandler(this.btnSqr_Click);
            // 
            // recipBtn
            // 
            this.recipBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.recipBtn.Font = new System.Drawing.Font("맑은 고딕", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.recipBtn.Location = new System.Drawing.Point(10, 161);
            this.recipBtn.Name = "recipBtn";
            this.recipBtn.Size = new System.Drawing.Size(70, 50);
            this.recipBtn.TabIndex = 16;
            this.recipBtn.Text = "1⁄x";
            this.recipBtn.UseVisualStyleBackColor = true;
            this.recipBtn.Click += new System.EventHandler(this.btnRecip_Click);
            // 
            // delBtn
            // 
            this.delBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.delBtn.Font = new System.Drawing.Font("맑은 고딕", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.delBtn.Location = new System.Drawing.Point(238, 105);
            this.delBtn.Name = "delBtn";
            this.delBtn.Size = new System.Drawing.Size(70, 50);
            this.delBtn.TabIndex = 23;
            this.delBtn.Text = "◀";
            this.delBtn.UseVisualStyleBackColor = true;
            this.delBtn.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // cBtn
            // 
            this.cBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cBtn.Font = new System.Drawing.Font("맑은 고딕", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.cBtn.Location = new System.Drawing.Point(162, 105);
            this.cBtn.Name = "cBtn";
            this.cBtn.Size = new System.Drawing.Size(70, 50);
            this.cBtn.TabIndex = 22;
            this.cBtn.Text = "C";
            this.cBtn.UseVisualStyleBackColor = true;
            this.cBtn.Click += new System.EventHandler(this.btnC_Click);
            // 
            // ceBtn
            // 
            this.ceBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ceBtn.Font = new System.Drawing.Font("맑은 고딕", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.ceBtn.Location = new System.Drawing.Point(86, 105);
            this.ceBtn.Name = "ceBtn";
            this.ceBtn.Size = new System.Drawing.Size(70, 50);
            this.ceBtn.TabIndex = 21;
            this.ceBtn.Text = "CE";
            this.ceBtn.UseVisualStyleBackColor = true;
            this.ceBtn.Click += new System.EventHandler(this.btnCE_Click);
            // 
            // persentBtn
            // 
            this.persentBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.persentBtn.Font = new System.Drawing.Font("맑은 고딕", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.persentBtn.Location = new System.Drawing.Point(10, 105);
            this.persentBtn.Name = "persentBtn";
            this.persentBtn.Size = new System.Drawing.Size(70, 50);
            this.persentBtn.TabIndex = 20;
            this.persentBtn.Text = "%";
            this.persentBtn.UseVisualStyleBackColor = true;
            this.persentBtn.Click += new System.EventHandler(this.btnPercent_Click);
            // 
            // resTxt
            // 
            this.resTxt.BackColor = System.Drawing.Color.White;
            this.resTxt.Font = new System.Drawing.Font("맑은 고딕", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.resTxt.Location = new System.Drawing.Point(10, 49);
            this.resTxt.Name = "resTxt";
            this.resTxt.ReadOnly = true;
            this.resTxt.Size = new System.Drawing.Size(298, 43);
            this.resTxt.TabIndex = 24;
            this.resTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // expTxt
            // 
            this.expTxt.BackColor = System.Drawing.Color.White;
            this.expTxt.Font = new System.Drawing.Font("맑은 고딕", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.expTxt.ForeColor = System.Drawing.Color.Silver;
            this.expTxt.Location = new System.Drawing.Point(10, 10);
            this.expTxt.Name = "expTxt";
            this.expTxt.ReadOnly = true;
            this.expTxt.Size = new System.Drawing.Size(298, 33);
            this.expTxt.TabIndex = 25;
            this.expTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(319, 439);
            this.Controls.Add(this.expTxt);
            this.Controls.Add(this.resTxt);
            this.Controls.Add(this.delBtn);
            this.Controls.Add(this.cBtn);
            this.Controls.Add(this.ceBtn);
            this.Controls.Add(this.persentBtn);
            this.Controls.Add(this.divBtn);
            this.Controls.Add(this.sqrtBtn);
            this.Controls.Add(this.squBtn);
            this.Controls.Add(this.recipBtn);
            this.Controls.Add(this.mulBtn);
            this.Controls.Add(this.minusBtn);
            this.Controls.Add(this.plusBtn);
            this.Controls.Add(this.equalBtn);
            this.Controls.Add(this.btn9);
            this.Controls.Add(this.btn8);
            this.Controls.Add(this.btn7);
            this.Controls.Add(this.btn6);
            this.Controls.Add(this.btn5);
            this.Controls.Add(this.btn4);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.dotBtn);
            this.Controls.Add(this.btn0);
            this.Controls.Add(this.changeBtn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button changeBtn;
        private System.Windows.Forms.Button btn0;
        private System.Windows.Forms.Button dotBtn;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btn6;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btn9;
        private System.Windows.Forms.Button btn8;
        private System.Windows.Forms.Button btn7;
        private System.Windows.Forms.Button equalBtn;
        private System.Windows.Forms.Button plusBtn;
        private System.Windows.Forms.Button minusBtn;
        private System.Windows.Forms.Button mulBtn;
        private System.Windows.Forms.Button divBtn;
        private System.Windows.Forms.Button sqrtBtn;
        private System.Windows.Forms.Button squBtn;
        private System.Windows.Forms.Button recipBtn;
        private System.Windows.Forms.Button delBtn;
        private System.Windows.Forms.Button cBtn;
        private System.Windows.Forms.Button ceBtn;
        private System.Windows.Forms.Button persentBtn;
        private System.Windows.Forms.TextBox resTxt;
        protected System.Windows.Forms.TextBox expTxt;
    }
}

