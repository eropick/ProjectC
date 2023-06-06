using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectCalculator
{
    public partial class formHistory : Form
    {
        private ListViewItem item;

        public ListViewItem FocusedItem
        {
            get { return item; }
            set { item = value; }
        }

        public formHistory()
        {
            InitializeComponent();
            item = null;
        }
        private void formHistory_Load(object sender, EventArgs e)
        {
            //아이템 수가 0이면 삭제메뉴 비활성화
            if (lvHistory.Items.Count == 0)
                tsmenuDelete.Visible = false;
            else
                tsmenuDelete.Visible = true;
        }

        private void lvHistory_DoubleClick(object sender, EventArgs e)
        {
            //해당 값을 저장함
            item = lvHistory.FocusedItem;
            //해당 폼을 닫음
            this.Close();
        }

        //아이템 삭제
        private void tsmenuDelete_Click(object sender, EventArgs e)
        {
            //체크된 아이템 수가 1이상인 경우만 실행
            if(lvHistory.SelectedItems.Count > 0)
            {
                if (lvHistory.FocusedItem != null)
                    lvHistory.Items.Remove(lvHistory.FocusedItem);
            }
                
            //삭제 후에 아이템 수가 0이면 비활성화
            if (lvHistory.Items.Count == 0)
                tsmenuDelete.Visible = false;
            else
                tsmenuDelete.Visible = true;
        }

        public void AddItem(string Expression, string Result)
        {
            ListViewItem item = new ListViewItem(new String[] {Expression, Result});
            lvHistory.Items.Add(item);
        }
        public int ItemCnt()
        {
            return lvHistory.Items.Count;
        }

        public ListViewItem getItem(int index)
        {
            if (index >= 0 && index < lvHistory.Items.Count)
                return lvHistory.Items[index];
            else
                return null;
        }

        public void ClearItems()
        {
            lvHistory.Items.Clear();
        }
    }
}
