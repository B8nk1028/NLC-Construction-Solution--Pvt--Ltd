using System;
using System.Windows.Forms;
namespace AccountSystem
{
    public partial class frmYearCls : Form
    {
        public frmYearCls()
        {
            InitializeComponent();
            //Added to support default instance behavour in C#
            if (defaultInstance == null)
                defaultInstance = this;
        }
        private MyModule Fn = new MyModule();
        #region Default Instance
        private static frmYearCls defaultInstance;
        /// <summary>
        /// Added by the VB.Net to C# Converter to support default instance behavour in C#
        /// </summary>
        public static frmYearCls Default
        {
            get
            {
                if (defaultInstance == null)
                {
                    defaultInstance = new frmYearCls();
                    defaultInstance.FormClosed += new FormClosedEventHandler(defaultInstance_FormClosed);
                }
                return defaultInstance;
            }
        }
        private static void defaultInstance_FormClosed(object sender, FormClosedEventArgs e)
        {
            defaultInstance = null;
        }
        #endregion Default Instance
        private void tblMonthCloseingBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            if (Fn.LastDayOfMonthFromDateTime(Convert.ToDateTime(textDate.Text)) >= Fn.LastDayOfMonthFromDateTime(dateTimePicker3.Value) && Fn.FirstDayOfMonthFromDateTime(dateTimePicker1.Value) <= Fn.FirstDayOfMonthFromDateTime(dateTimePicker3.Value))
            {
                compIDTextBox.Text = Convert.ToString(MyModule.CompID);
                createdTextBox.Text = MyModule.UserName + "|" + DateTime.Now + "|" + MyModule.PCInfo;
                this.Validate();
                this.tblMonthCloseingBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.settingDS);
                //-----------------------------
                TextBox box = new TextBox();
                Fn.GetNum(box, "SELECT format(Amonth,'MMyyyy') as Amon FROM tblMonthCloseing WHERE (CompID =" + MyModule.CompID + ")");
                MyModule.AMonth = (string)box.Text;
                MyModule.ActiveYear = Fn.FirstDayOfMonthFromDateTime(dateTimePicker1.Value).ToString("yyyy-MMM-dd");
                MyModule.TermsCond = txtTC.Text;
                if (MyModule.AMonth == "")
                {
                    MessageBox.Show("There is no financial month,Please set financial month for this company");
                }
                //------------------------
                //-----------------------------
                //TextBox box2 = new TextBox();
                //Fn.GetNum(box2, "SELECT CONVERT(varchar, CashID) As CId FROM tblMonthCloseing WHERE (CompID =" + MyModule.CompID + ")");
                //MyModule.CashID = box2.Text;
                //if (MyModule.CashID == "")
                //{
                //    MessageBox.Show("Please set opening cash account for this company");
                //}
                //------------------------
            }
            else
            {
                MessageBox.Show("Please select a valid financial month for selected year ...");
            }
        }
        private void frmYearCls_Load(object sender, EventArgs e)
        {
            Fn.fillCombo(cboCrDr, "SELECT AccHeadID, AccHeadName FROM TblAccHead WHERE (CompanyID =" + MyModule.CompID + ") ORDER BY AccHeadName");
            if (Fn.GetRecords("SELECT CodeSt FROM tblMonthCloseing WHERE (CompID =" + MyModule.CompID + ")")[0] == "True")
            {
                Fn.fillCombo(cboOpeningRet, "SELECT TblAccEntry.EntryAccID,right(REPLICATE('0',2) + cast(TblAccHead.AccHeadCode as varchar(2)),2)+ '-' + right(REPLICATE('0',3) + cast(TblAccSubHead.AccSubCode as varchar(3)),3)+ '-' + right(REPLICATE('0',4) + cast(TblAccEntry.EntryAccCode as varchar(4)),4)+' '+TblAccEntry.EntryAccName AS Expr1 FROM TblAccHead INNER JOIN TblAccSubHead ON TblAccHead.AccHeadID = TblAccSubHead.AccHeadID INNER JOIN TblAccEntry ON TblAccSubHead.AccSubID = TblAccEntry.AccSubID WHERE (TblAccHead.CompanyID =" + MyModule.CompID + ") ORDER BY Expr1");
                Fn.fillCombo(cboPurchases, "SELECT TblAccEntry.EntryAccID,right(REPLICATE('0',2) + cast(TblAccHead.AccHeadCode as varchar(2)),2)+ '-' + right(REPLICATE('0',3) + cast(TblAccSubHead.AccSubCode as varchar(3)),3)+ '-' + right(REPLICATE('0',4) + cast(TblAccEntry.EntryAccCode as varchar(4)),4)+' '+TblAccEntry.EntryAccName AS Expr1 FROM TblAccHead INNER JOIN TblAccSubHead ON TblAccHead.AccHeadID = TblAccSubHead.AccHeadID INNER JOIN TblAccEntry ON TblAccSubHead.AccSubID = TblAccEntry.AccSubID WHERE (TblAccHead.CompanyID =" + MyModule.CompID + ") ORDER BY Expr1");
                Fn.fillCombo(cboSales, "SELECT TblAccEntry.EntryAccID,right(REPLICATE('0',2) + cast(TblAccHead.AccHeadCode as varchar(2)),2)+ '-' + right(REPLICATE('0',3) + cast(TblAccSubHead.AccSubCode as varchar(3)),3)+ '-' + right(REPLICATE('0',4) + cast(TblAccEntry.EntryAccCode as varchar(4)),4)+' '+TblAccEntry.EntryAccName AS Expr1 FROM TblAccHead INNER JOIN TblAccSubHead ON TblAccHead.AccHeadID = TblAccSubHead.AccHeadID INNER JOIN TblAccEntry ON TblAccSubHead.AccSubID = TblAccEntry.AccSubID WHERE (TblAccHead.CompanyID =" + MyModule.CompID + ") ORDER BY Expr1");
            }
            else
            {
                Fn.fillCombo(cboOpeningRet, "SELECT TblAccEntry.EntryAccID,TblAccEntry.EntryAccName+' '+right(REPLICATE('0',2) + cast(TblAccHead.AccHeadCode as varchar(2)),2)+ '-' + right(REPLICATE('0',3) + cast(TblAccSubHead.AccSubCode as varchar(3)),3)+ '-' + right(REPLICATE('0',4) + cast(TblAccEntry.EntryAccCode as varchar(4)),4) AS Expr1 FROM TblAccHead INNER JOIN TblAccSubHead ON TblAccHead.AccHeadID = TblAccSubHead.AccHeadID INNER JOIN TblAccEntry ON TblAccSubHead.AccSubID = TblAccEntry.AccSubID WHERE (TblAccHead.CompanyID =" + MyModule.CompID + ") ORDER BY Expr1");
                Fn.fillCombo(cboPurchases, "SELECT TblAccEntry.EntryAccID,TblAccEntry.EntryAccName+' '+right(REPLICATE('0',2) + cast(TblAccHead.AccHeadCode as varchar(2)),2)+ '-' + right(REPLICATE('0',3) + cast(TblAccSubHead.AccSubCode as varchar(3)),3)+ '-' + right(REPLICATE('0',4) + cast(TblAccEntry.EntryAccCode as varchar(4)),4) AS Expr1 FROM TblAccHead INNER JOIN TblAccSubHead ON TblAccHead.AccHeadID = TblAccSubHead.AccHeadID INNER JOIN TblAccEntry ON TblAccSubHead.AccSubID = TblAccEntry.AccSubID WHERE (TblAccHead.CompanyID =" + MyModule.CompID + ") ORDER BY Expr1");
                Fn.fillCombo(cboSales, "SELECT TblAccEntry.EntryAccID,TblAccEntry.EntryAccName+' '+right(REPLICATE('0',2) + cast(TblAccHead.AccHeadCode as varchar(2)),2)+ '-' + right(REPLICATE('0',3) + cast(TblAccSubHead.AccSubCode as varchar(3)),3)+ '-' + right(REPLICATE('0',4) + cast(TblAccEntry.EntryAccCode as varchar(4)),4) AS Expr1 FROM TblAccHead INNER JOIN TblAccSubHead ON TblAccHead.AccHeadID = TblAccSubHead.AccHeadID INNER JOIN TblAccEntry ON TblAccSubHead.AccSubID = TblAccEntry.AccSubID WHERE (TblAccHead.CompanyID =" + MyModule.CompID + ") ORDER BY Expr1");
            }
            // TODO: This line of code loads data into the 'settingDS.tblMonthCloseing' table. You can move, or remove it, as needed.
            this.tblMonthCloseingTableAdapter.Fill(this.settingDS.tblMonthCloseing, MyModule.CompID);
            if (settingDS.tblMonthCloseing.Rows.Count == 0)
            {
                bindingNavigatorAddNewItem.Visible = true;
                bindingNavigatorAddNewItem.PerformClick();
                bindingNavigatorAddNewItem.Visible = false;
            }
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            textDate.Text = Convert.ToDateTime(dateTimePicker1.Text).AddMonths(11).ToString("MMMM yyyy");
        }
    }
}